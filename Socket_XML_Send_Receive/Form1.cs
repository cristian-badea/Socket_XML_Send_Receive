using System;
using System.IO; // for File stream
using System.Net; // for IpEndPoint
using System.Net.Sockets; // for Sockets
using System.Text;
using System.Threading; // for Threads
using System.Windows.Forms;
using System.Xml; // for XmlTextReader and XmlValidatingReader
using System.Xml.Schema; // for XmlSchemaCollection

namespace Socket_XML_Send_Receive
{
    public partial class Form1 : Form
    {
        // variabile, constante
        private Socket client1, server1;
        string ip_ext, dt;
        int port_send_ext, port_listen_int;
        private Thread workerThread1;
        private const int BUFSIZE_FULL = 8192; // dimensiunea completa a buffer-ului pentru socket
        private const int BUFSIZE = BUFSIZE_FULL - 4;
        private const int BACKLOG = 5; // dimensiunea cozii de asteptare pentru socket
        private static bool isValid = true;      // validare cu schema a unui XML
        
        // XmlSchemaCollection cache = new XmlSchemaCollection(); //cache XSD schema
        // cache.Add("urn:MyNamespace", "C:\\MyFolder\\Product.xsd"); // add namespace XSD schema


        // metode complementare
        private string GetCurrentDT()
        {
            DateTime time = DateTime.Now;
            string format = "dd.MM.yyyy HH:mm:ss"; //27.12.2011 18:34:55
            return (time.ToString(format));
        }
        private string FindLocalIP()
        {
            string strHostName = "";
            strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[addr.Length - 1].ToString();
        }
        private void Debug(string str)
        {
            Action appendToTextBox = () =>
            {
                dt = GetCurrentDT();
                richTextBox3.AppendText(dt + " - " + str + ".\n");
                richTextBox3.ScrollToCaret();
            };

            richTextBox3.Invoke(appendToTextBox);
        }
        public void MyValidationEventHandler(object sender, ValidationEventArgs args)
        {
            isValid = false;
            Debug("SERVER: Validation event\n" + args.Message);
        }
        private bool Validation(string file)
        {
            XmlTextReader r = new XmlTextReader(file);
#pragma warning disable 618
            XmlValidatingReader v = new XmlValidatingReader(r);
#pragma warning restore 618
            //v.Schemas.Add(cache);
            if (radioButton1.Checked)
            {
                v.ValidationType = ValidationType.Schema;
            }
            else if (radioButton2.Checked)
            {
                v.ValidationType = ValidationType.DTD;
            }
            else //(radioButton3.Checked)
            {
#pragma warning disable 618
                v.ValidationType = ValidationType.XDR;
#pragma warning restore 618
            }
            v.ValidationEventHandler += new ValidationEventHandler(MyValidationEventHandler);
            while (v.Read())
            {
                // Can add code here to process the content
                // bool Success = true;
                // Console.WriteLine("Validation finished. Validation {0}", (Success == true ? "successful" : "failed"));
                // Path.GetExtension(label11.Text).Substring(1).ToUpper()
            }
            v.Close();
            if (isValid)
            {
                return true; //Document is valid
            }
            return false;//Document is invalid
        }
        private void Listener()
        {
            server1 = null;
            byte[] receivedBytes = new byte[BUFSIZE_FULL];
            port_listen_int = System.Convert.ToInt32(textBoxListenPort.Text);
            string receivedMessage;
            using (server1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                try
                {
                    server1.Bind(new IPEndPoint(IPAddress.Parse(textBoxListenIp.Text), port_listen_int));
                    server1.Listen(BACKLOG);
                    Debug("SERVER: socket <" + textBoxListenIp.Text + ":" + port_listen_int.ToString() + "> deschis");
                }
                catch (Exception ex)
                {
                    Debug("SERVER: probleme creare server socket <" + textBoxListenIp.Text + ":" + port_listen_int.ToString() + ">");
                    Debug(ex.ToString());
                }
                while (true)
                {
                    client1 = null;
                    int bytesRcvd = 0, totalBytesReceived = 0;
                    try
                    {
                        using (client1 = server1.Accept())
                        {
                            Debug("SERVER: client socket <" + client1.RemoteEndPoint + "> conectat");
                            while ((bytesRcvd = client1.Receive(receivedBytes, 0, receivedBytes.Length, SocketFlags.None)) > 0)
                            {
                                if (totalBytesReceived >= receivedBytes.Length)
                                {
                                    break;
                                }
                                totalBytesReceived += bytesRcvd;
                            }
                            
                            Encoding encodingType = null;
                            Action getEncodingType = () =>
                            {
                                encodingType = (Encoding)encodingComboBox.SelectedItem;
                            };
                            encodingComboBox.Invoke(getEncodingType);
                            if ((checkBoxSchemaValidation.Checked && (label11.Text != "")) && (!Validation(label11.Text)))
                            {
                                Debug("SERVER: eroare parsare XML via schema inclusa in antet");
                            }
                            else
                            {
                                receivedMessage = BufferDecoderBytes(receivedBytes, totalBytesReceived, encodingType, addLengthToMessageCheckBox.Checked, checkBoxSchemaValidation.Checked, label11.Text);
                                Action writeToTextBoxServer = () =>
                                {
                                    richTextBoxServer.Text = receivedMessage;
                                };

                                richTextBoxServer.Invoke(writeToTextBoxServer);
                            }
                        }
                        if (client1 != null)
                        {
                            client1.Close();
                        }
                        Debug("SERVER: client socket deconectat");
                    }
                    catch (Exception ex)
                    {
                        Debug(ex.ToString());
                    }
                    finally
                    {
                        if (client1 != null)
                        {
                            client1.Close();
                        }
                    }
                }
            }
        }

        private string BufferDecoderBytes(byte[] receivedBytes,int totalBytesReceived, Encoding encoding, bool shouldRemoveLength, bool isSchemaValidation, string text)
        {
            string receivedMessage;
            if (shouldRemoveLength)
            {
                totalBytesReceived -= 4;
                Array.Copy(receivedBytes, 4, receivedBytes, 0, totalBytesReceived);
            }
            receivedMessage = DecodeBytes(receivedBytes, totalBytesReceived, encoding);
            Debug("SERVER: receptionat " + (totalBytesReceived) + " bytes");
            return receivedMessage;
        }

        private string DecodeBytes(byte[] messageBytes, int totalBytesReceived, Encoding encoding)
        {
            return encoding.GetString(messageBytes, 0, (totalBytesReceived));
        }
        
        private void Send()
        {
            ip_ext = textBox1.Text;
            port_send_ext = System.Convert.ToInt32(textBox2.Text);
            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                try
                {
                    IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(ip_ext), port_send_ext);
                    socket.Connect(serverEndPoint);
                    Debug("CLIENT: conectat la server socket <" + ip_ext + ":" + port_send_ext.ToString() + ">");
                    var bufferCreator = new BufferCreator();
                    var bufferToSend = bufferCreator.GetBufferToSendFromString(
                        inputMessageTextBox.Text, 
                        (Encoding) encodingComboBox.SelectedItem, 
                        addLengthToMessageCheckBox.Checked);
                    socket.Send(bufferToSend);

                    Debug("CLIENT: date expediate de la client la server socket.");
                }
                catch (Exception ex)
                {
                    Debug("CLIENT: probleme conectare/trimitere de la client la server socket <" + ip_ext + ":" + port_send_ext.ToString() + ">");
                    Debug(ex.ToString());
                }
            }
        }

        // metode de baza
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxSchemaValidation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSchemaValidation.Checked)
            {
                button5.Enabled = true;
                button2.Enabled = true;
                inputMessageTextBox.ReadOnly = true;
                button7.Enabled = false;
                groupBox1.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
                button2.Enabled = false;
                button7.Enabled = true;
                inputMessageTextBox.ReadOnly = false;
                groupBox1.Enabled = false;
                richTextBox4.Clear();
                label3.Text = "";
                label11.Text = "";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            encodingComboBox.SelectedIndex = 0;
            textBox1.Text = FindLocalIP();
            textBoxListenIp.Text = FindLocalIP();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select XSD/DTD/XDR File";
            fDialog.Filter = "XSD Files|*.xsd|DTD Files|*.dtd|XDR Files|*.xdr";
            //fDialog.Filter = "XSD Files|*.xsd|DTD Files|*.dtd|XDR Files|*.xdr|All Files|*.*";
            fDialog.ShowHelp = false;
            fDialog.CheckFileExists = true;
            fDialog.CheckPathExists = true;
            fDialog.AddExtension = true;
            fDialog.InitialDirectory = @Application.StartupPath;
            //fDialog.InitialDirectory =@Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory).ToString();
            //fDialog.InitialDirectory = @"C:\";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                label3.Text = fDialog.FileName.ToString();
                try
                {
                    richTextBox4.Clear();
                    richTextBox4.Text = File.ReadAllText(fDialog.FileName.ToString());
                }
                catch (Exception ex)
                {
                    Debug("Probleme incarcare/deschidere fisier XSD/DTD");
                    Debug(ex.ToString());
                }
            }
        }
        private void buttonListen_Click(object sender, EventArgs e)
        {
            if (buttonListen.Text == "Listen ON")
            {
                buttonListen.Text = "Listen OFF";
                //button1.Enabled = true;
                workerThread1 = new Thread(Listener);
                workerThread1.Start();

            }
            else
            {
                buttonListen.Text = "Listen ON";
                //button1.Enabled = false;
                try
                {
                    if (server1 != null)
                    {
                        server1.Close();
                        ((IDisposable)server1).Dispose();
                        Debug("SERVER: socket <" + textBoxListenIp.Text + ":" + port_listen_int.ToString() + "> inchis");
                    }
                }
                catch (Exception ex)
                {
                    Debug(ex.ToString());
                }
                finally
                {
                    workerThread1.Abort();
                }
            }
        }
        private void SendButtonClick(object sender, EventArgs e)
        {
            Send();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select XML File";
            fDialog.Filter = "XML Files|*.xml";
            //fDialog.Filter = "XML Files|*.xml|All Files|*.*";
            fDialog.ShowHelp = false;
            fDialog.CheckFileExists = true;
            fDialog.CheckPathExists = true;
            fDialog.AddExtension = true;
            fDialog.InitialDirectory = @Application.StartupPath;
            //fDialog.InitialDirectory =@Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory).ToString();
            //fDialog.InitialDirectory = @"C:\";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                isValid = true;
                label11.Text = fDialog.FileName.ToString();
                try
                {
                    inputMessageTextBox.Clear();
                    inputMessageTextBox.Text = File.ReadAllText(fDialog.FileName.ToString());
                }
                catch (Exception ex)
                {
                    Debug("Probleme incarcare/deschidere fisier XML");
                    Debug(ex.ToString());
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            inputMessageTextBox.Clear();
            richTextBox5.Clear();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            richTextBoxServer.Clear();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (buttonListen.Text == "Listen OFF")
            {
                buttonListen_Click(sender, e);
            }
        }
    }
}
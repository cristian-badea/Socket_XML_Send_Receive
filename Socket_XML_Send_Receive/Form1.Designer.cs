﻿using System.Text;

namespace Socket_XML_Send_Receive
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.inputMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBoxServer = new System.Windows.Forms.RichTextBox();
            this.buttonListen = new System.Windows.Forms.Button();
            this.textBoxListenPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxListenIp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.encodingComboBox = new System.Windows.Forms.ComboBox();
            this.addLengthToMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.checkBoxSchemaValidation = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(103, 73);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Location = new System.Drawing.Point(280, 73);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "10000";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(456, 71);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(100, 28);
            this.sendButton.TabIndex = 11;
            this.sendButton.Text = "Send XML";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButtonClick);
            // 
            // inputMessageTextBox
            // 
            this.inputMessageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.inputMessageTextBox.Location = new System.Drawing.Point(99, 107);
            this.inputMessageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputMessageTextBox.Name = "inputMessageTextBox";
            this.inputMessageTextBox.Size = new System.Drawing.Size(456, 80);
            this.inputMessageTextBox.TabIndex = 13;
            this.inputMessageTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(584, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 81);
            this.label3.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(584, 289);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Load XSD/DTD/XDR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBoxServer
            // 
            this.richTextBoxServer.Location = new System.Drawing.Point(99, 325);
            this.richTextBoxServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxServer.Name = "richTextBoxServer";
            this.richTextBoxServer.Size = new System.Drawing.Size(456, 144);
            this.richTextBoxServer.TabIndex = 20;
            this.richTextBoxServer.Text = "";
            // 
            // buttonListen
            // 
            this.buttonListen.Location = new System.Drawing.Point(456, 289);
            this.buttonListen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(100, 28);
            this.buttonListen.TabIndex = 18;
            this.buttonListen.Text = "Listen ON";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // textBoxListenPort
            // 
            this.textBoxListenPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxListenPort.Location = new System.Drawing.Point(280, 290);
            this.textBoxListenPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxListenPort.Name = "textBoxListenPort";
            this.textBoxListenPort.Size = new System.Drawing.Size(63, 22);
            this.textBoxListenPort.TabIndex = 17;
            this.textBoxListenPort.Text = "10000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Port";
            // 
            // textBoxListenIp
            // 
            this.textBoxListenIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxListenIp.Location = new System.Drawing.Point(103, 290);
            this.textBoxListenIp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxListenIp.Name = "textBoxListenIp";
            this.textBoxListenIp.ReadOnly = true;
            this.textBoxListenIp.Size = new System.Drawing.Size(115, 22);
            this.textBoxListenIp.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "IP";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox3.Location = new System.Drawing.Point(99, 511);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(456, 114);
            this.richTextBox3.TabIndex = 22;
            this.richTextBox3.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(456, 478);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 23;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 390);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Server";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 560);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "DEBUG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Encoding";
            // 
            // encodingComboBox
            // 
            this.encodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encodingComboBox.FormattingEnabled = true;
            this.encodingComboBox.Items.AddRange(new object[] {
            Encoding.ASCII,
            Encoding.UTF7,
            Encoding.UTF8,
            Encoding.Unicode});
            this.encodingComboBox.Location = new System.Drawing.Point(99, 15);
            this.encodingComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.encodingComboBox.Name = "encodingComboBox";
            this.encodingComboBox.Size = new System.Drawing.Size(160, 24);
            this.encodingComboBox.TabIndex = 1;
            this.encodingComboBox.DisplayMember = "EncodingName";
            // 
            // addLengthToMessageCheckBox
            // 
            this.addLengthToMessageCheckBox.AutoSize = true;
            this.addLengthToMessageCheckBox.Location = new System.Drawing.Point(505, 17);
            this.addLengthToMessageCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addLengthToMessageCheckBox.Name = "addLengthToMessageCheckBox";
            this.addLengthToMessageCheckBox.Size = new System.Drawing.Size(81, 21);
            this.addLengthToMessageCheckBox.TabIndex = 2;
            this.addLengthToMessageCheckBox.Text = "Add length";
            this.addLengthToMessageCheckBox.UseVisualStyleBackColor = true;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.richTextBox4.Location = new System.Drawing.Point(584, 325);
            this.richTextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(367, 299);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "";
            // 
            // checkBoxSchemaValidation
            // 
            this.checkBoxSchemaValidation.AutoSize = true;
            this.checkBoxSchemaValidation.Location = new System.Drawing.Point(611, 17);
            this.checkBoxSchemaValidation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxSchemaValidation.Name = "checkBoxSchemaValidation";
            this.checkBoxSchemaValidation.Size = new System.Drawing.Size(145, 21);
            this.checkBoxSchemaValidation.TabIndex = 3;
            this.checkBoxSchemaValidation.Text = "Schema validation";
            this.checkBoxSchemaValidation.UseVisualStyleBackColor = true;
            this.checkBoxSchemaValidation.CheckedChanged += new System.EventHandler(this.checkBoxSchemaValidation_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(584, 75);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 28);
            this.button5.TabIndex = 25;
            this.button5.Text = "Load XML";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(584, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(368, 81);
            this.label11.TabIndex = 26;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(352, 290);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 27;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(352, 71);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 28;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(724, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(228, 48);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schema validation type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(159, 18);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "XDR";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 18);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "DTD";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 18);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "XSD";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(279, 17);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(200, 21);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "client receive / server echo";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.richTextBox5.Location = new System.Drawing.Point(99, 196);
            this.richTextBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(456, 80);
            this.richTextBox5.TabIndex = 31;
            this.richTextBox5.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(971, 661);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBoxSchemaValidation);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.addLengthToMessageCheckBox);
            this.Controls.Add(this.encodingComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBoxServer);
            this.Controls.Add(this.buttonListen);
            this.Controls.Add(this.textBoxListenPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxListenIp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputMessageTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socket XML (TX/RX)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox inputMessageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBoxServer;
        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.TextBox textBoxListenPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxListenIp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox encodingComboBox;
        private System.Windows.Forms.CheckBox addLengthToMessageCheckBox;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.CheckBox checkBoxSchemaValidation;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RichTextBox richTextBox5;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Socket_XML_Send_Receive
{
    public class BufferDecoder
    {
        public string DecodeBufferBytes(byte[] receivedBytes, int totalBytesReceived, Encoding encoding, bool shouldRemoveLength, out int totalBytesDecoded)
        {
            string receivedMessage;
            if (shouldRemoveLength)
            {
                totalBytesDecoded = totalBytesReceived - 4;
                Array.Copy(receivedBytes, 4, receivedBytes, 0, totalBytesDecoded);
            }
            else
            {
                totalBytesDecoded = totalBytesReceived;
            }

            receivedMessage = DecodeBytes(receivedBytes, totalBytesDecoded, encoding);

            return receivedMessage;
        }

        public string DecodeBytes(byte[] messageBytes, int totalBytesReceived, Encoding encoding)
        {
            return encoding.GetString(messageBytes, 0, (totalBytesReceived));
        }
    }
}

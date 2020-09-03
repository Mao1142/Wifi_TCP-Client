using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace TCP_Client
{
    public class Client
    {
        private TcpClient _client;
        private NetworkStream _stream;

        /// <summary>
        /// 初始化TCP通道
        /// </summary>
        /// <param name="timeout">逾時值，單位為毫秒</param>
        public Client(int timeout = 5000)
        {
            _client = new TcpClient();
            _client.ReceiveTimeout = timeout;
            _client.SendTimeout = timeout;
            int x = _client.ReceiveBufferSize;
        }

        /// <summary>
        /// 連接至server
        /// </summary>
        /// <param name="IP">server位置</param>
        /// <param name="port">連接埠號</param>
        public bool Connect(string IP ,int port)
        {
            try
            {
                // 建立 TcpClient連線
                _client = new TcpClient(IP, port);
            }
            catch (ArgumentNullException A)
            {
                throw new Exception($"Is not accepted as a valid argument {A.Message}");
            }
            catch (SocketException S)
            {
                throw new Exception($"Server is not connected {S.Message}");
            }
            return _client.Connected;
        }

        public bool IsConnected => _client.Connected;

        /// <summary>
        /// 中斷連接
        /// </summary>
        public bool Disconnect()
        {
            try
            {
                Send("0xFF");
                Receive(out string _);
            }
            catch (SocketException S)
            {
                throw new Exception($"Server is not connected {S.Message}");
            }
            // Close everything.
            _stream.Close();
            _client.Close();

            return _client.Connected;
        }

        /// <summary>
        /// 資料發送
        /// </summary>
        /// <param name="text">傳送字串</param>
        public void Send(string text)
        {
            //把傳輸的資料轉成unicode並用byte陣列儲存  
            Byte[] data = new ASCIIEncoding().GetBytes(text.ToCharArray());
            try
            {
                _stream = _client.GetStream(); // 取得client stream
                _stream.Write(data, 0, data.Length);//把資料傳到已連接的TcpServer
            }
            catch (SocketException S)
            {
                throw new Exception($"Server is not connected {S.Message}");
            }
            catch (Exception e)
            {
                throw new Exception($"Data send fail {e.Message}");
            }
        }

        /// <summary>
        /// 資料接收
        /// </summary>
        /// <param name="responseData">回傳字串</param>
        /// <param name="recSize">接收大小</param>
        /// <returns>回傳字串長度</returns>
        public int Receive(out string responseData, int recSize = 65535)
        {
            Byte[] data = new Byte[recSize];
            Int32 bytes = 0;

            responseData = String.Empty;

            try
            {
                Thread.Sleep(50);//延遲等待資料送完
                if (_stream.DataAvailable)//如果有收到Server端的資料  
                {
                    //收到回應的資料
                    bytes = _stream.Read(data, 0, data.Length);
                    responseData = new ASCIIEncoding().GetString(data, 0, bytes).Replace('\n','\0');
                }
            }
            catch (SocketException S)
            {
                throw new Exception($"Server is not connected {S.Message}");
            }
            catch (Exception e)
            {
                throw new Exception($"Data receive fail {e.Message}");
            }
            return bytes;
        }
    }
}

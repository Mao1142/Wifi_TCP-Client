using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_Client;


namespace TCP_Client_Demo
{
    public partial class Form1 : Form
    {
        private readonly string IP = "192.168.10.1";
        private readonly int port = 8888;
        private Client client;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new Client(1000);
            BtnStatus(false);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (client.Connect(IP, port))
                {
                    BtnStatus(true);

                    communication("0x01", out string Data);

                    MessageBox.Show($"Connected! Serial : {Data}");
                }
                else
                {
                    MessageBox.Show("Connect Fail");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!client.Disconnect())
                {
                    BtnStatus(false);
                    MessageBox.Show("Disconnect!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_ac1_Click(object sender, EventArgs e)
        {
            communication("0x01", out string Data, 16);
            txb_rec.Text = DateTime.Now.ToString("HH:mm:ss") + $"-{Data}";
        }

        private void btn_ac2_Click(object sender, EventArgs e)
        {
            communication("0x02", out string Data, 8192);
            txb_rec.Text = Data;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                client.Send(txb_send.Text);
                client.Receive(out string Data);
                txb_rec.Text = Data;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnStatus(bool status)
        {
            btn_disconnect.Enabled = status;
            btn_ac1.Enabled = status;
            btn_ac2.Enabled = status;
            btn_send.Enabled = status;
            btn_connect.Enabled = !status;
        }

        private void txb_rec_TextChanged(object sender, EventArgs e)
        {
            lab_size.Text = txb_rec.Text.Length.ToString();
        }

        private int communication(string send, out string returnData, int recSize = 65535)
        {
            int len = 0;
            returnData = string.Empty;
            try
            {
                client.Send(send);
                len = client.Receive(out string responseData, recSize);
                returnData = responseData;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return len;
        }
    }
}

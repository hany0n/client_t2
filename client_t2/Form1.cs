using System.Net.Sockets;
using System.Text;

namespace client_t2
{
    public partial class Form1 : Form
    {


        TcpClient client;
        NetworkStream stream;
        bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                try
                {
                    client = new TcpClient();
                    client.Connect("127.0.0.1", 7000);
                    stream = client.GetStream();
                    isConnected = true;

                    Thread receiveThread = new Thread(ReceiveMessages);
                    receiveThread.Start();

                    UpdateChat(">> Подключено к серверу");
                    btnConS.Text = "Отключиться";
                }
                catch (Exception ex)
                {
                    UpdateChat($"Ошибка: {ex.Message}");
                }
            }
            else
            {
                Disconnect();
                btnConS.Text = "Подключиться";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!isConnected || string.IsNullOrEmpty(txtMesgS.Text))
                return;

            try
            {
                byte[] data = Encoding.UTF8.GetBytes(txtMesgS.Text);
                stream.Write(data, 0, data.Length);
                UpdateChat($"Я: {txtMesgS.Text}");
                txtMesgS.Clear();
            }
            catch (Exception ex)
            {
                UpdateChat($"Ошибка отправки сообщения: {ex.Message}");
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[4096];
            try
            {
                while (isConnected)
                {
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    if (bytes == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytes);
                    UpdateChat(message);
                }
            }
            catch
            {
                UpdateChat(">> Соединение разорвано");
            }
            finally
            {
                Disconnect();
            }
        }

        private void Disconnect()
        {
            isConnected = false;
            client?.Close();
            stream?.Close();
        }

        private void UpdateChat(string message)
        {
            if (txtChatW.InvokeRequired)
            {
                Invoke(new Action<string>(UpdateChat), message);
            }
            else
            {
                txtChatW.AppendText(message + Environment.NewLine);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

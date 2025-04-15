using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lab3
{
    public partial class Form1 : Form
    {
        Dictionary<int, char> code = new Dictionary<int, char>();
        string values = " \r\n!\r\n\"\r\n#\r\n$\r\n%\r\n&\r\n'\r\n(\r\n)\r\n*\r\n+\r\n,\r\n-\r\n.\r\n/\r\n0\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n:\r\n;\r\n<\r\n=\r\n>\r\n?\r\n@\r\nA\r\nB\r\nC\r\nD\r\nE\r\nF\r\nG\r\nH\r\nI\r\nJ\r\nK\r\nL\r\nM\r\nN\r\nO\r\nP\r\nQ\r\nR\r\nS\r\nT\r\nU\r\nV\r\nW\r\nX\r\nY\r\nZ\r\n[\r\n\\\r\n]\r\n^\r\n_\r\n`\r\na\r\nb\r\nc\r\nd\r\ne\r\nf\r\ng\r\nh\r\ni\r\nj\r\nk\r\nl\r\nm\r\nn\r\no\r\np\r\nq\r\nr\r\ns\r\nt\r\nu\r\nv\r\nw\r\nx\r\ny\r\nz\r\n{\r\n|\r\n}\r\n~\r\n0\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n0\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n0\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n0\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n".Replace("\r\n", "");

        TcpClient client = new TcpClient();
        string username;
        string writePath;
        string host;
        Form2 Form2 { get; set; }
        StreamWriter netWriter;
        public Form1(Form2 f, string user, string path, string hostie)
        {
            InitializeComponent();
            f.Hide();
            Form2 = f;
            username = user;
            writePath = path;
            host = hostie;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 32; i < 256; i++)
            {
                if (i == 127 || i == 151 || i == 159 || i == 172) continue;
                code[i] = values[i - 32];
            }
            //host = "127.0.0.1";
            int port = 8888;
            StreamReader? Reader = null;
            StreamWriter? Writer = null;
            client.Connect(host, port); //����������� �������
            record($"����� ����������, {username}");
            Reader = new StreamReader(client.GetStream());
            Writer = new StreamWriter(client.GetStream());
            netWriter = Writer;
            if (Writer is null || Reader is null) return;
            // ��������� ����� ����� ��� ��������� ������
            ReceiveMessageAsync(Reader);
            netWriter.WriteLineAsync(username);
            netWriter.FlushAsync();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void record(string inputStr)
        {
            historyBox.Text = $"{inputStr} \n{historyBox.Text}";
        }
        private async Task ReceiveMessageAsync(StreamReader reader)
        {
            while (true)
            {
                try
                {
                    // ��������� ����� � ���� ������
                    string? message = await reader.ReadLineAsync();
                    // ���� ������ �����, ������ �� ������� �� �������
                    if (string.IsNullOrEmpty(message)) continue;
                    using (StreamWriter writer = new StreamWriter(writePath, true))
                    {
                        writer.WriteLine(message);
                    }
                    record(message);//����� ���������
                }
                catch
                {
                    break;
                }
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendMessage();
            }
        }
        private void sendMessage()
        {
            try
            {
                string input = inputBox.Text;
                inputBox.Text = string.Empty;
                string output = "";
                string outputSecond = "";
                foreach (char c in input)
                {
                    var myKey = code.FirstOrDefault(x => x.Value == c).Key;
                    output += myKey + " ";
                    outputSecond += Convert.ToString(myKey, 2) + " ";
                }
                string message = $"{input} {output} {outputSecond}";
                netWriter.WriteLineAsync(message);
                netWriter.FlushAsync();
                record("��: " + message);
            }
            catch
            {
                record("��������� �� ������� ���������");
            }
        }
    }
}

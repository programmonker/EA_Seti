using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lab4
{
    public partial class Form1 : Form
    {
        Dictionary<int, char> code = new Dictionary<int, char>();
        string values = " \r\n!\r\n\"\r\n#\r\n$\r\n%\r\n&\r\n'\r\n(\r\n)\r\n*\r\n+\r\n,\r\n-\r\n.\r\n/\r\n0\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n:\r\n;\r\n<\r\n=\r\n>\r\n?\r\n@\r\nA\r\nB\r\nC\r\nD\r\nE\r\nF\r\nG\r\nH\r\nI\r\nJ\r\nK\r\nL\r\nM\r\nN\r\nO\r\nP\r\nQ\r\nR\r\nS\r\nT\r\nU\r\nV\r\nW\r\nX\r\nY\r\nZ\r\n[\r\n\\\r\n]\r\n^\r\n_\r\n`\r\na\r\nb\r\nc\r\nd\r\ne\r\nf\r\ng\r\nh\r\ni\r\nj\r\nk\r\nl\r\nm\r\nn\r\no\r\np\r\nq\r\nr\r\ns\r\nt\r\nu\r\nv\r\nw\r\nx\r\ny\r\nz\r\n{\r\n|\r\n}\r\n~\r\n0\r\n€\r\n\r\n‚\r\nƒ\r\n„\r\n…\r\n†\r\n‡\r\nˆ\r\n‰\r\nŠ\r\n‹\r\nŒ\r\n\r\n\r\n\r\n€\r\n‘\r\n’\r\n“\r\n”\r\n•\r\n–\r\n—\r\n0\r\n™\r\nš\r\n›\r\nœ\r\n\r\n\r\nŸ\r\n0\r\n¡\r\n¢\r\n£\r\n¤\r\n¥\r\n¦\r\n§\r\n¨\r\n©\r\nª\r\n«\r\n¬\r\n0\r\n®\r\n¯\r\n°\r\n±\r\n²\r\n³\r\n´\r\nµ\r\n¶\r\n·\r\n¸\r\n¹\r\nº\r\n»\r\n¼\r\n½\r\n¾\r\n¿\r\nÀ\r\nÁ\r\nÂ\r\nÃ\r\nÄ\r\nÅ\r\nÆ\r\nÇ\r\nÈ\r\nÉ\r\nÊ\r\nË\r\nÌ\r\nÍ\r\nÎ\r\nÏ\r\nĞ\r\nÑ\r\nÒ\r\nÓ\r\nÔ\r\nÕ\r\nÖ\r\n×\r\nØ\r\nÙ\r\nÚ\r\nÛ\r\nÜ\r\nİ\r\nŞ\r\nß\r\nà\r\ná\r\nâ\r\nã\r\nä\r\nå\r\næ\r\nç\r\nè\r\né\r\nê\r\në\r\nì\r\ní\r\nî\r\nï\r\nğ\r\nñ\r\nò\r\nó\r\nô\r\nõ\r\nö\r\n÷\r\nø\r\nù\r\nú\r\nû\r\nü\r\nı\r\nş\r\nÿ\r\n".Replace("\r\n", "");

        int localPort;
        string username;
        Form2 Form2 { get; set; }
        StreamWriter writer;
        public Form1(Form2 f, int localport, string user, StreamWriter writerN)
        {
            InitializeComponent();
            f.Hide();
            Form2 = f;
            localPort = localport;
            username = user;
            writer = writerN;
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
            // çàïóñêàåì ïîëó÷åíèå ñîîáùåíèé
            ReceiveMessageAsync();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendMethod(inputBox.Text, false);
        }
        private void checkButton_Click(object sender, EventArgs e)
        {
            SendMethod("Ïğîâåğêà ïğîâåğêà", true);
        }
        private void SendMethod(string inputo, bool check)
        {
            try
            {
                using UdpClient senderU = new UdpClient();
                string input = inputo;
                string message = $"{username}: {input}";
                string output = "";
                foreach (char c in message)
                {
                    var myKey = code.FirstOrDefault(x => x.Value == c).Key;
                    output += myKey + " ";
                }
                string[] inputArray = output.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                byte[] data = new byte[inputArray.Length];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = Byte.Parse(inputArray[i]);
                }
                ;
                UDPMessage mes = new UDPMessage(data, check);
                string json = JsonSerializer.Serialize(mes);
                byte[] bytes = Encoding.UTF8.GetBytes(json);
                senderU.SendAsync(bytes, new IPEndPoint(IPAddress.Parse(ipTextBox.Text), Int32.Parse(portTextBox.Text)));
                record("Âû: " + input);
            }
            catch
            {
                record("Ñîîáùåíèå íå óäàëîñü îòïğàâèòü");
            }
        }

        private void record(string inputStr)
        {
            historyBox.Text = $"{inputStr} \n{historyBox.Text}";
        }
        private async Task ReceiveMessageAsync()
        {
            using UdpClient receiver = new UdpClient(localPort);
            while (true)
            {
                // ïîëó÷àåì äàííûå
                var result = await receiver.ReceiveAsync();
                string json = Encoding.UTF8.GetString(result.Buffer);
                UDPMessage restoredMessage = JsonSerializer.Deserialize<UDPMessage>(json);
                if (restoredMessage.Length != restoredMessage.Message.Length)
                {
                    MessageBox.Show("÷îòà íå õâàòàåò");
                    SendMethod("÷îòà íå õâàòàåò", false);
                    continue;
                }
                byte[] inputArray = restoredMessage.Message;
                string output = "";
                string outputSecond = "";
                foreach (byte c in inputArray)
                {
                    output += code[c];
                }
                int gol;
                for (int i = IndexOf(inputArray, 32) + 1; i < inputArray.Length; i++)
                {
                    gol = inputArray[i];
                    writer.Write($"{gol} ");
                    outputSecond += Convert.ToString(gol, 2) + " ";
                }
                //âûâîäèì ñîîáùåíèå
                writer.WriteLine(outputSecond);
                if (restoredMessage.IsCheck)
                {
                    SendMethod("Ïğîâåğêà ïğîéäåíà", false);
                }
                record(output);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            writer.Close();
            Application.Exit();
        }
        private int IndexOf(byte[] array, byte obj)
        {
            int index = 0;
            foreach (byte item in array)
            {
                if (item == obj)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
    }
}

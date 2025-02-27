using System;

namespace lab1
{
    public partial class Form1 : Form
    {
        Dictionary<int, char> code = new Dictionary<int, char>();
        string values = " \r\n!\r\n\"\r\n#\r\n$\r\n%\r\n&\r\n'\r\n(\r\n)\r\n*\r\n+\r\n,\r\n-\r\n.\r\n/\r\n0\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n:\r\n;\r\n<\r\n=\r\n>\r\n?\r\n@\r\nA\r\nB\r\nC\r\nD\r\nE\r\nF\r\nG\r\nH\r\nI\r\nJ\r\nK\r\nL\r\nM\r\nN\r\nO\r\nP\r\nQ\r\nR\r\nS\r\nT\r\nU\r\nV\r\nW\r\nX\r\nY\r\nZ\r\n[\r\n\\\r\n]\r\n^\r\n_\r\n`\r\na\r\nb\r\nc\r\nd\r\ne\r\nf\r\ng\r\nh\r\ni\r\nj\r\nk\r\nl\r\nm\r\nn\r\no\r\np\r\nq\r\nr\r\ns\r\nt\r\nu\r\nv\r\nw\r\nx\r\ny\r\nz\r\n{\r\n|\r\n}\r\n~\r\n0\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n0\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n0\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n0\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n�\r\n".Replace("\r\n", "");
        public Form1()
        {
            InitializeComponent();
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input = inputBox.Text;
                string output = "";
                string outputSecond = "";
                foreach (char c in input)
                {
                    var myKey = code.FirstOrDefault(x => x.Value == c).Key;
                    output += myKey + " ";
                    outputSecond += Convert.ToString(myKey, 2) + " ";
                }
                outputBox.Text = output + "\n" + outputSecond;
                record("��������� " + input + " ������������ � ", $"{output} [{outputSecond}]");
            }
            catch
            {
                record("��������� �� �������", " ������������");
            }

        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input = inputBox.Text;
                string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string output = "";
                foreach (string c in inputArray)
                {
                    output += code[Int32.Parse(c)];
                }
                outputBox.Text = output;
                record("��������� " + input + " ������������� � ", $"{output}");
            }
            catch
            {
                record("��������� �� �������", " �������������");
            }
        }
        private void record(string inputStr, string outputStr)
        {
            if (outputStr != " []" && outputStr != "")
            {
                historyBox.Text = $"{inputStr}{outputStr} \n{historyBox.Text}";
            }
            else
            {
                historyBox.Text = "� ���� ����� �����" + "\n" + historyBox.Text;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 32; i < 256; i++)
            {
                if (i == 127 || i == 151 || i == 159 || i == 172) continue;
                code[i] = values[i - 32];
            }
        }
    }
}

using static System.Windows.Forms.Design.AxImporter;

namespace CalculatorUsingCSharp
{
    public partial class Form1 : Form
    {
        double result = 0;
        double a;
        double b;
        char optino = '@';
        string display = "";
        public Form1()
        {
            InitializeComponent();
            createButtons();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void createButtons()
        {
            int n = 18;
            int x = 12;
            int y = 80;
            string[] btnTxt = { "1", "2", "C","+", "3", "4", "<", "-", "5", "6", ".", "*", "7", "8", "/", "=","9", "0" };
            for (int i = 0; i < n; i++)
            {
                if (i % 4 == 0)
                {
                    x = 12;
                    y = y + 70;
                }
                Button button1 = new Button()
                {
                    Location = new Point(x, y),
                    Name = btnTxt[i],
                    Size = new Size(60, 60),
                    Font = new Font("GenericSerif", 15),
                    TabIndex = 1,
                    Text = btnTxt[i],
                    UseVisualStyleBackColor = true,
                };
                button1.Click += BtnClick;
                this.Controls.Add(button1);
                x = x + 90;
            }
        }
        private void BtnClick(object? sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton != null)
            {
                char c = clickedButton.Text.ToCharArray()[0];
                if (c >= 48 && c <= 57)
                {
                    textBox1.Text += clickedButton.Text;
                }
                else if (c == 46 )
                {
                    int isAlready = textBox1.Text.IndexOf('.');
                    if(isAlready == -1)
                    {
                        textBox1.Text += clickedButton.Text;
                    }
                }
                else if (c == 'C')
                {
                    textBox1.Text = "";
                    label1.Text = "";
                    display = "";
                    result = 0;
                    a = 0;
                    b = 0;
                }
                else if (c == '<')
                {
                    int len = textBox1.Text.Length;
                    if (len > 0)
                    {
                        textBox1.Text = textBox1.Text.Remove(len - 1);
                    }
                }
                else if (c == '=')
                {
                    try
                    {
                        b = Convert.ToDouble(textBox1.Text);
                    }catch (Exception) { }
                    if (optino == '+')
                    {
                        result = a + b;
                    }
                    else if (optino == '-')
                    {
                        result = a - b;
                    }
                    else if (optino == '*')
                    {
                        result = a * b;
                    }
                    else if (optino == '/')
                    {
                        result = a / b;
                    }
                    textBox1.Text = Convert.ToString(result);
                    label1.Text = display + b + "=";
                }
                if(textBox1.Text.Length > 0)
                {
                    if (c == '+')
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = "";
                        optino = '+';
                        display = a+"+";
                        label1.Text += display;
                    }
                    else if (c == '-')
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = "";
                        optino = '-';
                        display = a + "-";
                        label1.Text += display;
                    }
                    else if (c == '*')
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = "";
                        optino = '*';
                        display = a + "*";
                        label1.Text += display;
                    }
                    else if (c == '/')
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = "";
                        optino = '/';
                        display = a + "/";
                        label1.Text += display;
                    }
                }
            }
        }

    }
}

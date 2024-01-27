using static System.Windows.Forms.Design.AxImporter;

namespace CalculatorUsingCSharp
{
    public partial class Form1 : Form
    {
        double result = 0;
        double a;
        double b;
        char optino = '@';
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
            char[] btnTxt = { 'C', '1', '2', '+', '3', '4', '5', '-', '6', '7', '8', '*', '9', '0', '.', '/', '<', '=' };
            for (int i = 0; i < n; i++)
            {
                if (i % 4 == 0)
                {
                    x = 12;
                    y = y + 70;
                }
                Button button1 = new Button();
                button1.Location = new Point(x, y);
                button1.Name = btnTxt[i].ToString();
                button1.Size = new Size(60, 60);
                button1.TabIndex = 1;
                button1.Text = btnTxt[i].ToString();
                button1.Click += btnClick;
                button1.UseVisualStyleBackColor = true;
                this.Controls.Add(button1);
                x = x + 90;

            }
        }
        private void btnClick(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                char c = clickedButton.Text.ToCharArray()[0];
                if (c >= 48 && c <= 57 || c == 46)
                {
                    textBox1.Text += clickedButton.Text;
                }
                else if (c == 'C')
                {
                    textBox1.Text = "";
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
                    
                    if (optino == '+')
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        result = a + b;
                        textBox1.Text = Convert.ToString(result);
                    }
                    else if (optino == '-')
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        result = a - b;
                        textBox1.Text = Convert.ToString(result);
                    }
                    else if (optino == '*')
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        result = a * b;
                        textBox1.Text = Convert.ToString(result);
                    }
                    else if (optino == '/')
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        result = a / b;
                        textBox1.Text = Convert.ToString(result);
                    }
                }
                if(textBox1.Text.Length > 0)
                {
                    if (c == '+')
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = "";
                        optino = '+';
                    }
                    else if (c == '-')
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = "";
                        optino = '-';
                    }
                    else if (c == '*')
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = "";
                        optino = '*';
                    }
                    else if (c == '/')
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = "";
                        optino = '/';
                    }
                }
            }
        }

    }
}

namespace PBL3
{
    public partial class Form1 : Form
    {
         public bool CheckPassWord(string s)
        {
            if (s.Length == 10)
            {
                foreach (char i in s)
                {
                    if (s[i] <= 90) return true;
                }
                return false;
            }
            else return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

    }
}
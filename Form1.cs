namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.Text = "Sum";
            textBox1.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox4.Text = "add something!";
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Items.Add("bleh");
            textBox4.Text = (menuStrip1.Items.ToString());
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                float f;
                try
                {
                    f = float.Parse(textBox2.Text);
                    f += float.Parse(textBox3.Text);
                }
                catch
                {
                    f = 0.0f;
                }
                textBox1.Text = f.ToString();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        


    }
}
namespace WinFormsApp1
{
    /*
     * c# to windows media control      -- done
     * osc to control the program       -- to do
     * control media from vrcaht avi    -- to do
    */
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            MediaPlayer.play();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            MediaPlayer.next();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            MediaPlayer.prev();
        }
    }
}
namespace Automobile
{
    public partial class Form1 : Form
    {
        Automobile auto = new Automobile();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void accensione_Click(object sender, EventArgs e)
        {
            auto.AccendiMotore();
            MessageBox.Show("Auto accesa");
        }
    }
}
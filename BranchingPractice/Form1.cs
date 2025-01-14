namespace BranchingPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayGreeting_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello, {txtName.Text}!");
        }
    }
}

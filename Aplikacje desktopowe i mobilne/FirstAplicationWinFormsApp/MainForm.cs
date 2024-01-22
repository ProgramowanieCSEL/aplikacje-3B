namespace FirstAplicationWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Witaj w tym programie",
                "Hello",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation

            );
        }
    }
}

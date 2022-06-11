namespace Aleph_0_Login_Menu
{
    public partial class Aleph0 : Form
    {
        public Aleph0()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Vortex100k" && txtpassword.Text == "Admin")
            {
                new Form2().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, please DM Vortex About this");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {

        }
    }
}
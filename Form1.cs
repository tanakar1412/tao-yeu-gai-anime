namespace asmc_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtAccount.Text == "toiyeugaianime" && txtPassword.Text =="tanaka2000" )
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Me thang ngu co the cung sai");
                txtAccount.Clear();
                txtPassword.Clear();
                txtAccount.Focus();
            }

          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

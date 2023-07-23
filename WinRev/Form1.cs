namespace WinRev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        homefrm homefrm = new homefrm();
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.txtuser.Text == "ali" && this.txtpassword.Text == "qwe")
            {

                homefrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("error", "ERROR",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are u sure u wanna Exit ? ",
                "WAARing",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                , MessageBoxDefaultButton.Button2)==DialogResult.No)
            {
                e.Cancel=true;
            }
            
        }
    }
}
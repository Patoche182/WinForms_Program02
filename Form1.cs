namespace WinForms_Program02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nom_user.Text == "" || prenom_user.Text == "" || email_user.Text == "")
            {
                MessageBox.Show("Formulaire incomplet !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
            MessageBox.Show("Merci " + nom_user.Text + " " + prenom_user.Text + " (" + email_user.Text + ")");
            }
        }
    }
}

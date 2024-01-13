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
            if (nom_user.Text == "" || prenom_user.Text == "" || email_user.Text == "")
            {
                MessageBox.Show("Formulaire incomplet !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Merci " + nom_user.Text + " " + prenom_user.Text + " (" + email_user.Text + "), votre inscription � bien �t� prise en compte par notre syst�me.");
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("Users.txt", true)) // pour cr�er le fichier si il n'existe pas et �crire dedans si il �xsite d�j�
                {
                    file.WriteLine("Nom : " + nom_user.Text + " Pr�nom : " + prenom_user.Text + " Email : " + email_user.Text);
                }
            }
        }
    }
}

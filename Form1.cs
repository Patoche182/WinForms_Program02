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
                MessageBox.Show("Merci " + nom_user.Text + " " + prenom_user.Text + " (" + email_user.Text + "), votre inscription à bien été prise en compte par notre système.");
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("Users.txt", true)) // pour créer le fichier si il n'existe pas et écrire dedans si il éxsite déjà
                {
                    file.WriteLine("Nom : " + nom_user.Text + " Prénom : " + prenom_user.Text + " Email : " + email_user.Text);
                }
            }
        }
    }
}

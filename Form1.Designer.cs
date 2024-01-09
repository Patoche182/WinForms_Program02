namespace WinForms_Program02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nom_user = new TextBox();
            email_user = new TextBox();
            prenom_user = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 39);
            label1.Name = "label1";
            label1.Size = new Size(161, 31);
            label1.TabIndex = 0;
            label1.Text = "JPO register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(18, 142);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 1;
            label2.Text = "Votre Nom :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(18, 177);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 1;
            label3.Text = "Votre Prénom :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(18, 214);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 1;
            label4.Text = "Votre email : ";
            // 
            // nom_user
            // 
            nom_user.Location = new Point(156, 140);
            nom_user.Name = "nom_user";
            nom_user.Size = new Size(249, 23);
            nom_user.TabIndex = 2;
            // 
            // email_user
            // 
            email_user.Location = new Point(156, 212);
            email_user.Name = "email_user";
            email_user.Size = new Size(249, 23);
            email_user.TabIndex = 2;
            // 
            // prenom_user
            // 
            prenom_user.Location = new Point(156, 175);
            prenom_user.Name = "prenom_user";
            prenom_user.Size = new Size(249, 23);
            prenom_user.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(156, 308);
            button1.Name = "button1";
            button1.Size = new Size(193, 75);
            button1.TabIndex = 3;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(156, 258);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(215, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "J'accepte les conditions d'utilisation";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 422);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(prenom_user);
            Controls.Add(email_user);
            Controls.Add(nom_user);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nom_user;
        private TextBox email_user;
        private TextBox prenom_user;
        private Button button1;
        private CheckBox checkBox1;
    }
}

namespace winboek
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
            tbGebruikersnaam = new TextBox();
            tbWachtwoord = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnInloggen = new Button();
            SuspendLayout();
            // 
            // tbGebruikersnaam
            // 
            tbGebruikersnaam.Location = new Point(151, 109);
            tbGebruikersnaam.Name = "tbGebruikersnaam";
            tbGebruikersnaam.Size = new Size(637, 27);
            tbGebruikersnaam.TabIndex = 0;
            // 
            // tbWachtwoord
            // 
            tbWachtwoord.Location = new Point(149, 212);
            tbWachtwoord.Name = "tbWachtwoord";
            tbWachtwoord.Size = new Size(639, 27);
            tbWachtwoord.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 2;
            label1.Text = "Gebruikersnaam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 212);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 3;
            label2.Text = "Wachtwoord";
            // 
            // btnInloggen
            // 
            btnInloggen.Location = new Point(12, 279);
            btnInloggen.Name = "btnInloggen";
            btnInloggen.Size = new Size(776, 69);
            btnInloggen.TabIndex = 4;
            btnInloggen.Text = "Inloggen";
            btnInloggen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInloggen);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbWachtwoord);
            Controls.Add(tbGebruikersnaam);
            Name = "Form1";
            Text = "Form1";
            Load += Formulier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Added the missing Formulier_Load method
        private void Formulier_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here
        }
        private TextBox tbGebruikersnaam;
        private TextBox tbWachtwoord;
        private Label label1;
        private Label label2;
        private Button btnInloggen;
    }
}

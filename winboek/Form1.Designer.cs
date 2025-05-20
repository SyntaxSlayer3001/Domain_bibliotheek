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
            lbBoeken = new ListBox();
            btnAddBoek = new Button();
            SuspendLayout();
            // 
            // lbBoeken
            // 
            lbBoeken.FormattingEnabled = true;
            lbBoeken.Location = new Point(12, 12);
            lbBoeken.Name = "lbBoeken";
            lbBoeken.Size = new Size(776, 304);
            lbBoeken.TabIndex = 0;
            // 
            // btnAddBoek
            // 
            btnAddBoek.Location = new Point(12, 335);
            btnAddBoek.Name = "btnAddBoek";
            btnAddBoek.Size = new Size(776, 49);
            btnAddBoek.TabIndex = 1;
            btnAddBoek.Text = "Voeg boek toe";
            btnAddBoek.UseVisualStyleBackColor = true;
            btnAddBoek.Click += btnAddBoek_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddBoek);
            Controls.Add(lbBoeken);
            Name = "Form1";
            Text = "Form1";
            Load += Formulier_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbBoeken;

        // Added the missing Formulier_Load method
        private void Formulier_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here
        }
        private Button btnAddBoek;
    }
}

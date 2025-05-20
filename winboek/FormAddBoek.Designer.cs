namespace winboek
{
    partial class FormAddBoek
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbTitel = new TextBox();
            tbGenreId = new TextBox();
            tbAuteur = new TextBox();
            tbUitgever = new TextBox();
            tbTaal = new TextBox();
            tbGraad = new TextBox();
            tbISBN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnToevoegen = new Button();
            SuspendLayout();
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(119, 59);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(272, 27);
            tbTitel.TabIndex = 0;
            // 
            // tbGenreId
            // 
            tbGenreId.Location = new Point(119, 108);
            tbGenreId.Name = "tbGenreId";
            tbGenreId.Size = new Size(272, 27);
            tbGenreId.TabIndex = 1;
            // 
            // tbAuteur
            // 
            tbAuteur.Location = new Point(119, 163);
            tbAuteur.Name = "tbAuteur";
            tbAuteur.Size = new Size(272, 27);
            tbAuteur.TabIndex = 2;
            // 
            // tbUitgever
            // 
            tbUitgever.Location = new Point(119, 215);
            tbUitgever.Name = "tbUitgever";
            tbUitgever.Size = new Size(272, 27);
            tbUitgever.TabIndex = 3;
            // 
            // tbTaal
            // 
            tbTaal.Location = new Point(119, 273);
            tbTaal.Name = "tbTaal";
            tbTaal.Size = new Size(272, 27);
            tbTaal.TabIndex = 4;
            // 
            // tbGraad
            // 
            tbGraad.Location = new Point(119, 325);
            tbGraad.Name = "tbGraad";
            tbGraad.Size = new Size(272, 27);
            tbGraad.TabIndex = 5;
            // 
            // tbISBN
            // 
            tbISBN.Location = new Point(119, 378);
            tbISBN.Name = "tbISBN";
            tbISBN.Size = new Size(272, 27);
            tbISBN.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 66);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 7;
            label1.Text = "Titel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 115);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 8;
            label2.Text = "GenreId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 170);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 9;
            label3.Text = "Auteur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 222);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 10;
            label4.Text = "Uitgever";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 280);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 11;
            label5.Text = "Taal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 332);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 12;
            label6.Text = "Graad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 385);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 13;
            label7.Text = "ISBN";
            // 
            // btnToevoegen
            // 
            btnToevoegen.Location = new Point(409, 59);
            btnToevoegen.Name = "btnToevoegen";
            btnToevoegen.Size = new Size(355, 346);
            btnToevoegen.TabIndex = 14;
            btnToevoegen.Text = "VoegToe";
            btnToevoegen.UseVisualStyleBackColor = true;
            btnToevoegen.Click += btnToevoegen_Click;
            // 
            // FormAddBoek
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnToevoegen);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbISBN);
            Controls.Add(tbGraad);
            Controls.Add(tbTaal);
            Controls.Add(tbUitgever);
            Controls.Add(tbAuteur);
            Controls.Add(tbGenreId);
            Controls.Add(tbTitel);
            Name = "FormAddBoek";
            Text = "FormAddBoek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTitel;
        private TextBox tbGenreId;
        private TextBox tbAuteur;
        private TextBox tbUitgever;
        private TextBox tbTaal;
        private TextBox tbGraad;
        private TextBox tbISBN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnToevoegen;
    }
}
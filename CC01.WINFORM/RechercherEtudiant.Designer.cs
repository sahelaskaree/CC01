namespace CC01.BO
{
    partial class RechercherEtudiant
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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(286, 55);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(492, 27);
            this.textBox7.TabIndex = 28;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(192, 55);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 27;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 443);
            this.dataGridView1.TabIndex = 26;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(498, 563);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 25;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(298, 563);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 24;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // RechercherEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(906, 645);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Name = "RechercherEtudiant";
            this.Text = "RechercherEtudiant";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
    }
}
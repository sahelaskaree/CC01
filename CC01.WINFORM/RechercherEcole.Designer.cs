namespace CC01.BO
{
    partial class RechercherEcole
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(215, -40);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(492, 27);
            this.textBox7.TabIndex = 33;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(121, -40);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 32;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 443);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(416, 547);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(117, 42);
            this.btnSupprimer.TabIndex = 30;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(230, 547);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(115, 42);
            this.btnModifier.TabIndex = 29;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(230, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 27);
            this.textBox1.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RechercherEcole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Name = "RechercherEcole";
            this.Text = "RechercherEcole";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
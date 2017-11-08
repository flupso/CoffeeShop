namespace CoffeeShop
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Label_Categorie = new System.Windows.Forms.Label();
            this.button_volgende = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welkom";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Accessoires",
            "Drinken",
            "Eten",
            "Hasj",
            "Wiet"});
            this.comboBox1.Location = new System.Drawing.Point(15, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(641, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Label_Categorie
            // 
            this.Label_Categorie.AutoSize = true;
            this.Label_Categorie.Location = new System.Drawing.Point(12, 54);
            this.Label_Categorie.Name = "Label_Categorie";
            this.Label_Categorie.Size = new System.Drawing.Size(100, 17);
            this.Label_Categorie.TabIndex = 2;
            this.Label_Categorie.Text = "Kies Categorie";
            // 
            // button_volgende
            // 
            this.button_volgende.Location = new System.Drawing.Point(217, 232);
            this.button_volgende.Name = "button_volgende";
            this.button_volgende.Size = new System.Drawing.Size(240, 118);
            this.button_volgende.TabIndex = 3;
            this.button_volgende.Text = "Volgende";
            this.button_volgende.UseVisualStyleBackColor = true;
            this.button_volgende.Click += new System.EventHandler(this.button_volgende_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 500);
            this.Controls.Add(this.button_volgende);
            this.Controls.Add(this.Label_Categorie);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Label_Categorie;
        private System.Windows.Forms.Button button_volgende;
    }
}


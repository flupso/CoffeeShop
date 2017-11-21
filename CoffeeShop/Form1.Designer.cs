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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Categorie = new System.Windows.Forms.Label();
            this.button_Drinken = new System.Windows.Forms.Button();
            this.button_Eten = new System.Windows.Forms.Button();
            this.button_Hasj = new System.Windows.Forms.Button();
            this.button_Wiet = new System.Windows.Forms.Button();
            this.button_Accessoires = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welkom";
            // 
            // Label_Categorie
            // 
            this.Label_Categorie.AutoSize = true;
            this.Label_Categorie.Location = new System.Drawing.Point(3, 222);
            this.Label_Categorie.Name = "Label_Categorie";
            this.Label_Categorie.Size = new System.Drawing.Size(121, 17);
            this.Label_Categorie.TabIndex = 2;
            this.Label_Categorie.Text = "Kies uw Categorie";
            // 
            // button_Drinken
            // 
            this.button_Drinken.Location = new System.Drawing.Point(140, 301);
            this.button_Drinken.Name = "button_Drinken";
            this.button_Drinken.Size = new System.Drawing.Size(130, 96);
            this.button_Drinken.TabIndex = 4;
            this.button_Drinken.Text = "Drinken";
            this.button_Drinken.UseVisualStyleBackColor = true;
            this.button_Drinken.Click += new System.EventHandler(this.button_Drinken_Click);
            // 
            // button_Eten
            // 
            this.button_Eten.Location = new System.Drawing.Point(276, 301);
            this.button_Eten.Name = "button_Eten";
            this.button_Eten.Size = new System.Drawing.Size(130, 96);
            this.button_Eten.TabIndex = 5;
            this.button_Eten.Text = "Eten";
            this.button_Eten.UseVisualStyleBackColor = true;
            this.button_Eten.Click += new System.EventHandler(this.button_Eten_Click);
            // 
            // button_Hasj
            // 
            this.button_Hasj.Location = new System.Drawing.Point(412, 301);
            this.button_Hasj.Name = "button_Hasj";
            this.button_Hasj.Size = new System.Drawing.Size(130, 96);
            this.button_Hasj.TabIndex = 6;
            this.button_Hasj.Text = "Hasj";
            this.button_Hasj.UseVisualStyleBackColor = true;
            this.button_Hasj.Click += new System.EventHandler(this.button_Hasj_Click);
            // 
            // button_Wiet
            // 
            this.button_Wiet.Location = new System.Drawing.Point(548, 301);
            this.button_Wiet.Name = "button_Wiet";
            this.button_Wiet.Size = new System.Drawing.Size(130, 96);
            this.button_Wiet.TabIndex = 7;
            this.button_Wiet.Text = "Wiet";
            this.button_Wiet.UseVisualStyleBackColor = true;
            this.button_Wiet.Click += new System.EventHandler(this.button_Wiet_Click);
            // 
            // button_Accessoires
            // 
            this.button_Accessoires.Location = new System.Drawing.Point(6, 301);
            this.button_Accessoires.Name = "button_Accessoires";
            this.button_Accessoires.Size = new System.Drawing.Size(130, 96);
            this.button_Accessoires.TabIndex = 8;
            this.button_Accessoires.Text = "Accessoires";
            this.button_Accessoires.UseVisualStyleBackColor = true;
            this.button_Accessoires.Click += new System.EventHandler(this.button_Accessoires_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeeShop.Properties.Resources.gizmodo_high_tech_620x349;
            this.pictureBox1.Location = new System.Drawing.Point(140, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Accessoires);
            this.Controls.Add(this.button_Wiet);
            this.Controls.Add(this.button_Hasj);
            this.Controls.Add(this.button_Eten);
            this.Controls.Add(this.button_Drinken);
            this.Controls.Add(this.Label_Categorie);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Categorie;
        private System.Windows.Forms.Button button_Drinken;
        private System.Windows.Forms.Button button_Eten;
        private System.Windows.Forms.Button button_Hasj;
        private System.Windows.Forms.Button button_Wiet;
        private System.Windows.Forms.Button button_Accessoires;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


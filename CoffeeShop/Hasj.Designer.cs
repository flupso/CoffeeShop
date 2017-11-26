namespace CoffeeShop
{
    partial class Hasj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hasj));
            this.label_SoortenHasj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_SoortenHasj
            // 
            this.label_SoortenHasj.AutoSize = true;
            this.label_SoortenHasj.Location = new System.Drawing.Point(13, 14);
            this.label_SoortenHasj.Name = "label_SoortenHasj";
            this.label_SoortenHasj.Size = new System.Drawing.Size(58, 17);
            this.label_SoortenHasj.TabIndex = 1;
            this.label_SoortenHasj.Text = "Soorten";
            this.label_SoortenHasj.Click += new System.EventHandler(this.label_SoortenHasj_Click);
            // 
            // Hasj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 513);
            this.Controls.Add(this.label_SoortenHasj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Hasj";
            this.Text = "Hasj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_SoortenHasj;
    }
}
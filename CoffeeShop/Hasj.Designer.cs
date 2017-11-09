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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_SoortenHasj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 27);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(91, 69);
            this.listBox1.TabIndex = 0;
            // 
            // label_SoortenHasj
            // 
            this.label_SoortenHasj.AutoSize = true;
            this.label_SoortenHasj.Location = new System.Drawing.Point(10, 11);
            this.label_SoortenHasj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SoortenHasj.Name = "label_SoortenHasj";
            this.label_SoortenHasj.Size = new System.Drawing.Size(44, 13);
            this.label_SoortenHasj.TabIndex = 1;
            this.label_SoortenHasj.Text = "Soorten";
            this.label_SoortenHasj.Click += new System.EventHandler(this.label_SoortenHasj_Click);
            // 
            // Hasj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 417);
            this.Controls.Add(this.label_SoortenHasj);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Hasj";
            this.Text = "Hasj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_SoortenHasj;
    }
}
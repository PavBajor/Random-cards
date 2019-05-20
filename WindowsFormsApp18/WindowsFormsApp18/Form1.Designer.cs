namespace WindowsFormsApp18
{
    partial class CardsGame
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
            this.randomCards = new System.Windows.Forms.Button();
            this.sortCards = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // randomCards
            // 
            this.randomCards.Location = new System.Drawing.Point(48, 48);
            this.randomCards.Name = "randomCards";
            this.randomCards.Size = new System.Drawing.Size(154, 23);
            this.randomCards.TabIndex = 0;
            this.randomCards.Text = "Choose Random Cards";
            this.randomCards.UseVisualStyleBackColor = true;
            this.randomCards.Click += new System.EventHandler(this.randomCards_Click);
            // 
            // sortCards
            // 
            this.sortCards.Location = new System.Drawing.Point(48, 78);
            this.sortCards.Name = "sortCards";
            this.sortCards.Size = new System.Drawing.Size(154, 23);
            this.sortCards.TabIndex = 1;
            this.sortCards.Text = "Sort Cards";
            this.sortCards.UseVisualStyleBackColor = true;
            this.sortCards.Click += new System.EventHandler(this.sortCards_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 193);
            this.textBox1.TabIndex = 2;
            // 
            // CardsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 321);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sortCards);
            this.Controls.Add(this.randomCards);
            this.Name = "CardsGame";
            this.Text = "CardsGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomCards;
        private System.Windows.Forms.Button sortCards;
        private System.Windows.Forms.TextBox textBox1;
    }
}


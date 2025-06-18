namespace yugioAIapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxCards;
        private System.Windows.Forms.PictureBox pictureBoxCard;

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
            this.listBoxCards = new System.Windows.Forms.ListBox();
            this.pictureBoxCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCards
            // 
            this.listBoxCards.FormattingEnabled = true;
            this.listBoxCards.ItemHeight = 15;
            this.listBoxCards.Location = new System.Drawing.Point(12, 12);
            this.listBoxCards.Name = "listBoxCards";
            this.listBoxCards.Size = new System.Drawing.Size(260, 424);
            this.listBoxCards.TabIndex = 0;
            this.listBoxCards.SelectedIndexChanged += new System.EventHandler(this.listBoxCards_SelectedIndexChanged);
            // 
            // pictureBoxCard
            // 
            this.pictureBoxCard.Location = new System.Drawing.Point(278, 12);
            this.pictureBoxCard.Name = "pictureBoxCard";
            this.pictureBoxCard.Size = new System.Drawing.Size(510, 424);
            this.pictureBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCard.TabIndex = 1;
            this.pictureBoxCard.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxCard);
            this.Controls.Add(this.listBoxCards);
            this.Name = "Form1";
            this.Text = "Yugioh Cards";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

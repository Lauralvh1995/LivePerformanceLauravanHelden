namespace LivePerformanceLauravanHelden
{
    partial class EditResultForm
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
            this.btSend = new System.Windows.Forms.Button();
            this.nudVotes = new System.Windows.Forms.NumericUpDown();
            this.tbPartyName = new System.Windows.Forms.TextBox();
            this.lbAmVotes = new System.Windows.Forms.Label();
            this.lbPartyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudVotes)).BeginInit();
            this.SuspendLayout();
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(161, 57);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 20;
            this.btSend.Text = "Verzend";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // nudVotes
            // 
            this.nudVotes.Location = new System.Drawing.Point(133, 29);
            this.nudVotes.Maximum = new decimal(new int[] {
            -451317370,
            61627445,
            0,
            0});
            this.nudVotes.Name = "nudVotes";
            this.nudVotes.Size = new System.Drawing.Size(272, 22);
            this.nudVotes.TabIndex = 19;
            // 
            // tbPartyName
            // 
            this.tbPartyName.Location = new System.Drawing.Point(133, 6);
            this.tbPartyName.Name = "tbPartyName";
            this.tbPartyName.Size = new System.Drawing.Size(272, 22);
            this.tbPartyName.TabIndex = 17;
            // 
            // lbAmVotes
            // 
            this.lbAmVotes.AutoSize = true;
            this.lbAmVotes.Location = new System.Drawing.Point(12, 31);
            this.lbAmVotes.Name = "lbAmVotes";
            this.lbAmVotes.Size = new System.Drawing.Size(115, 17);
            this.lbAmVotes.TabIndex = 16;
            this.lbAmVotes.Text = "Aantal Stemmen:";
            // 
            // lbPartyName
            // 
            this.lbPartyName.AutoSize = true;
            this.lbPartyName.Location = new System.Drawing.Point(42, 9);
            this.lbPartyName.Name = "lbPartyName";
            this.lbPartyName.Size = new System.Drawing.Size(85, 17);
            this.lbPartyName.TabIndex = 14;
            this.lbPartyName.Text = "Naam Partij:";
            // 
            // EditResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 86);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.nudVotes);
            this.Controls.Add(this.tbPartyName);
            this.Controls.Add(this.lbAmVotes);
            this.Controls.Add(this.lbPartyName);
            this.Name = "EditResultForm";
            this.Text = "Pas Stemmen Aan";
            ((System.ComponentModel.ISupportInitialize)(this.nudVotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.NumericUpDown nudVotes;
        private System.Windows.Forms.TextBox tbPartyName;
        private System.Windows.Forms.Label lbAmVotes;
        private System.Windows.Forms.Label lbPartyName;
    }
}
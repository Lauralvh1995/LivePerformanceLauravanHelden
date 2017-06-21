namespace LivePerformanceLauravanHelden
{
    partial class EditPartyForm
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
            this.nudAmMembers = new System.Windows.Forms.NumericUpDown();
            this.tbPartyLeaderName = new System.Windows.Forms.TextBox();
            this.tbPartyName = new System.Windows.Forms.TextBox();
            this.lbAmMembers = new System.Windows.Forms.Label();
            this.lbPartyLeaderName = new System.Windows.Forms.Label();
            this.lbPartyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(171, 119);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 13;
            this.btSend.Text = "Verzend";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // nudAmMembers
            // 
            this.nudAmMembers.Location = new System.Drawing.Point(140, 71);
            this.nudAmMembers.Maximum = new decimal(new int[] {
            -451317370,
            61627445,
            0,
            0});
            this.nudAmMembers.Name = "nudAmMembers";
            this.nudAmMembers.Size = new System.Drawing.Size(120, 22);
            this.nudAmMembers.TabIndex = 12;
            // 
            // tbPartyLeaderName
            // 
            this.tbPartyLeaderName.Location = new System.Drawing.Point(139, 40);
            this.tbPartyLeaderName.Name = "tbPartyLeaderName";
            this.tbPartyLeaderName.Size = new System.Drawing.Size(272, 22);
            this.tbPartyLeaderName.TabIndex = 11;
            // 
            // tbPartyName
            // 
            this.tbPartyName.Location = new System.Drawing.Point(139, 12);
            this.tbPartyName.Name = "tbPartyName";
            this.tbPartyName.Size = new System.Drawing.Size(272, 22);
            this.tbPartyName.TabIndex = 10;
            // 
            // lbAmMembers
            // 
            this.lbAmMembers.AutoSize = true;
            this.lbAmMembers.Location = new System.Drawing.Point(37, 71);
            this.lbAmMembers.Name = "lbAmMembers";
            this.lbAmMembers.Size = new System.Drawing.Size(96, 17);
            this.lbAmMembers.TabIndex = 9;
            this.lbAmMembers.Text = "Aantal Leden:";
            // 
            // lbPartyLeaderName
            // 
            this.lbPartyLeaderName.AutoSize = true;
            this.lbPartyLeaderName.Location = new System.Drawing.Point(11, 43);
            this.lbPartyLeaderName.Name = "lbPartyLeaderName";
            this.lbPartyLeaderName.Size = new System.Drawing.Size(122, 17);
            this.lbPartyLeaderName.TabIndex = 8;
            this.lbPartyLeaderName.Text = "Naam Lijsttrekker:";
            // 
            // lbPartyName
            // 
            this.lbPartyName.AutoSize = true;
            this.lbPartyName.Location = new System.Drawing.Point(48, 15);
            this.lbPartyName.Name = "lbPartyName";
            this.lbPartyName.Size = new System.Drawing.Size(85, 17);
            this.lbPartyName.TabIndex = 7;
            this.lbPartyName.Text = "Naam Partij:";
            // 
            // EditPartyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 150);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.nudAmMembers);
            this.Controls.Add(this.tbPartyLeaderName);
            this.Controls.Add(this.tbPartyName);
            this.Controls.Add(this.lbAmMembers);
            this.Controls.Add(this.lbPartyLeaderName);
            this.Controls.Add(this.lbPartyName);
            this.Name = "EditPartyForm";
            this.Text = "Partij Bewerken";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.NumericUpDown nudAmMembers;
        private System.Windows.Forms.TextBox tbPartyLeaderName;
        private System.Windows.Forms.TextBox tbPartyName;
        private System.Windows.Forms.Label lbAmMembers;
        private System.Windows.Forms.Label lbPartyLeaderName;
        private System.Windows.Forms.Label lbPartyName;
    }
}
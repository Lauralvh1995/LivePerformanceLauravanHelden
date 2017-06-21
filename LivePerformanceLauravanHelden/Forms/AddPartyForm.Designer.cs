namespace LivePerformanceLauravanHelden
{
    partial class AddPartyForm
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
            this.lbPartyName = new System.Windows.Forms.Label();
            this.lbPartyLeaderName = new System.Windows.Forms.Label();
            this.lbAmMembers = new System.Windows.Forms.Label();
            this.tbPartyName = new System.Windows.Forms.TextBox();
            this.tbPartyLeaderName = new System.Windows.Forms.TextBox();
            this.nudAmMembers = new System.Windows.Forms.NumericUpDown();
            this.btSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPartyName
            // 
            this.lbPartyName.AutoSize = true;
            this.lbPartyName.Location = new System.Drawing.Point(50, 25);
            this.lbPartyName.Name = "lbPartyName";
            this.lbPartyName.Size = new System.Drawing.Size(85, 17);
            this.lbPartyName.TabIndex = 0;
            this.lbPartyName.Text = "Naam Partij:";
            // 
            // lbPartyLeaderName
            // 
            this.lbPartyLeaderName.AutoSize = true;
            this.lbPartyLeaderName.Location = new System.Drawing.Point(13, 53);
            this.lbPartyLeaderName.Name = "lbPartyLeaderName";
            this.lbPartyLeaderName.Size = new System.Drawing.Size(122, 17);
            this.lbPartyLeaderName.TabIndex = 1;
            this.lbPartyLeaderName.Text = "Naam Lijsttrekker:";
            // 
            // lbAmMembers
            // 
            this.lbAmMembers.AutoSize = true;
            this.lbAmMembers.Location = new System.Drawing.Point(39, 81);
            this.lbAmMembers.Name = "lbAmMembers";
            this.lbAmMembers.Size = new System.Drawing.Size(96, 17);
            this.lbAmMembers.TabIndex = 2;
            this.lbAmMembers.Text = "Aantal Leden:";
            // 
            // tbPartyName
            // 
            this.tbPartyName.Location = new System.Drawing.Point(141, 22);
            this.tbPartyName.Name = "tbPartyName";
            this.tbPartyName.Size = new System.Drawing.Size(272, 22);
            this.tbPartyName.TabIndex = 3;
            // 
            // tbPartyLeaderName
            // 
            this.tbPartyLeaderName.Location = new System.Drawing.Point(141, 50);
            this.tbPartyLeaderName.Name = "tbPartyLeaderName";
            this.tbPartyLeaderName.Size = new System.Drawing.Size(272, 22);
            this.tbPartyLeaderName.TabIndex = 4;
            // 
            // nudAmMembers
            // 
            this.nudAmMembers.Location = new System.Drawing.Point(142, 81);
            this.nudAmMembers.Maximum = new decimal(new int[] {
            -451317370,
            61627445,
            0,
            0});
            this.nudAmMembers.Name = "nudAmMembers";
            this.nudAmMembers.Size = new System.Drawing.Size(120, 22);
            this.nudAmMembers.TabIndex = 5;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(173, 129);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 6;
            this.btSend.Text = "Verzend";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // AddPartyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 164);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.nudAmMembers);
            this.Controls.Add(this.tbPartyLeaderName);
            this.Controls.Add(this.tbPartyName);
            this.Controls.Add(this.lbAmMembers);
            this.Controls.Add(this.lbPartyLeaderName);
            this.Controls.Add(this.lbPartyName);
            this.Name = "AddPartyForm";
            this.Text = "Partij Toevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPartyName;
        private System.Windows.Forms.Label lbPartyLeaderName;
        private System.Windows.Forms.Label lbAmMembers;
        private System.Windows.Forms.TextBox tbPartyName;
        private System.Windows.Forms.TextBox tbPartyLeaderName;
        private System.Windows.Forms.NumericUpDown nudAmMembers;
        private System.Windows.Forms.Button btSend;
    }
}
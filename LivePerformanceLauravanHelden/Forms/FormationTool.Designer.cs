namespace LivePerformanceLauravanHelden
{
    partial class FormationTool
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
            this.btAddParty = new System.Windows.Forms.Button();
            this.gbParties = new System.Windows.Forms.GroupBox();
            this.lbVotes = new System.Windows.Forms.Label();
            this.lbIsMajority = new System.Windows.Forms.Label();
            this.lbMajority = new System.Windows.Forms.Label();
            this.lbPartySeats = new System.Windows.Forms.Label();
            this.lbPartyLeader = new System.Windows.Forms.Label();
            this.lbParty = new System.Windows.Forms.Label();
            this.btCreateFormation = new System.Windows.Forms.Button();
            this.lbAmSeats = new System.Windows.Forms.Label();
            this.lbSeats = new System.Windows.Forms.Label();
            this.cLBParties = new System.Windows.Forms.CheckedListBox();
            this.btEditParty = new System.Windows.Forms.Button();
            this.btResults = new System.Windows.Forms.Button();
            this.btCalculateSeats = new System.Windows.Forms.Button();
            this.gbParties.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAddParty
            // 
            this.btAddParty.Location = new System.Drawing.Point(575, 154);
            this.btAddParty.Name = "btAddParty";
            this.btAddParty.Size = new System.Drawing.Size(126, 57);
            this.btAddParty.TabIndex = 0;
            this.btAddParty.Text = "Partij Toevoegen";
            this.btAddParty.UseVisualStyleBackColor = true;
            this.btAddParty.Click += new System.EventHandler(this.btAddParty_Click);
            // 
            // gbParties
            // 
            this.gbParties.Controls.Add(this.lbVotes);
            this.gbParties.Controls.Add(this.lbIsMajority);
            this.gbParties.Controls.Add(this.lbMajority);
            this.gbParties.Controls.Add(this.lbPartySeats);
            this.gbParties.Controls.Add(this.lbPartyLeader);
            this.gbParties.Controls.Add(this.lbParty);
            this.gbParties.Controls.Add(this.btCreateFormation);
            this.gbParties.Controls.Add(this.lbAmSeats);
            this.gbParties.Controls.Add(this.lbSeats);
            this.gbParties.Controls.Add(this.cLBParties);
            this.gbParties.Location = new System.Drawing.Point(13, 13);
            this.gbParties.Name = "gbParties";
            this.gbParties.Size = new System.Drawing.Size(556, 407);
            this.gbParties.TabIndex = 1;
            this.gbParties.TabStop = false;
            this.gbParties.Text = "Partijen";
            // 
            // lbVotes
            // 
            this.lbVotes.AutoSize = true;
            this.lbVotes.Location = new System.Drawing.Point(161, 36);
            this.lbVotes.Name = "lbVotes";
            this.lbVotes.Size = new System.Drawing.Size(67, 17);
            this.lbVotes.TabIndex = 9;
            this.lbVotes.Text = "Stemmen";
            // 
            // lbIsMajority
            // 
            this.lbIsMajority.AutoSize = true;
            this.lbIsMajority.Location = new System.Drawing.Point(228, 351);
            this.lbIsMajority.Name = "lbIsMajority";
            this.lbIsMajority.Size = new System.Drawing.Size(32, 17);
            this.lbIsMajority.TabIndex = 8;
            this.lbIsMajority.Text = "nee";
            // 
            // lbMajority
            // 
            this.lbMajority.AutoSize = true;
            this.lbMajority.Location = new System.Drawing.Point(130, 351);
            this.lbMajority.Name = "lbMajority";
            this.lbMajority.Size = new System.Drawing.Size(92, 17);
            this.lbMajority.TabIndex = 7;
            this.lbMajority.Text = "Meerderheid:";
            // 
            // lbPartySeats
            // 
            this.lbPartySeats.AutoSize = true;
            this.lbPartySeats.Location = new System.Drawing.Point(228, 36);
            this.lbPartySeats.Name = "lbPartySeats";
            this.lbPartySeats.Size = new System.Drawing.Size(47, 17);
            this.lbPartySeats.TabIndex = 6;
            this.lbPartySeats.Text = "Zetels";
            // 
            // lbPartyLeader
            // 
            this.lbPartyLeader.AutoSize = true;
            this.lbPartyLeader.Location = new System.Drawing.Point(78, 36);
            this.lbPartyLeader.Name = "lbPartyLeader";
            this.lbPartyLeader.Size = new System.Drawing.Size(77, 17);
            this.lbPartyLeader.TabIndex = 5;
            this.lbPartyLeader.Text = "Lijsttrekker";
            // 
            // lbParty
            // 
            this.lbParty.AutoSize = true;
            this.lbParty.Location = new System.Drawing.Point(32, 36);
            this.lbParty.Name = "lbParty";
            this.lbParty.Size = new System.Drawing.Size(40, 17);
            this.lbParty.TabIndex = 4;
            this.lbParty.Text = "Partij";
            // 
            // btCreateFormation
            // 
            this.btCreateFormation.Location = new System.Drawing.Point(396, 355);
            this.btCreateFormation.Name = "btCreateFormation";
            this.btCreateFormation.Size = new System.Drawing.Size(137, 46);
            this.btCreateFormation.TabIndex = 3;
            this.btCreateFormation.Text = "Creëer Formatie";
            this.btCreateFormation.UseVisualStyleBackColor = true;
            this.btCreateFormation.Click += new System.EventHandler(this.btCreateFormation_Click);
            // 
            // lbAmSeats
            // 
            this.lbAmSeats.AutoSize = true;
            this.lbAmSeats.Location = new System.Drawing.Point(108, 351);
            this.lbAmSeats.Name = "lbAmSeats";
            this.lbAmSeats.Size = new System.Drawing.Size(16, 17);
            this.lbAmSeats.TabIndex = 2;
            this.lbAmSeats.Text = "0";
            // 
            // lbSeats
            // 
            this.lbSeats.AutoSize = true;
            this.lbSeats.Location = new System.Drawing.Point(6, 352);
            this.lbSeats.Name = "lbSeats";
            this.lbSeats.Size = new System.Drawing.Size(95, 17);
            this.lbSeats.TabIndex = 1;
            this.lbSeats.Text = "Aantal Zetels:";
            // 
            // cLBParties
            // 
            this.cLBParties.CheckOnClick = true;
            this.cLBParties.FormattingEnabled = true;
            this.cLBParties.Location = new System.Drawing.Point(7, 56);
            this.cLBParties.Name = "cLBParties";
            this.cLBParties.Size = new System.Drawing.Size(526, 293);
            this.cLBParties.TabIndex = 0;
            this.cLBParties.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cLBParties_ItemCheck);
            // 
            // btEditParty
            // 
            this.btEditParty.Location = new System.Drawing.Point(575, 217);
            this.btEditParty.Name = "btEditParty";
            this.btEditParty.Size = new System.Drawing.Size(126, 57);
            this.btEditParty.TabIndex = 2;
            this.btEditParty.Text = "Partij Wijzigen";
            this.btEditParty.UseVisualStyleBackColor = true;
            this.btEditParty.Click += new System.EventHandler(this.btEditParty_Click);
            // 
            // btResults
            // 
            this.btResults.Location = new System.Drawing.Point(575, 13);
            this.btResults.Name = "btResults";
            this.btResults.Size = new System.Drawing.Size(126, 57);
            this.btResults.TabIndex = 4;
            this.btResults.Text = "Uitslag";
            this.btResults.UseVisualStyleBackColor = true;
            this.btResults.Click += new System.EventHandler(this.btResults_Click);
            // 
            // btCalculateSeats
            // 
            this.btCalculateSeats.Location = new System.Drawing.Point(575, 76);
            this.btCalculateSeats.Name = "btCalculateSeats";
            this.btCalculateSeats.Size = new System.Drawing.Size(126, 57);
            this.btCalculateSeats.TabIndex = 5;
            this.btCalculateSeats.Text = "Bereken Zetels";
            this.btCalculateSeats.UseVisualStyleBackColor = true;
            this.btCalculateSeats.Click += new System.EventHandler(this.btCalculateSeats_Click);
            // 
            // FormationTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 432);
            this.Controls.Add(this.btCalculateSeats);
            this.Controls.Add(this.btResults);
            this.Controls.Add(this.btEditParty);
            this.Controls.Add(this.gbParties);
            this.Controls.Add(this.btAddParty);
            this.Name = "FormationTool";
            this.Text = "Formatie Tool";
            this.gbParties.ResumeLayout(false);
            this.gbParties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddParty;
        private System.Windows.Forms.GroupBox gbParties;
        private System.Windows.Forms.Label lbAmSeats;
        private System.Windows.Forms.Label lbSeats;
        private System.Windows.Forms.CheckedListBox cLBParties;
        private System.Windows.Forms.Button btEditParty;
        private System.Windows.Forms.Button btCreateFormation;
        private System.Windows.Forms.Label lbPartySeats;
        private System.Windows.Forms.Label lbPartyLeader;
        private System.Windows.Forms.Label lbParty;
        private System.Windows.Forms.Label lbIsMajority;
        private System.Windows.Forms.Label lbMajority;
        private System.Windows.Forms.Label lbVotes;
        private System.Windows.Forms.Button btResults;
        private System.Windows.Forms.Button btCalculateSeats;
    }
}


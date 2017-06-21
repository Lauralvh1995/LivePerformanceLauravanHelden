namespace LivePerformanceLauravanHelden.Forms
{
    partial class OverviewForm
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
            this.pbCoalition = new System.Windows.Forms.PictureBox();
            this.lbCoalitionName = new System.Windows.Forms.Label();
            this.tbCoalitionName = new System.Windows.Forms.TextBox();
            this.btExport = new System.Windows.Forms.Button();
            this.lbPrimeMinister = new System.Windows.Forms.Label();
            this.lbPrimeMinisterName = new System.Windows.Forms.Label();
            this.btSaveCoalition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoalition)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCoalition
            // 
            this.pbCoalition.Location = new System.Drawing.Point(12, 12);
            this.pbCoalition.Name = "pbCoalition";
            this.pbCoalition.Size = new System.Drawing.Size(627, 298);
            this.pbCoalition.TabIndex = 0;
            this.pbCoalition.TabStop = false;
            // 
            // lbCoalitionName
            // 
            this.lbCoalitionName.AutoSize = true;
            this.lbCoalitionName.Location = new System.Drawing.Point(13, 317);
            this.lbCoalitionName.Name = "lbCoalitionName";
            this.lbCoalitionName.Size = new System.Drawing.Size(99, 17);
            this.lbCoalitionName.TabIndex = 1;
            this.lbCoalitionName.Text = "Naam Coalitie:";
            // 
            // tbCoalitionName
            // 
            this.tbCoalitionName.Location = new System.Drawing.Point(119, 317);
            this.tbCoalitionName.Name = "tbCoalitionName";
            this.tbCoalitionName.Size = new System.Drawing.Size(381, 22);
            this.tbCoalitionName.TabIndex = 2;
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(506, 361);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(133, 34);
            this.btExport.TabIndex = 3;
            this.btExport.Text = "Exporteer Coalitie";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // lbPrimeMinister
            // 
            this.lbPrimeMinister.AutoSize = true;
            this.lbPrimeMinister.Location = new System.Drawing.Point(13, 348);
            this.lbPrimeMinister.Name = "lbPrimeMinister";
            this.lbPrimeMinister.Size = new System.Drawing.Size(61, 17);
            this.lbPrimeMinister.TabIndex = 4;
            this.lbPrimeMinister.Text = "Premier:";
            // 
            // lbPrimeMinisterName
            // 
            this.lbPrimeMinisterName.AutoSize = true;
            this.lbPrimeMinisterName.Location = new System.Drawing.Point(119, 346);
            this.lbPrimeMinisterName.Name = "lbPrimeMinisterName";
            this.lbPrimeMinisterName.Size = new System.Drawing.Size(56, 17);
            this.lbPrimeMinisterName.TabIndex = 5;
            this.lbPrimeMinisterName.Text = "premier";
            // 
            // btSaveCoalition
            // 
            this.btSaveCoalition.Location = new System.Drawing.Point(506, 316);
            this.btSaveCoalition.Name = "btSaveCoalition";
            this.btSaveCoalition.Size = new System.Drawing.Size(133, 34);
            this.btSaveCoalition.TabIndex = 6;
            this.btSaveCoalition.Text = "Coalitie Opslaan";
            this.btSaveCoalition.UseVisualStyleBackColor = true;
            this.btSaveCoalition.Click += new System.EventHandler(this.btSaveCoalition_Click);
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 407);
            this.Controls.Add(this.btSaveCoalition);
            this.Controls.Add(this.lbPrimeMinisterName);
            this.Controls.Add(this.lbPrimeMinister);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.tbCoalitionName);
            this.Controls.Add(this.lbCoalitionName);
            this.Controls.Add(this.pbCoalition);
            this.Name = "OverviewForm";
            this.Text = "Overzicht";
            ((System.ComponentModel.ISupportInitialize)(this.pbCoalition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCoalition;
        private System.Windows.Forms.Label lbCoalitionName;
        private System.Windows.Forms.TextBox tbCoalitionName;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Label lbPrimeMinister;
        private System.Windows.Forms.Label lbPrimeMinisterName;
        private System.Windows.Forms.Button btSaveCoalition;
    }
}
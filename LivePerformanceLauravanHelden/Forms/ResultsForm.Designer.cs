namespace LivePerformanceLauravanHelden
{
    partial class ResultsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataResults = new System.Windows.Forms.DataGridView();
            this.livePerformanceDataSet = new LivePerformanceLauravanHelden.LivePerformanceDataSet();
            this.livePerformanceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btCalculateSeats = new System.Windows.Forms.Button();
            this.btSendResult = new System.Windows.Forms.Button();
            this.lbParty = new System.Windows.Forms.Label();
            this.lbVotes = new System.Windows.Forms.Label();
            this.lbSeats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePerformanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePerformanceDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataResults
            // 
            this.dataResults.AutoGenerateColumns = false;
            this.dataResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResults.DataSource = this.livePerformanceDataSetBindingSource;
            this.dataResults.Location = new System.Drawing.Point(13, 34);
            this.dataResults.Name = "dataResults";
            this.dataResults.RowTemplate.Height = 24;
            this.dataResults.Size = new System.Drawing.Size(481, 344);
            this.dataResults.TabIndex = 0;
            // 
            // livePerformanceDataSet
            // 
            this.livePerformanceDataSet.DataSetName = "LivePerformanceDataSet";
            this.livePerformanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livePerformanceDataSetBindingSource
            // 
            this.livePerformanceDataSetBindingSource.DataSource = this.livePerformanceDataSet;
            this.livePerformanceDataSetBindingSource.Position = 0;
            // 
            // btCalculateSeats
            // 
            this.btCalculateSeats.Location = new System.Drawing.Point(13, 385);
            this.btCalculateSeats.Name = "btCalculateSeats";
            this.btCalculateSeats.Size = new System.Drawing.Size(114, 23);
            this.btCalculateSeats.TabIndex = 1;
            this.btCalculateSeats.Text = "Bereken Zetels";
            this.btCalculateSeats.UseVisualStyleBackColor = true;
            // 
            // btSendResult
            // 
            this.btSendResult.Location = new System.Drawing.Point(419, 384);
            this.btSendResult.Name = "btSendResult";
            this.btSendResult.Size = new System.Drawing.Size(75, 23);
            this.btSendResult.TabIndex = 2;
            this.btSendResult.Text = "Invoeren";
            this.btSendResult.UseVisualStyleBackColor = true;
            // 
            // lbParty
            // 
            this.lbParty.AutoSize = true;
            this.lbParty.Location = new System.Drawing.Point(13, 11);
            this.lbParty.Name = "lbParty";
            this.lbParty.Size = new System.Drawing.Size(40, 17);
            this.lbParty.TabIndex = 3;
            this.lbParty.Text = "Partij";
            // 
            // lbVotes
            // 
            this.lbVotes.AutoSize = true;
            this.lbVotes.Location = new System.Drawing.Point(189, 13);
            this.lbVotes.Name = "lbVotes";
            this.lbVotes.Size = new System.Drawing.Size(67, 17);
            this.lbVotes.TabIndex = 4;
            this.lbVotes.Text = "Stemmen";
            // 
            // lbSeats
            // 
            this.lbSeats.AutoSize = true;
            this.lbSeats.Location = new System.Drawing.Point(419, 13);
            this.lbSeats.Name = "lbSeats";
            this.lbSeats.Size = new System.Drawing.Size(47, 17);
            this.lbSeats.TabIndex = 5;
            this.lbSeats.Text = "Zetels";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 428);
            this.Controls.Add(this.lbSeats);
            this.Controls.Add(this.lbVotes);
            this.Controls.Add(this.lbParty);
            this.Controls.Add(this.btSendResult);
            this.Controls.Add(this.btCalculateSeats);
            this.Controls.Add(this.dataResults);
            this.Name = "ResultsForm";
            this.Text = "Uitslag Invoeren";
            ((System.ComponentModel.ISupportInitialize)(this.dataResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePerformanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePerformanceDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataResults;
        private System.Windows.Forms.BindingSource livePerformanceDataSetBindingSource;
        private LivePerformanceDataSet livePerformanceDataSet;
        private System.Windows.Forms.Button btCalculateSeats;
        private System.Windows.Forms.Button btSendResult;
        private System.Windows.Forms.Label lbParty;
        private System.Windows.Forms.Label lbVotes;
        private System.Windows.Forms.Label lbSeats;
    }
}
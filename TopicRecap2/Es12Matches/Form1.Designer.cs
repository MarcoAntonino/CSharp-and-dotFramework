namespace Es12Matches
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.MatchesOfDay = new System.Windows.Forms.DataGridView();
            this.btLoadLiveMatches = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MatchesOfDay)).BeginInit();
            this.SuspendLayout();
            // 
            // MatchesOfDay
            // 
            this.MatchesOfDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchesOfDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatchesOfDay.Location = new System.Drawing.Point(12, 100);
            this.MatchesOfDay.Name = "MatchesOfDay";
            this.MatchesOfDay.Size = new System.Drawing.Size(752, 156);
            this.MatchesOfDay.TabIndex = 0;
            // 
            // btLoadLiveMatches
            // 
            this.btLoadLiveMatches.Location = new System.Drawing.Point(612, 13);
            this.btLoadLiveMatches.Name = "btLoadLiveMatches";
            this.btLoadLiveMatches.Size = new System.Drawing.Size(151, 53);
            this.btLoadLiveMatches.TabIndex = 1;
            this.btLoadLiveMatches.Text = "Load Live Matches";
            this.btLoadLiveMatches.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 268);
            this.Controls.Add(this.btLoadLiveMatches);
            this.Controls.Add(this.MatchesOfDay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MatchesOfDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MatchesOfDay;
        private System.Windows.Forms.Button btLoadLiveMatches;
    }
}


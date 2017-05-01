namespace BlackJack.CLI
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.lblP1Name = new System.Windows.Forms.Label();
            this.lblP1Points = new System.Windows.Forms.Label();
            this.txtP1Points = new System.Windows.Forms.TextBox();
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.btnBet1D = new System.Windows.Forms.Button();
            this.btnBet100D = new System.Windows.Forms.Button();
            this.btnBet25D = new System.Windows.Forms.Button();
            this.btnBet5D = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerBet = new System.Windows.Forms.TextBox();
            this.lblP1Stack = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDPoints = new System.Windows.Forms.TextBox();
            this.lblDPoints = new System.Windows.Forms.Label();
            this.btnStand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(22, 373);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.Hit_Click);
            // 
            // lblP1Name
            // 
            this.lblP1Name.AutoSize = true;
            this.lblP1Name.Location = new System.Drawing.Point(12, 346);
            this.lblP1Name.Name = "lblP1Name";
            this.lblP1Name.Size = new System.Drawing.Size(64, 13);
            this.lblP1Name.TabIndex = 4;
            this.lblP1Name.Text = "PlayerName";
            this.lblP1Name.Click += new System.EventHandler(this.lblPlayer1_Click);
            // 
            // lblP1Points
            // 
            this.lblP1Points.AutoSize = true;
            this.lblP1Points.Location = new System.Drawing.Point(317, 349);
            this.lblP1Points.Name = "lblP1Points";
            this.lblP1Points.Size = new System.Drawing.Size(42, 13);
            this.lblP1Points.TabIndex = 6;
            this.lblP1Points.Text = "Points: ";
            // 
            // txtP1Points
            // 
            this.txtP1Points.Location = new System.Drawing.Point(365, 346);
            this.txtP1Points.Name = "txtP1Points";
            this.txtP1Points.Size = new System.Drawing.Size(57, 20);
            this.txtP1Points.TabIndex = 7;
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.AutoSize = true;
            this.lblGameStatus.Location = new System.Drawing.Point(195, 349);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(91, 13);
            this.lblGameStatus.TabIndex = 8;
            this.lblGameStatus.Text = "GameStatusLabel";
            // 
            // btnBet1D
            // 
            this.btnBet1D.Location = new System.Drawing.Point(104, 372);
            this.btnBet1D.Name = "btnBet1D";
            this.btnBet1D.Size = new System.Drawing.Size(75, 23);
            this.btnBet1D.TabIndex = 9;
            this.btnBet1D.Text = "Bet 1$";
            this.btnBet1D.UseVisualStyleBackColor = true;
            this.btnBet1D.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btnBet100D
            // 
            this.btnBet100D.Location = new System.Drawing.Point(347, 373);
            this.btnBet100D.Name = "btnBet100D";
            this.btnBet100D.Size = new System.Drawing.Size(75, 23);
            this.btnBet100D.TabIndex = 10;
            this.btnBet100D.Text = "Bet 100$";
            this.btnBet100D.UseVisualStyleBackColor = true;
            this.btnBet100D.Click += new System.EventHandler(this.btnBet100D_Click);
            // 
            // btnBet25D
            // 
            this.btnBet25D.Location = new System.Drawing.Point(266, 372);
            this.btnBet25D.Name = "btnBet25D";
            this.btnBet25D.Size = new System.Drawing.Size(75, 23);
            this.btnBet25D.TabIndex = 11;
            this.btnBet25D.Text = "Bet 25$";
            this.btnBet25D.UseVisualStyleBackColor = true;
            this.btnBet25D.Click += new System.EventHandler(this.btnBet25D_Click);
            // 
            // btnBet5D
            // 
            this.btnBet5D.Location = new System.Drawing.Point(185, 372);
            this.btnBet5D.Name = "btnBet5D";
            this.btnBet5D.Size = new System.Drawing.Size(75, 23);
            this.btnBet5D.TabIndex = 12;
            this.btnBet5D.Text = "Bet 5$";
            this.btnBet5D.UseVisualStyleBackColor = true;
            this.btnBet5D.Click += new System.EventHandler(this.btnBet5D_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPlayerBet
            // 
            this.txtPlayerBet.Location = new System.Drawing.Point(114, 345);
            this.txtPlayerBet.Name = "txtPlayerBet";
            this.txtPlayerBet.Size = new System.Drawing.Size(64, 20);
            this.txtPlayerBet.TabIndex = 14;
            // 
            // lblP1Stack
            // 
            this.lblP1Stack.AutoSize = true;
            this.lblP1Stack.Location = new System.Drawing.Point(85, 313);
            this.lblP1Stack.Name = "lblP1Stack";
            this.lblP1Stack.Size = new System.Drawing.Size(67, 13);
            this.lblP1Stack.TabIndex = 15;
            this.lblP1Stack.Text = "Player Stack";
            this.lblP1Stack.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dealer";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtDPoints
            // 
            this.txtDPoints.Location = new System.Drawing.Point(114, 56);
            this.txtDPoints.Name = "txtDPoints";
            this.txtDPoints.Size = new System.Drawing.Size(57, 20);
            this.txtDPoints.TabIndex = 18;
            // 
            // lblDPoints
            // 
            this.lblDPoints.AutoSize = true;
            this.lblDPoints.Location = new System.Drawing.Point(66, 59);
            this.lblDPoints.Name = "lblDPoints";
            this.lblDPoints.Size = new System.Drawing.Size(42, 13);
            this.lblDPoints.TabIndex = 17;
            this.lblDPoints.Text = "Points: ";
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(429, 371);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 19;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 614);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.txtDPoints);
            this.Controls.Add(this.lblDPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblP1Stack);
            this.Controls.Add(this.txtPlayerBet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBet5D);
            this.Controls.Add(this.btnBet25D);
            this.Controls.Add(this.btnBet100D);
            this.Controls.Add(this.btnBet1D);
            this.Controls.Add(this.lblGameStatus);
            this.Controls.Add(this.txtP1Points);
            this.Controls.Add(this.lblP1Points);
            this.Controls.Add(this.lblP1Name);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Label lblP1Name;
        private System.Windows.Forms.Label lblP1Points;
        private System.Windows.Forms.TextBox txtP1Points;
        private System.Windows.Forms.Label lblGameStatus;
        private System.Windows.Forms.Button btnBet1D;
        private System.Windows.Forms.Button btnBet100D;
        private System.Windows.Forms.Button btnBet25D;
        private System.Windows.Forms.Button btnBet5D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayerBet;
        private System.Windows.Forms.Label lblP1Stack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDPoints;
        private System.Windows.Forms.Label lblDPoints;
        private System.Windows.Forms.Button btnStand;
    }
}


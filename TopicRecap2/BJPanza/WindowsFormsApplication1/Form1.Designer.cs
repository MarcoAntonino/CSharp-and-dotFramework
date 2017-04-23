namespace Blackjack
{
    partial class Form1
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
            this.lblPlayerPoints = new System.Windows.Forms.Label();
            this.lblPcPoint = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.lblPc = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnStand = new System.Windows.Forms.Button();
            this.lblPcTurn = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnInsurance = new System.Windows.Forms.Button();
            this.lblPlayerCredits = new System.Windows.Forms.Label();
            this.lblPlayerMoney = new System.Windows.Forms.Label();
            this.lblChooseBet = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.btnBet50 = new System.Windows.Forms.Button();
            this.btnBet10 = new System.Windows.Forms.Button();
            this.btnBet1 = new System.Windows.Forms.Button();
            this.btnBet5 = new System.Windows.Forms.Button();
            this.lblDeck = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayerPoints
            // 
            this.lblPlayerPoints.AutoSize = true;
            this.lblPlayerPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPoints.ForeColor = System.Drawing.Color.White;
            this.lblPlayerPoints.Location = new System.Drawing.Point(593, 268);
            this.lblPlayerPoints.Name = "lblPlayerPoints";
            this.lblPlayerPoints.Size = new System.Drawing.Size(0, 24);
            this.lblPlayerPoints.TabIndex = 0;
            // 
            // lblPcPoint
            // 
            this.lblPcPoint.AutoSize = true;
            this.lblPcPoint.BackColor = System.Drawing.Color.Transparent;
            this.lblPcPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcPoint.ForeColor = System.Drawing.Color.White;
            this.lblPcPoint.Location = new System.Drawing.Point(593, 44);
            this.lblPcPoint.Name = "lblPcPoint";
            this.lblPcPoint.Size = new System.Drawing.Size(0, 24);
            this.lblPcPoint.TabIndex = 1;
            // 
            // btnHit
            // 
            this.btnHit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHit.Location = new System.Drawing.Point(145, 174);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // lblPc
            // 
            this.lblPc.AutoSize = true;
            this.lblPc.BackColor = System.Drawing.Color.Transparent;
            this.lblPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPc.ForeColor = System.Drawing.Color.White;
            this.lblPc.Location = new System.Drawing.Point(538, 9);
            this.lblPc.Name = "lblPc";
            this.lblPc.Size = new System.Drawing.Size(134, 24);
            this.lblPc.TabIndex = 3;
            this.lblPc.Text = "Dealer Points";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.White;
            this.lblPlayer.Location = new System.Drawing.Point(541, 233);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(131, 24);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "Player Points";
            // 
            // btnStand
            // 
            this.btnStand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStand.Location = new System.Drawing.Point(226, 174);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 5;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblPcTurn
            // 
            this.lblPcTurn.AutoSize = true;
            this.lblPcTurn.ForeColor = System.Drawing.Color.White;
            this.lblPcTurn.Location = new System.Drawing.Point(304, 158);
            this.lblPcTurn.Name = "lblPcTurn";
            this.lblPcTurn.Size = new System.Drawing.Size(82, 13);
            this.lblPcTurn.TabIndex = 6;
            this.lblPcTurn.Text = "It\'s Dealer\'s turn";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.ForeColor = System.Drawing.Color.White;
            this.lblPlayerTurn.Location = new System.Drawing.Point(298, 200);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(94, 13);
            this.lblPlayerTurn.TabIndex = 7;
            this.lblPlayerTurn.Text = "--> It\'s your turn <--";
            // 
            // btnSplit
            // 
            this.btnSplit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSplit.Location = new System.Drawing.Point(307, 174);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 8;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDouble.Location = new System.Drawing.Point(388, 174);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 23);
            this.btnDouble.TabIndex = 9;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnInsurance
            // 
            this.btnInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsurance.Location = new System.Drawing.Point(469, 174);
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.Size = new System.Drawing.Size(75, 23);
            this.btnInsurance.TabIndex = 10;
            this.btnInsurance.Text = "Insurance";
            this.btnInsurance.UseVisualStyleBackColor = true;
            // 
            // lblPlayerCredits
            // 
            this.lblPlayerCredits.AutoSize = true;
            this.lblPlayerCredits.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCredits.ForeColor = System.Drawing.Color.White;
            this.lblPlayerCredits.Location = new System.Drawing.Point(533, 301);
            this.lblPlayerCredits.Name = "lblPlayerCredits";
            this.lblPlayerCredits.Size = new System.Drawing.Size(139, 24);
            this.lblPlayerCredits.TabIndex = 12;
            this.lblPlayerCredits.Text = "Player Credits";
            // 
            // lblPlayerMoney
            // 
            this.lblPlayerMoney.AutoSize = true;
            this.lblPlayerMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerMoney.ForeColor = System.Drawing.Color.White;
            this.lblPlayerMoney.Location = new System.Drawing.Point(593, 335);
            this.lblPlayerMoney.Name = "lblPlayerMoney";
            this.lblPlayerMoney.Size = new System.Drawing.Size(0, 24);
            this.lblPlayerMoney.TabIndex = 14;
            // 
            // lblChooseBet
            // 
            this.lblChooseBet.AutoSize = true;
            this.lblChooseBet.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseBet.ForeColor = System.Drawing.Color.White;
            this.lblChooseBet.Location = new System.Drawing.Point(12, 233);
            this.lblChooseBet.Name = "lblChooseBet";
            this.lblChooseBet.Size = new System.Drawing.Size(122, 24);
            this.lblChooseBet.TabIndex = 19;
            this.lblChooseBet.Text = "Click To Bet";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.Transparent;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.Color.White;
            this.lblBet.Location = new System.Drawing.Point(248, 233);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(165, 24);
            this.lblBet.TabIndex = 20;
            this.lblBet.Text = "Your Current Bet";
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetAmount.ForeColor = System.Drawing.Color.White;
            this.lblBetAmount.Location = new System.Drawing.Point(325, 261);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(0, 24);
            this.lblBetAmount.TabIndex = 21;
            // 
            // btnBet50
            // 
            this.btnBet50.FlatAppearance.BorderSize = 0;
            this.btnBet50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet50.ForeColor = System.Drawing.Color.White;
            this.btnBet50.Image = global::Blackjack.Properties.Resources.bet50;
            this.btnBet50.Location = new System.Drawing.Point(68, 297);
            this.btnBet50.Name = "btnBet50";
            this.btnBet50.Size = new System.Drawing.Size(31, 31);
            this.btnBet50.TabIndex = 18;
            this.btnBet50.Text = "50";
            this.btnBet50.UseVisualStyleBackColor = true;
            this.btnBet50.Click += new System.EventHandler(this.btnBet50_Click);
            // 
            // btnBet10
            // 
            this.btnBet10.FlatAppearance.BorderSize = 0;
            this.btnBet10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet10.ForeColor = System.Drawing.Color.White;
            this.btnBet10.Image = global::Blackjack.Properties.Resources.bet10;
            this.btnBet10.Location = new System.Drawing.Point(31, 297);
            this.btnBet10.Name = "btnBet10";
            this.btnBet10.Size = new System.Drawing.Size(31, 31);
            this.btnBet10.TabIndex = 17;
            this.btnBet10.Text = "20";
            this.btnBet10.UseVisualStyleBackColor = true;
            this.btnBet10.Click += new System.EventHandler(this.btnBet10_Click);
            // 
            // btnBet1
            // 
            this.btnBet1.AutoSize = true;
            this.btnBet1.FlatAppearance.BorderSize = 0;
            this.btnBet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet1.ForeColor = System.Drawing.Color.White;
            this.btnBet1.Image = global::Blackjack.Properties.Resources.bet1;
            this.btnBet1.Location = new System.Drawing.Point(31, 260);
            this.btnBet1.Name = "btnBet1";
            this.btnBet1.Size = new System.Drawing.Size(31, 31);
            this.btnBet1.TabIndex = 16;
            this.btnBet1.Text = "2";
            this.btnBet1.UseVisualStyleBackColor = true;
            this.btnBet1.Click += new System.EventHandler(this.btnBet1_Click);
            // 
            // btnBet5
            // 
            this.btnBet5.AutoSize = true;
            this.btnBet5.FlatAppearance.BorderSize = 0;
            this.btnBet5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet5.ForeColor = System.Drawing.Color.White;
            this.btnBet5.Image = global::Blackjack.Properties.Resources.bet5;
            this.btnBet5.Location = new System.Drawing.Point(68, 260);
            this.btnBet5.Name = "btnBet5";
            this.btnBet5.Size = new System.Drawing.Size(31, 31);
            this.btnBet5.TabIndex = 15;
            this.btnBet5.Text = "10";
            this.btnBet5.UseVisualStyleBackColor = true;
            this.btnBet5.Click += new System.EventHandler(this.btnBet5_Click);
            // 
            // lblDeck
            // 
            this.lblDeck.Image = global::Blackjack.Properties.Resources.deckrear;
            this.lblDeck.Location = new System.Drawing.Point(12, 143);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(50, 70);
            this.lblDeck.TabIndex = 13;
            this.lblDeck.Click += new System.EventHandler(this.lblDeck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Image = global::Blackjack.Properties.Resources.clubs;
            this.label1.Location = new System.Drawing.Point(226, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(684, 460);
            this.Controls.Add(this.lblBetAmount);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblChooseBet);
            this.Controls.Add(this.btnBet50);
            this.Controls.Add(this.btnBet10);
            this.Controls.Add(this.btnBet1);
            this.Controls.Add(this.btnBet5);
            this.Controls.Add(this.lblPlayerMoney);
            this.Controls.Add(this.lblDeck);
            this.Controls.Add(this.lblPlayerCredits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsurance);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.lblPcTurn);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblPc);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblPcPoint);
            this.Controls.Add(this.lblPlayerPoints);
            this.Name = "Form1";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerPoints;
        private System.Windows.Forms.Label lblPcPoint;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Label lblPc;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Label lblPcTurn;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnInsurance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerCredits;
        private System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.Label lblPlayerMoney;
        private System.Windows.Forms.Button btnBet5;
        private System.Windows.Forms.Button btnBet1;
        private System.Windows.Forms.Button btnBet10;
        private System.Windows.Forms.Button btnBet50;
        private System.Windows.Forms.Label lblChooseBet;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblBetAmount;
    }
}


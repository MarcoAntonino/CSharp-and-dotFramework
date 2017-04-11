namespace TourDelCavaliere
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtSize = new System.Windows.Forms.TextBox();
      this.btnStart = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(116, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Dimensioni scacchiera:";
      // 
      // txtSize
      // 
      this.txtSize.Location = new System.Drawing.Point(143, 6);
      this.txtSize.Name = "txtSize";
      this.txtSize.Size = new System.Drawing.Size(44, 20);
      this.txtSize.TabIndex = 1;
      this.txtSize.Text = "8";
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(211, 4);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 2;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(491, 330);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.txtSize);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Tour del Cavaliere";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSize;
    private System.Windows.Forms.Button btnStart;
  }
}


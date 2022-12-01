namespace UZahlenraten
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblConstDescription = new System.Windows.Forms.Label();
            this.LblOutput = new System.Windows.Forms.Label();
            this.CmdGenerateRandomNum = new System.Windows.Forms.Button();
            this.CmdPruefen = new System.Windows.Forms.Button();
            this.TBxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblConstDescription
            // 
            this.LblConstDescription.AutoSize = true;
            this.LblConstDescription.Location = new System.Drawing.Point(12, 74);
            this.LblConstDescription.Name = "LblConstDescription";
            this.LblConstDescription.Size = new System.Drawing.Size(75, 15);
            this.LblConstDescription.TabIndex = 0;
            this.LblConstDescription.Text = "Ihre Eingabe:";
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(12, 105);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(137, 15);
            this.LblOutput.TabIndex = 1;
            this.LblOutput.Text = "";
            // 
            // CmdGenerateRandomNum
            // 
            this.CmdGenerateRandomNum.Location = new System.Drawing.Point(16, 23);
            this.CmdGenerateRandomNum.Name = "CmdGenerateRandomNum";
            this.CmdGenerateRandomNum.Size = new System.Drawing.Size(212, 23);
            this.CmdGenerateRandomNum.TabIndex = 2;
            this.CmdGenerateRandomNum.Text = "Zufallszahl erzeugen";
            this.CmdGenerateRandomNum.UseVisualStyleBackColor = true;
            this.CmdGenerateRandomNum.Click += new System.EventHandler(this.CmdGenerateRandomNum_Click);
            // 
            // CmdPruefen
            // 
            this.CmdPruefen.Location = new System.Drawing.Point(282, 70);
            this.CmdPruefen.Name = "CmdPruefen";
            this.CmdPruefen.Size = new System.Drawing.Size(135, 23);
            this.CmdPruefen.TabIndex = 3;
            this.CmdPruefen.Text = "Eingabe prüfen";
            this.CmdPruefen.UseVisualStyleBackColor = true;
            this.CmdPruefen.Click += new System.EventHandler(this.CmdCompare_Click);
            // 
            // TBxInput
            // 
            this.TBxInput.Location = new System.Drawing.Point(96, 71);
            this.TBxInput.Name = "TBxInput";
            this.TBxInput.Size = new System.Drawing.Size(180, 23);
            this.TBxInput.TabIndex = 4;
            this.TBxInput.Text = "";
            this.TBxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 135);
            this.Controls.Add(this.TBxInput);
            this.Controls.Add(this.CmdPruefen);
            this.Controls.Add(this.CmdGenerateRandomNum);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.LblConstDescription);
            this.Name = "MainForm";
            this.Text = "Übung Zahlenraten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblConstDescription;
        private Label LblOutput;
        private Button CmdGenerateRandomNum;
        private Button CmdPruefen;
        private TextBox TBxInput;
    }
}
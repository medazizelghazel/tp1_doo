namespace tp0
{
    partial class frmFactoriel
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
            this.BtnCalc = new System.Windows.Forms.Button();
            this.LblRes = new System.Windows.Forms.Label();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(561, 128);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 0;
            this.BtnCalc.Text = "calculer";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Location = new System.Drawing.Point(351, 227);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(44, 16);
            this.LblRes.TabIndex = 1;
            this.LblRes.Text = "label1";
            this.LblRes.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtN
            // 
            this.TxtN.Location = new System.Drawing.Point(208, 129);
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(100, 22);
            this.TxtN.TabIndex = 2;
            this.TxtN.TextChanged += new System.EventHandler(this.TxtN_TextChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(189, 315);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(585, 314);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitter.TabIndex = 4;
            this.BtnQuitter.Text = "quiter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "factoriel";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmFactoriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TxtN);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.BtnCalc);
            this.Name = "frmFactoriel";
            this.Text = "frmFactoriel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Label label1;
    }
}
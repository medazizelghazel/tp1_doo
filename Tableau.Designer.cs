namespace tp0
{
    partial class Tableau
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
            this.BtnEnreg = new System.Windows.Forms.Button();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.LblRes = new System.Windows.Forms.Label();
            this.LblT = new System.Windows.Forms.Label();
            this.LblMoy = new System.Windows.Forms.Label();
            this.LblEcart = new System.Windows.Forms.Label();
            this.LblInf = new System.Windows.Forms.Label();
            this.LblSup = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCale = new System.Windows.Forms.Button();
            this.BtnQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "enregistrement des notes";
            // 
            // BtnEnreg
            // 
            this.BtnEnreg.Location = new System.Drawing.Point(562, 145);
            this.BtnEnreg.Name = "BtnEnreg";
            this.BtnEnreg.Size = new System.Drawing.Size(112, 39);
            this.BtnEnreg.TabIndex = 1;
            this.BtnEnreg.Text = "enregistrer";
            this.BtnEnreg.UseVisualStyleBackColor = true;
            this.BtnEnreg.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtN
            // 
            this.TxtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN.Location = new System.Drawing.Point(367, 153);
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(100, 30);
            this.TxtN.TabIndex = 2;
            this.TxtN.TextChanged += new System.EventHandler(this.TxtN_TextChanged);
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(22, 153);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(135, 25);
            this.LblRes.TabIndex = 3;
            this.LblRes.Text = "num de  elev";
            this.LblRes.Click += new System.EventHandler(this.LblRes_Click);
            // 
            // LblT
            // 
            this.LblT.AutoSize = true;
            this.LblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblT.Location = new System.Drawing.Point(338, 217);
            this.LblT.Name = "LblT";
            this.LblT.Size = new System.Drawing.Size(42, 25);
            this.LblT.TabIndex = 4;
            this.LblT.Text = "res";
            this.LblT.Click += new System.EventHandler(this.LblT_Click);
            // 
            // LblMoy
            // 
            this.LblMoy.AutoSize = true;
            this.LblMoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoy.Location = new System.Drawing.Point(351, 268);
            this.LblMoy.Name = "LblMoy";
            this.LblMoy.Size = new System.Drawing.Size(70, 25);
            this.LblMoy.TabIndex = 5;
            this.LblMoy.Text = "label2";
            this.LblMoy.Click += new System.EventHandler(this.LblMoy_Click);
            // 
            // LblEcart
            // 
            this.LblEcart.AutoSize = true;
            this.LblEcart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEcart.Location = new System.Drawing.Point(351, 293);
            this.LblEcart.Name = "LblEcart";
            this.LblEcart.Size = new System.Drawing.Size(70, 25);
            this.LblEcart.TabIndex = 6;
            this.LblEcart.Text = "label2";
            this.LblEcart.Click += new System.EventHandler(this.LblEcart_Click);
            // 
            // LblInf
            // 
            this.LblInf.AutoSize = true;
            this.LblInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInf.Location = new System.Drawing.Point(351, 322);
            this.LblInf.Name = "LblInf";
            this.LblInf.Size = new System.Drawing.Size(70, 25);
            this.LblInf.TabIndex = 7;
            this.LblInf.Text = "label3";
            this.LblInf.Click += new System.EventHandler(this.LblInf_Click);
            // 
            // LblSup
            // 
            this.LblSup.AutoSize = true;
            this.LblSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSup.Location = new System.Drawing.Point(351, 347);
            this.LblSup.Name = "LblSup";
            this.LblSup.Size = new System.Drawing.Size(70, 25);
            this.LblSup.TabIndex = 8;
            this.LblSup.Text = "label4";
            this.LblSup.Click += new System.EventHandler(this.LblSup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre des Notes >=10:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre des Notes < 10:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "l\'ecart type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Moyenne de la classe:";
            // 
            // BtnCale
            // 
            this.BtnCale.Location = new System.Drawing.Point(528, 273);
            this.BtnCale.Name = "BtnCale";
            this.BtnCale.Size = new System.Drawing.Size(170, 44);
            this.BtnCale.TabIndex = 13;
            this.BtnCale.Text = "Calculer";
            this.BtnCale.UseVisualStyleBackColor = true;
            this.BtnCale.Click += new System.EventHandler(this.BtnCale_Click);
            // 
            // BtnQ
            // 
            this.BtnQ.Location = new System.Drawing.Point(526, 336);
            this.BtnQ.Name = "BtnQ";
            this.BtnQ.Size = new System.Drawing.Size(171, 51);
            this.BtnQ.TabIndex = 14;
            this.BtnQ.Text = "Quitter";
            this.BtnQ.UseVisualStyleBackColor = true;
            this.BtnQ.Click += new System.EventHandler(this.BtnQ_Click);
            // 
            // Tableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnQ);
            this.Controls.Add(this.BtnCale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblSup);
            this.Controls.Add(this.LblInf);
            this.Controls.Add(this.LblEcart);
            this.Controls.Add(this.LblMoy);
            this.Controls.Add(this.LblT);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.TxtN);
            this.Controls.Add(this.BtnEnreg);
            this.Controls.Add(this.label1);
            this.Name = "Tableau";
            this.Text = "Tableau";
            this.Load += new System.EventHandler(this.Tableau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEnreg;
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Label LblT;
        private System.Windows.Forms.Label LblMoy;
        private System.Windows.Forms.Label LblEcart;
        private System.Windows.Forms.Label LblInf;
        private System.Windows.Forms.Label LblSup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCale;
        private System.Windows.Forms.Button BtnQ;
    }
}
namespace DnsValidator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnARSoft = new System.Windows.Forms.Button();
            this.btnDnDns = new System.Windows.Forms.Button();
            this.btnCheckDomainName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnARSoft
            // 
            this.btnARSoft.Location = new System.Drawing.Point(23, 27);
            this.btnARSoft.Name = "btnARSoft";
            this.btnARSoft.Size = new System.Drawing.Size(75, 23);
            this.btnARSoft.TabIndex = 0;
            this.btnARSoft.Text = "ARSoft";
            this.btnARSoft.UseVisualStyleBackColor = true;
            this.btnARSoft.Click += new System.EventHandler(this.btnARSoft_Click);
            // 
            // btnDnDns
            // 
            this.btnDnDns.Location = new System.Drawing.Point(115, 27);
            this.btnDnDns.Name = "btnDnDns";
            this.btnDnDns.Size = new System.Drawing.Size(75, 23);
            this.btnDnDns.TabIndex = 1;
            this.btnDnDns.Text = "DnDns";
            this.btnDnDns.UseVisualStyleBackColor = true;
            this.btnDnDns.Click += new System.EventHandler(this.btnDnDns_Click);
            // 
            // btnCheckDomainName
            // 
            this.btnCheckDomainName.Location = new System.Drawing.Point(23, 73);
            this.btnCheckDomainName.Name = "btnCheckDomainName";
            this.btnCheckDomainName.Size = new System.Drawing.Size(167, 23);
            this.btnCheckDomainName.TabIndex = 2;
            this.btnCheckDomainName.Text = "CheckDomainName";
            this.btnCheckDomainName.UseVisualStyleBackColor = true;
            this.btnCheckDomainName.Click += new System.EventHandler(this.btnCheckDomainName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCheckDomainName);
            this.Controls.Add(this.btnDnDns);
            this.Controls.Add(this.btnARSoft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnARSoft;
        private System.Windows.Forms.Button btnDnDns;
        private System.Windows.Forms.Button btnCheckDomainName;
    }
}


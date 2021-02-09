
namespace TastaturUndMaus
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
			this.txtEingabe = new System.Windows.Forms.TextBox();
			this.lblAusgabe = new System.Windows.Forms.Label();
			this.btnAusgabe = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtEingabe
			// 
			this.txtEingabe.Location = new System.Drawing.Point(13, 13);
			this.txtEingabe.Name = "txtEingabe";
			this.txtEingabe.Size = new System.Drawing.Size(100, 20);
			this.txtEingabe.TabIndex = 0;
			this.txtEingabe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEingabe_KeyDown);
			// 
			// lblAusgabe
			// 
			this.lblAusgabe.AutoSize = true;
			this.lblAusgabe.Location = new System.Drawing.Point(13, 40);
			this.lblAusgabe.Name = "lblAusgabe";
			this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
			this.lblAusgabe.TabIndex = 1;
			this.lblAusgabe.Text = "label1";
			// 
			// btnAusgabe
			// 
			this.btnAusgabe.Location = new System.Drawing.Point(131, 13);
			this.btnAusgabe.Name = "btnAusgabe";
			this.btnAusgabe.Size = new System.Drawing.Size(75, 23);
			this.btnAusgabe.TabIndex = 2;
			this.btnAusgabe.Text = "Ausgabe";
			this.btnAusgabe.UseVisualStyleBackColor = true;
			this.btnAusgabe.Click += new System.EventHandler(this.btnAusgabe_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 236);
			this.Controls.Add(this.btnAusgabe);
			this.Controls.Add(this.lblAusgabe);
			this.Controls.Add(this.txtEingabe);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEingabe;
		private System.Windows.Forms.Label lblAusgabe;
		private System.Windows.Forms.Button btnAusgabe;
	}
}


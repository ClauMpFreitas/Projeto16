/*
 * Criado por SharpDevelop.
 * Usuário: Diogo Freitas
 * Data: 29/03/2023
 * Hora: 08:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Projeto16
{
	partial class FrmPratica16
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker DtpData;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtData;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxtDia;
		private System.Windows.Forms.TextBox TxtMes;
		private System.Windows.Forms.TextBox TxtAno;
		private System.Windows.Forms.TextBox TxtDiaAno;
		private System.Windows.Forms.Button BtnPegarData;
		private System.Windows.Forms.Button BtnDataAtual;
		private System.Windows.Forms.Button BtnDefinirData;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.DtpData = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtData = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtDia = new System.Windows.Forms.TextBox();
			this.TxtMes = new System.Windows.Forms.TextBox();
			this.TxtAno = new System.Windows.Forms.TextBox();
			this.TxtDiaAno = new System.Windows.Forms.TextBox();
			this.BtnPegarData = new System.Windows.Forms.Button();
			this.BtnDataAtual = new System.Windows.Forms.Button();
			this.BtnDefinirData = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Selecione a data";
			// 
			// DtpData
			// 
			this.DtpData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DtpData.Location = new System.Drawing.Point(21, 46);
			this.DtpData.Name = "DtpData";
			this.DtpData.Size = new System.Drawing.Size(344, 26);
			this.DtpData.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Data";
			// 
			// TxtData
			// 
			this.TxtData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtData.Location = new System.Drawing.Point(21, 119);
			this.TxtData.Name = "TxtData";
			this.TxtData.Size = new System.Drawing.Size(344, 26);
			this.TxtData.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Dia";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(265, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Mês";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(21, 234);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Ano";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(265, 234);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "Dia do ano";
			// 
			// TxtDia
			// 
			this.TxtDia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtDia.Location = new System.Drawing.Point(21, 188);
			this.TxtDia.Name = "TxtDia";
			this.TxtDia.Size = new System.Drawing.Size(135, 26);
			this.TxtDia.TabIndex = 8;
			// 
			// TxtMes
			// 
			this.TxtMes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtMes.Location = new System.Drawing.Point(265, 188);
			this.TxtMes.Name = "TxtMes";
			this.TxtMes.Size = new System.Drawing.Size(124, 26);
			this.TxtMes.TabIndex = 9;
			// 
			// TxtAno
			// 
			this.TxtAno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtAno.Location = new System.Drawing.Point(21, 261);
			this.TxtAno.Name = "TxtAno";
			this.TxtAno.Size = new System.Drawing.Size(135, 26);
			this.TxtAno.TabIndex = 10;
			// 
			// TxtDiaAno
			// 
			this.TxtDiaAno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtDiaAno.Location = new System.Drawing.Point(265, 261);
			this.TxtDiaAno.Name = "TxtDiaAno";
			this.TxtDiaAno.Size = new System.Drawing.Size(124, 26);
			this.TxtDiaAno.TabIndex = 11;
			// 
			// BtnPegarData
			// 
			this.BtnPegarData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnPegarData.Location = new System.Drawing.Point(438, 32);
			this.BtnPegarData.Name = "BtnPegarData";
			this.BtnPegarData.Size = new System.Drawing.Size(117, 29);
			this.BtnPegarData.TabIndex = 12;
			this.BtnPegarData.Text = "Pegar Data";
			this.BtnPegarData.UseVisualStyleBackColor = true;
			this.BtnPegarData.Click += new System.EventHandler(this.BtnPegarDataClick);
			// 
			// BtnDataAtual
			// 
			this.BtnDataAtual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnDataAtual.Location = new System.Drawing.Point(438, 76);
			this.BtnDataAtual.Name = "BtnDataAtual";
			this.BtnDataAtual.Size = new System.Drawing.Size(117, 27);
			this.BtnDataAtual.TabIndex = 13;
			this.BtnDataAtual.Text = "Data Atual";
			this.BtnDataAtual.UseVisualStyleBackColor = true;
			this.BtnDataAtual.Click += new System.EventHandler(this.BtnDataAtualClick);
			// 
			// BtnDefinirData
			// 
			this.BtnDefinirData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnDefinirData.Location = new System.Drawing.Point(438, 120);
			this.BtnDefinirData.Name = "BtnDefinirData";
			this.BtnDefinirData.Size = new System.Drawing.Size(117, 27);
			this.BtnDefinirData.TabIndex = 14;
			this.BtnDefinirData.Text = "Define Data";
			this.BtnDefinirData.UseVisualStyleBackColor = true;
			this.BtnDefinirData.Click += new System.EventHandler(this.BtnDefinirDataClick);
			// 
			// FrmPratica16
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 315);
			this.Controls.Add(this.BtnDefinirData);
			this.Controls.Add(this.BtnDataAtual);
			this.Controls.Add(this.BtnPegarData);
			this.Controls.Add(this.TxtDiaAno);
			this.Controls.Add(this.TxtAno);
			this.Controls.Add(this.TxtMes);
			this.Controls.Add(this.TxtDia);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtData);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DtpData);
			this.Controls.Add(this.label1);
			this.Name = "FrmPratica16";
			this.Text = "Pratica 16 – Usando DatTimePicker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

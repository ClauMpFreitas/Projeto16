using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto16
{
	public partial class FrmPratica16 : Form
	{
		public FrmPratica16()
		{
			InitializeComponent();
		}
		void BtnPegarDataClick(object sender, EventArgs e)
		{
			TxtData.Text=DtpData.Text;
			TxtDia.Text=DtpData.Value.Day.ToString();
			TxtMes.Text=DtpData.Value.Month.ToString();
			TxtAno.Text=DtpData.Value.Year.ToString();
			TxtDiaAno.Text=DtpData.Value.DayOfYear.ToString();
		}
		void BtnDataAtualClick(object sender, EventArgs e)
		{
			DtpData.Value=DateTime.Today;
		}
		void BtnDefinirDataClick(object sender, EventArgs e)
		{
			int d, m, a;
			
			d=Convert.ToInt32(TxtDia.Text);
			m=Convert.ToInt32(TxtMes.Text);
			a=Convert.ToInt32(TxtAno.Text);
			DateTime dt = new DateTime(a, m, d);
			DtpData.Value=dt;
		}
	}
}

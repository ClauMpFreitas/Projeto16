﻿/*
 * Criado por SharpDevelop.
 * Usuário: Diogo Freitas
 * Data: 29/03/2023
 * Hora: 08:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Windows.Forms;

namespace Projeto16
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmPratica16());
		}
		
	}
}

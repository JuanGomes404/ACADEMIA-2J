using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia_2J
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CadastroCliente cc = new CadastroCliente();
			cc.Show();
			this.Dispose();

			
		}

		private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CadastroCliente cc = new CadastroCliente();
			cc.Show();
			this.Dispose();
		}

		private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CadastroCliente cc = new CadastroCliente();
			cc.Show();
			this.Dispose();


		}
	}
}

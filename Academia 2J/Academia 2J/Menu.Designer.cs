namespace Academia_2J
{
	partial class Menu
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastroDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastroDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.alterarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.excluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAlunosToolStripMenuItem,
            this.cadastroDeFuncionáriosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(747, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadastroDeAlunosToolStripMenuItem
			// 
			this.cadastroDeAlunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
			this.cadastroDeAlunosToolStripMenuItem.Name = "cadastroDeAlunosToolStripMenuItem";
			this.cadastroDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
			this.cadastroDeAlunosToolStripMenuItem.Text = "Cadastro de Alunos";
			// 
			// cadastroDeFuncionáriosToolStripMenuItem
			// 
			this.cadastroDeFuncionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.alterarToolStripMenuItem1,
            this.excluirToolStripMenuItem1});
			this.cadastroDeFuncionáriosToolStripMenuItem.Name = "cadastroDeFuncionáriosToolStripMenuItem";
			this.cadastroDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
			this.cadastroDeFuncionáriosToolStripMenuItem.Text = "Cadastro de Funcionários";
			// 
			// cadastrarToolStripMenuItem
			// 
			this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
			this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cadastrarToolStripMenuItem.Text = "Cadastrar";
			this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
			// 
			// alterarToolStripMenuItem
			// 
			this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
			this.alterarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.alterarToolStripMenuItem.Text = "Alterar";
			this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
			// 
			// excluirToolStripMenuItem
			// 
			this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
			this.excluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.excluirToolStripMenuItem.Text = "Excluir";
			this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
			// 
			// cadastrarToolStripMenuItem1
			// 
			this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
			this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
			// 
			// alterarToolStripMenuItem1
			// 
			this.alterarToolStripMenuItem1.Name = "alterarToolStripMenuItem1";
			this.alterarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.alterarToolStripMenuItem1.Text = "Alterar";
			// 
			// excluirToolStripMenuItem1
			// 
			this.excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
			this.excluirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.excluirToolStripMenuItem1.Text = "Excluir";
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(747, 342);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Menu";
			this.Text = "Menu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionáriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem1;
	}
}


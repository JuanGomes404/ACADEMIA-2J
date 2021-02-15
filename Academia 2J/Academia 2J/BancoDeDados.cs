using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Academia_2J
{
	class BancoDeDados
	{
		MySqlConnection bdCon;

		public bool conecta()
		{
			bool sucesso = true;
			bdCon = new MySqlConnection("server = localhost; database = bd_academia, uid = root, pwd =''");

			try
			{

				bdCon.Open();
			}
			catch
			{
				sucesso = false;
			}

			return sucesso;
		}

		public void desconecta()
		{
			bdCon.Close();

		}


	}
}

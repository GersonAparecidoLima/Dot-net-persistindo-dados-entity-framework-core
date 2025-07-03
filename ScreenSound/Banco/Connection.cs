using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;
internal class Connection
{
    //Define como conectar ao banco de dados.
    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False";

    //Retorna uma nova conexão com o banco.
    public SqlConnection ObterConexao()
    {
        return new SqlConnection(connectionString);
    }




}
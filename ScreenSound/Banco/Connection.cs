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


    public IEnumerable<Artista> Listar()
    {
        //Cria uma lista de artistas.
        var lista = new List<Artista>();
        //Abre a conexão com o banco.
        using var connection = ObterConexao();
        connection.Open();

        //Cria um comando SQL para buscar todos os artistas da tabela Artistas
        string sql = "SELECT * FROM Artistas";
        //Representa o comando SQL que será executado - SqlCommand
        SqlCommand command = new SqlCommand(sql, connection);
        //Executa o comando e obtém um leitor de dados(SqlDataReader) que permite percorrer os resultados da consulta.
        using SqlDataReader dataReader = command.ExecuteReader();

        //Permite ler os resultados da consulta linha por linha - SqlDataReader.
        while (dataReader.Read())
        {
            string nomeArtista = Convert.ToString(dataReader["Nome"]);
            string bioArtista = Convert.ToString(dataReader["Bio"]);
            int idArtista = Convert.ToInt32(dataReader["Id"]);
            Artista artista = new(nomeArtista, bioArtista) { Id = idArtista };

            lista.Add(artista);
        }

        return lista;
    }

}
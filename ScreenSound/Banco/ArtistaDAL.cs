using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL
    {

        public IEnumerable<Artista> Listar()
        {
            //Cria uma lista de artistas.
            var lista = new List<Artista>();
            //Abre a conexão com o banco.
            //using var connection = ObterConexao();
            using var connection = new Connection().ObterConexao();
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

        public void Adicionar(Artista artista) {

            using var connection = new Connection().ObterConexao();
            connection.Open();
            string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@nome", artista.Nome);
            command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
            command.Parameters.AddWithValue("@bio",artista.Nome);

            //Buscando o numero de linha que foi inserrido
            //command.ExecuteNonQuery(), que será responsável por executar essa adição
            int retorno = command.ExecuteNonQuery();
            Console.WriteLine($"Linhas afetadas : {retorno}");
        }

        public void Atualizar(Artista artista)
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = $"UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@nome", artista.Nome);
            command.Parameters.AddWithValue("@bio", artista.Bio);
            command.Parameters.AddWithValue("@id", artista.Id);

            int retorno = command.ExecuteNonQuery();

            Console.WriteLine($"Linhas afetadas: {retorno}");
        }

        public void Deletar(Artista artista)
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = $"DELETE FROM Artistas WHERE Id = @id";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id", artista.Id);

            int retorno = command.ExecuteNonQuery();

            Console.WriteLine($"Linhas afetadas: {retorno}");
        }


    }
}

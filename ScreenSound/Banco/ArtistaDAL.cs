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
        private readonly ScreenSoundContext context;

        public ArtistaDAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public IEnumerable<Artista> Listar()
        {
            return context.Artistas.ToList();
        }

        public void Adicionar(Artista artista)
        {
            context.Artistas.Add(artista);
            //Salvando a insersão na tabela
            context.SaveChanges();
        }

        public void Atualizar(Artista artista)
        {
            context.Artistas.Update(artista); 
            //Salvando as alteração na tabela
            context.SaveChanges();
        }

        public void Deletar(Artista artista)
        {
            var artistaExistente = context.Artistas.Find(artista.Id);
            if (artistaExistente != null)
            {
                context.Artistas.Remove(artistaExistente);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Artista não encontrado para exclusão.");
            }
        }



        public void DeletarPorId(int id)
        {
            var artista = context.Artistas.Find(id);
            if (artista != null)
            {
                context.Artistas.Remove(artista);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Nenhum artista com Id = {id} foi encontrado.");
            }
        }

        public Artista? RecuperarPeloNome(string nome)
        {
            return context.Artistas.FirstOrDefault(a => a.Nome.Equals(nome));

        }


    }
}

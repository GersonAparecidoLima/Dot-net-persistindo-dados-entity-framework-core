﻿using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace ScreenSound.Banco
{
    public class DAL<T> where T : class
    {
        protected readonly ScreenSoundContext context;

        public DAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> Listar() =>
            context.Set<T>().ToList();

        public void Adicionar(T objeto)
        {
            context.Set<T>().Add(objeto);
            context.SaveChanges();
        }

        public void Atualizar(T objeto)
        {
            context.Set<T>().Update(objeto);
            context.SaveChanges();
        }

        public void Deletar(T objeto)
        {
            context.Set<T>().Remove(objeto);
            context.SaveChanges();
        }

        public T? RecuperarPor(Func<T, bool> condicao) =>
            context.Set<T>().FirstOrDefault(condicao);
    }
}

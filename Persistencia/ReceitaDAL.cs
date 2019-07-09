using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
   public class ReceitaDAL
    {
        private EFContext context;
        public IList<Receita> TodasAsReceitas()
        {
            using (var context = new EFContext())
            {
                return context.Receitas.ToList<Receita>();
            }
        }


        public void Gravar(Receita receita)
        {
            using (var context = new EFContext())
            {
                context.Receitas.Add(receita);
                context.SaveChanges();
            }
        }

        public void Excluir(Receita receita)
        {
            using (var context = new EFContext())
            {
                context.Receitas.Remove(receita);
                context.SaveChanges();
            }
        }

        public Receita ObterID(long id)
        {
            using (var context = new EFContext())
            {
                return context.Receitas.Find(id);
            }
        }

        public void Atualizar(Receita receita)
        {

            using (var context = new EFContext())
            {
                context.Entry(receita).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}

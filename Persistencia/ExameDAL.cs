using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class ExameDAL
    {
        private EFContext context;
        public IList<Exame> TodosOsExames()
        {
            using (var context = new EFContext())
            {
                return context.Exames.ToList<Exame>();
            }
        }


        public void Gravar(Exame exame)
        {
            using (var context = new EFContext())
            {
                context.Exames.Add(exame);
                context.SaveChanges();
            }
        }

        public void Excluir(long id)
        {
            using (var context = new EFContext())
            {
                var exame = context.Exames.Single(d => d.ExameID == id);
                context.Exames.Remove(exame);
                context.SaveChanges();
            }
        }

        public Exame ObterID(long id)
        {
            using (var context = new EFContext())
            {
                return context.Exames.Find(id);
            }
        }


        public void Atualizar(Exame exame)
        {

            using (var context = new EFContext())
            {
                context.Entry(exame).State = EntityState.Modified;
                context.SaveChanges();
            }

        }

        public List<Exame> BuscarSituacao(string status)
        {
            using (var context = new EFContext())
            {
                return context.Exames.Where<Exame>(exame => exame.Situacao == status).ToList<Exame>();
            }
        }

        public List<Exame> BuscarCliente(string nome)
        {
            using (var context = new EFContext())
            {
                return context.Exames.Where<Exame>(exame => exame.Cliente == nome).ToList<Exame>();
            }
        }

        public List<Exame> BuscarPorData(DateTime inicio, DateTime termino)
        {
            using (var context = new EFContext())
            {
                return context.Exames.Where<Exame>(exame => exame.Data.Date >= inicio.Date && exame.Data.Date <= termino.Date).ToList<Exame>();
            }
        }
    }
}

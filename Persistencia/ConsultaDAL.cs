using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
   public class ConsultaDAL
    {
        private EFContext context;
        public IList<Consulta> TodasAsConsultas()
        {
            using (var context = new EFContext())
            {
                return context.Consultas.ToList<Consulta>();
            }
        }


        public void Gravar(Consulta consulta)
        {
            using (var context = new EFContext())
            {
                context.Consultas.Add(consulta);
                context.SaveChanges();
            }
        }

        public void Excluir(Consulta consulta)
        {
            using (var context = new EFContext())
            {
                context.Consultas.Remove(consulta);
                context.SaveChanges();
            }
        }

        public Consulta ObterID(long id)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Find(id);
            }
        }

        public List<Consulta> BuscarVet(string nome)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Where<Consulta>(consulta => consulta.Veterinario == nome).ToList<Consulta>();
            }
        }

        public List<Consulta> BuscarCliente(string nome)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Where<Consulta>(consulta => consulta.Cliente == nome).ToList<Consulta>();
            }
        }

        public List<Consulta> BuscarPet(string nome)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Where<Consulta>(consulta => consulta.Pet == nome).ToList<Consulta>();
            }
        }

        public void Atualizar(Consulta consulta)
        {

            using (var context = new EFContext())
            {
                context.Entry(consulta).State = EntityState.Modified;
                context.SaveChanges();
            }

        }

        public List<Consulta> BuscarSituacao(string status)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Where<Consulta>(consulta => consulta.Situacao == status).ToList<Consulta>();
            }
        }

        public List<Consulta> BuscarPorData(DateTime inicio, DateTime termino)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Where<Consulta>(consulta => consulta.Data.Date >= inicio.Date && consulta.Data.Date <= termino.Date).ToList<Consulta>();
            }
        }


    }
}

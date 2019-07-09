using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class VeterinarioDAL
    {
        private EFContext context;
        public IList<Veterinario> TodosOsVeterinarios()
        {
            using (var context = new EFContext())
            {
                return context.Veterinarios.ToList<Veterinario>();
            }
        }


        public void Gravar(Veterinario veterinario)
        {
            using (var context = new EFContext())
            {
                context.Veterinarios.Add(veterinario);
                context.SaveChanges();
            }
        }

        public void Excluir(long id)
        {
            using (var context = new EFContext())
            {
                var vet = context.Veterinarios.Single(d => d.VeterinarioID == id);
                context.Veterinarios.Remove(vet);
                context.SaveChanges();
            }
        }

        public Veterinario ObterID(long id)
        {
            using (var context = new EFContext())
            {
                return context.Veterinarios.Find(id);
            }
        }

        public List<Veterinario> Buscar(string nome)
        {
            using (var context = new EFContext())
            {
                return context.Veterinarios.Where<Veterinario>(veterinario => veterinario.Nome == nome).ToList<Veterinario>();
            }
        }

        public void Atualizar(Veterinario veterinario)
        {

            using (var context = new EFContext())
            {
                context.Entry(veterinario).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}

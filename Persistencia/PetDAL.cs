using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
   public class PetDAL
    {
        private EFContext context;
        public IList<Pet> TodosOsPets()
        {
            using (var context = new EFContext())
            {
                return context.Pets.ToList<Pet>();
            }
        }


        public void Gravar(Pet pet)
        {
            using (var context = new EFContext())
            {
                context.Pets.Add(pet);
                context.SaveChanges();
            }
        }

        public void Excluir(long id)
        {
            using (var context = new EFContext())
            {
                var pet = context.Pets.Single(d => d.PetID == id);
                context.Pets.Remove(pet);
                context.SaveChanges();
            }
        }

        public Pet ObterID(long id)
        {
            using (var context = new EFContext())
            {
                return context.Pets.Find(id);
            }
        }


        public List<Pet> Buscar(string nome)
        {
            using (var context = new EFContext())
            {
                return context.Pets.Where<Pet>(pet => pet.Nome == nome).ToList<Pet>();
            }
        }

        
        public void Atualizar(Pet pet)
        {

            using (var context = new EFContext())
            {
                context.Entry(pet).State = EntityState.Modified;
                context.SaveChanges();
            }

        }

    }
}

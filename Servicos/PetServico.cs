using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;

namespace Servico
{
   public class PetServico
    {
        private PetDAL petDAL = new PetDAL();

        public IList<Pet> TodosOsPets()
        {
            return petDAL.TodosOsPets();
        }

        public void Gravar(Pet pet)
        {
            petDAL.Gravar(pet);
        }

        public void Excluir(long id)
        {
            petDAL.Excluir(id);
        }

        public List<Pet> Buscar(string nome)
        {
            List<Pet> pets = petDAL.Buscar(nome);
            return pets;
        }




        public void Atualizar(Pet pet)
        {
            petDAL.Atualizar(pet);
        }
    }
}

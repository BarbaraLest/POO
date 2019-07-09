using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;

namespace Servico
{
    public class VeterinarioServico
    {
        private VeterinarioDAL veterinarioDAL = new VeterinarioDAL();

        public IList<Veterinario> TodosOsVeterinarios()
        {
            return veterinarioDAL.TodosOsVeterinarios();
        }

        public void Gravar(Veterinario veterinario)
        {
            veterinarioDAL.Gravar(veterinario);
        }

        public void Excluir(long id)
        {
            veterinarioDAL.Excluir(id);
        }

        public Veterinario ObterID(long id)
        {
            return veterinarioDAL.ObterID(id);
        }

        public List<Veterinario> Buscar(string nome)
        {
            List<Veterinario> veterinarios = veterinarioDAL.Buscar(nome);
            return veterinarios;
        }

        public void Atualizar(Veterinario veterinario)
        {
            veterinarioDAL.Atualizar(veterinario);
        }


    }
}

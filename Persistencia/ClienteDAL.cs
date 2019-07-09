using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class ClienteDAL
    {
        private EFContext context;
        public IList<Cliente> TodosOsClientes()
        {
            using (var context = new EFContext())
            {
                return context.Clientes.ToList<Cliente>();
            }
        }


        public void Gravar(Cliente cliente)
        {
            using (var context = new EFContext())
            {

                if(cliente.ClienteID > 0)
                {
                    context.Entry(cliente).State = EntityState.Modified;
                }

                else
                {
                    context.Clientes.Add(cliente);
                    context.SaveChanges();
                }
               
            }
        }

        public void Excluir(long id)
        {
            using (var context = new EFContext())
            {
                var cliente = context.Clientes.Single(d => d.ClienteID == id);
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
        }

        public Cliente ObterID(long id)
        {
            using (var context = new EFContext())
            {
                var cliente = context.Clientes.Single(c => c.ClienteID == id);
                //context.Entry(cliente).Reference(c => c.Pet).Load();
                return cliente;
            }
        }

        public List<Cliente> Buscar(string nome)
        {
            using (var context = new EFContext())
            {
                return context.Clientes.Where<Cliente>(cliente => cliente.Nome == nome).ToList<Cliente>();
            }
        }


        public void Atualizar(Cliente cliente)
        {

            using (var context = new EFContext())
            {
                context.Entry(cliente).State = EntityState.Modified;
                context.SaveChanges();
            }

        }


    }
}

using System;
using Modelo;
using Persistencia;
using System.Collections.Generic;
using System.Linq;


namespace Servico
{
    public class ClienteServico
    {
        private ClienteDAL clienteDAL = new ClienteDAL();

       

        public IList<Cliente> TodosOsClientes()
        {
            return clienteDAL.TodosOsClientes();
        }

        public void Gravar(Cliente cliente)
        {
            clienteDAL.Gravar(cliente);
        }

        public void Excluir(long id)
        {
            clienteDAL.Excluir(id);
        }

        public Cliente ObterID(long id)
        {
            return clienteDAL.ObterID(id);
        }

        public List<Cliente> Buscar(string nome)
        {
            List<Cliente> clientes = clienteDAL.Buscar(nome);
            return clientes;
        }

        public void Atualizar(Cliente cliente)
        {
            clienteDAL.Atualizar(cliente);
        }

    }
}

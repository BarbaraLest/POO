using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;

namespace Servico
{
    public class ExameServico
    {
        private ExameDAL exameDAL = new ExameDAL();

        public IList<Exame> TodosOsExames()
        {
            return exameDAL.TodosOsExames();
        }

        public void Gravar(Exame exame)
        {
            exameDAL.Gravar(exame);
        }

        public void Excluir(long id)
        {
            exameDAL.Excluir(id);
        }

        public Exame ObterID(long id)
        {
            return exameDAL.ObterID(id);
        }

        public void Atualizar(Exame exame)
        {
            exameDAL.Atualizar(exame);
        }

        public List<Exame> Situacao(string status)
        {
            List<Exame> exames = exameDAL.BuscarSituacao(status);
            return exames;
        }

        public List<Exame> BuscarCliente(string nome)
        {
            List<Exame> clientes = exameDAL.BuscarCliente(nome);
            return clientes;
        }

        public List<Exame> BuscarPorData(DateTime inicio, DateTime termino)
        {
            List<Exame> exames = exameDAL.BuscarPorData(inicio, termino);
            return exames;
        }

    }
}

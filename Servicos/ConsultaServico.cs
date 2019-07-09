using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;

namespace Servico
{
    public class ConsultaServico
    {
        private ConsultaDAL consultaDAL = new ConsultaDAL();

        public IList<Consulta> TodasAsConsultas()
        {
            return consultaDAL.TodasAsConsultas();
        }

        public void Gravar(Consulta consulta)
        {
            consultaDAL.Gravar(consulta);
        }

        public void Excluir(Consulta consulta)
        {
            consultaDAL.Excluir(consulta);
        }

        public Consulta ObterID(long id)
        {
            return consultaDAL.ObterID(id);
        }

        public List<Consulta> BuscarVet(string nome)
        {
            List<Consulta> veterinarios = consultaDAL.BuscarVet(nome);
            return veterinarios;
        }

        public List<Consulta> BuscarCliente(string nome)
        {
            List<Consulta> clientes = consultaDAL.BuscarCliente(nome);
            return clientes;
        }

        public List<Consulta> BuscarPet(string nome)
        {
            List<Consulta> pets = consultaDAL.BuscarPet(nome);
            return pets;
        }

        public void Atualizar(Consulta consulta)
        {
            consultaDAL.Atualizar(consulta);
        }

        public List<Consulta> Situacao(string status)
        {
            List<Consulta> consultas = consultaDAL.BuscarSituacao(status);
            return consultas;
        }
        public List<Consulta> BuscarPorData(DateTime inicio, DateTime termino)
        {
            List<Consulta> consultas = consultaDAL.BuscarPorData(inicio, termino);
            return consultas;
        }



    }
}

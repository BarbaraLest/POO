using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;


namespace Servico
{
    public class ReceitaServico
    {
        private ReceitaDAL receitaDAL = new ReceitaDAL();

        public IList<Receita> TodasAsReceitas()
        {
            return receitaDAL.TodasAsReceitas();
        }

        public void Gravar(Receita receita)
        {
            receitaDAL.Gravar(receita);
        }

        public void Excluir(Receita receita)
        {
            receitaDAL.Excluir(receita);
        }

        public Receita ObterID(long id)
        {
            return receitaDAL.ObterID(id);
        }

        public void Atualizar(Receita receita)
        {
            receitaDAL.Atualizar(receita);
        }
    }
}

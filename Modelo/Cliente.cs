using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Cliente
    {

        public long ClienteID { get; set; }
        public string Nome { get; set; }
       public string Cpf{ get; set; }
       public string Endereco { get; set; }
       public string Bairro { get; set; }
       public string Cidade { get; set; }
       public string Uf { get; set; }
       public int Numero { get; set; }
       public string Telefone1 { get; set; }
       public string Telefone2 { get; set; }
       public string Email { get; set; }
       public virtual List<Pet> Pets { get; set; }
    }
}

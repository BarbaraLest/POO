using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Receita
    {
        public long ReceitaID { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Veterinario { get; set; }
        public string Pet { get; set; }
        public string Cliente { get; set; }
       

    }
}

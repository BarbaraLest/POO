using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
  public class Exame
    {
        public long ExameID { get; set; }
        public DateTime Data { get; set; }
        public string Horario { get; set; }
        
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public string  Veterinario { get; set; }
        public string Pet { get; set;}
        public string Cliente { get; set; }
        public string Situacao { get; set; }
        public double Valor { get; set; }
        public DateTime Pagamento { get; set; }
        public DateTime VencimentoPagamento { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Consulta
    {
        public long ConsultaID { get; set; }
        public string Pet { get; set; }
        public string Veterinario { get; set; }
        public string Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public string Observacoes { get; set; }
        public string Situacao { get; set; }
        public double Valor { get; set; }
        public DateTime Pagamento { get; set; }
        public DateTime VencimentoPagamento { get; set; }
        public virtual List<Exame> Exames{ get; set; }
        
    }
}

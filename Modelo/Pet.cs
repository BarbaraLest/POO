using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Pet
    {
        public long PetID { get; set; }
        public string Nome { get; set; }
        public string ClienteCpf { get; set; }
        public int Idade { get; set; }
         public string Tipo { get; set; }
        public string Raça { get; set; }
        public string Cor { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Observacoes { get; set; }
        public virtual List<Consulta> Consultas { get; set; }
    }
}

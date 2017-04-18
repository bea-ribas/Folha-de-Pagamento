using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.Model
{
    class Folha
    {
        public int Folha { get; set; }
        public double Salario { get; set; }
        public double Inss { get; set;
        public double ImpostoDeRenda{ get;set;}
        public double Fgts {get; set;}
        
        public Folha ()
        {
            Folha Folha = new Folha();
            Salario salario = new Salario();
            Inss inss = new Inss();
            ImpostoDeRenda imposto = new ImpostoDeRenda();
            Fgts fgts = new Fgts();
        }
    }
}

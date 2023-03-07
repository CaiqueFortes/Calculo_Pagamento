using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Pagamento
{
    public class Funcionario
    {
        public string CPF { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public double Valor { get; set; }
        public double Horas { get; set; }
        public double Salario { get; private set; }


        public void CalcularSalario()
        {
            Salario = Valor * Horas;
        }
    }
}

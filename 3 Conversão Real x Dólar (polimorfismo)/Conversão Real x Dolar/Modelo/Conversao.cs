using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_Real_x_Dolar.Modelo
{
    public class Conversao: absPropriedades
    {
        public Conversao(Double numeroReal, Double numeroDolar): base (numeroReal, numeroDolar)
        {
            Executar();
        }

        public override void Executar()
        {
            this.resposta = "O valor convertido em dólar é de: \n" + (numeroReal/numeroDolar).ToString("0.##");
        }
    }
}

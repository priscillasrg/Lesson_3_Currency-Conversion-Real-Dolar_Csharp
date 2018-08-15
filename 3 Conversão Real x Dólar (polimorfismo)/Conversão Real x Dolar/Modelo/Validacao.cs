using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_Real_x_Dolar.Modelo
{
    public class Validacao: absPropriedades
    {
        public Validacao (String real, String dolar): base (real, dolar)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";

            try
            {
                this.numeroReal = Convert.ToDouble(this.real);
                this.numeroDolar = Convert.ToDouble(this.dolar);
            }
            catch (FormatException e)
            {
                this.mensagem = "Erro de conversão";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_Real_x_Dolar.Modelo
{
    public class Controle: absPropriedades
    {
        public Controle(String real, String dolar): base (real, dolar)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";
            absPropriedades validacao = new Validacao(this.real, this.dolar);

            if (validacao.mensagem.Equals(""))
            {
                absPropriedades conversao = new Conversao(validacao.numeroReal, validacao.numeroDolar);
                this.resposta = conversao.ToString();  
            }
            else
            {
                this.mensagem = validacao.mensagem;  
            }
        }
    }
}

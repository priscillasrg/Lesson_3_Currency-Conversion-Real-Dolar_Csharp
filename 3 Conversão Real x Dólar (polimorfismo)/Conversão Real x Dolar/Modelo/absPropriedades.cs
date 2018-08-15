using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_Real_x_Dolar.Modelo
{
    public abstract class absPropriedades: intMetodos
    {
        public String mensagem;
        protected String resposta;
        protected String real;
        protected String dolar;
        public Double numeroReal;
        public Double numeroDolar;

        public absPropriedades(String real, String dolar)
        {
            this.real = real;
            this.dolar = dolar;
        }
        public absPropriedades(Double numeroReal, Double numeroDolar)
        {
            this.numeroReal = numeroReal;
            this.numeroDolar = numeroDolar;
        }

        public virtual void Executar ()
        {
        }

        public override string ToString()
        {
            return this.resposta;
        }
        
    }
}

using System.Diagnostics.Contracts;
using System.Dynamic;

namespace Controle_Clientes {
    public class Clientes {
        public string nome {get; set;}

        public string endereco {get; set; }

        public float valor {get; protected set; }

        public float valorImposto {get; protected set; }

        public float total {get; protected set; }

        public virtual void Pagar_Imposto(float v) {
            valor = v;
            valorImposto = valor * 10/100;
            total = valor + valorImposto;
        }

    }
}
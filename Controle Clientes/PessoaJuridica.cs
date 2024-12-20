namespace Controle_Clientes {

    public class PessoaJuridica : Clientes {

        public string cnpj {get; set;}

        public string ie {get; set;}

        public override void Pagar_Imposto(float v)
        {
            valor = v;
            valorImposto = valor * 20/100;
            total = valor + valorImposto;
        }
    }
}
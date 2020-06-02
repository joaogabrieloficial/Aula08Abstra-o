using System;

namespace Aula8Abstração
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento {get; set;}
        public string bancoEmissor { get; set; }
        public string codigoDeBarras { get; set; }

        public string RegistrarNoSisitema(){
            return "Boleto registrado com sucesso";
        }
    }
}
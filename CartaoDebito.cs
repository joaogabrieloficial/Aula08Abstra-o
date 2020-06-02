namespace Aula8Abstração
{
    public class CartaoDebito : Cartao
    {
        public float  saldo { get; set; }

            public string Transferir(float valor){
                return $"R$ {valor} tranferido de sua conta";
            }

            public string PagarTitulo(){
                return "Título pago com cartão de débito";
            }

    }
}
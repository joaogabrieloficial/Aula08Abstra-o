namespace Aula8Abstração
{
    public class Cartao : Pagamento
    {
        private string token ="878huj8y7h7y7yhg7hgse3";
        public string titular { get; set; }
        public string numero { get; set; }
        public string  bandeira { get; set; }
        public string cvv { get; set; }

        public bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
    }
}
using System ;

namespace Aula8Abstração
{
    public class Pagamento
    {
     public DateTime data {get; set;}
     public float valor {get; set;}

     public string pagar(){
         return "Pagamento efetuado";

     }
     public string CancelarPagamento(){
         return "Pagamento cancelado";
     }
    }
}
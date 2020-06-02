namespace Aula8Abstração
{
    public class CartaoCredito : Pagamento
    {
    public float limite { get; set; }
    
    public float AumentarLimite(float limiteatual,float acrescimo ){
        return limiteatual + acrescimo;
    }
    public string BloquearCartaoDeCredito(){
        return "Cartão de crédito bloqueado";
    }
    }
}
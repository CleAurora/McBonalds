using System;
namespace McBonalds.Models
{
    public class Pedido
    {
        public ulong Id {get; set;}//ulong int maior
        public Cliente Cliente {get; set;} // não ocnfundir tipo cliente com nome da variável cliente
        public Hamburguer Hamburguer {get; set;}
        public Shake Shake {get; set;}
        public DateTime DataPedido {get; set;}
        

    }
}
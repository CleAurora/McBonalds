using System;
using System.IO;
using McBonalds.Models;

namespace McBonalds.Repositorios
{
    public class PedidoRepositorio
    {
        public bool Inserir(Pedido pedido)
        {
            try{
                if(!File.Exists("Database/Pedido.csv")){//se o arquivo não existe
                File.Create("Database/Pedido.csv").Close(); // criando o arquivo de uma amneira diferente, e nessa pasta, com esse nome
                }

                var registro = $"{pedido.Id}; {pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone}; {pedido.Cliente.Email}; {pedido.Hamburguer.Nome}; {pedido.Shake.Nome}; {pedido.DataPedido}\n";// Grava no arquivo - não colocar o else, para que o primeiro preenchimento também seja gravado - boa prática ao invés de repetir o caso; pedido.Cliente.Nome = agregação ou composição: quando você tem uma classe dentro da outra.
                
                File.AppendAllText("Database/Pedido.csv", registro);
            } catch(Exception e)
            {
                System.Console.WriteLine("Chegou no catch!");
                System.Console.WriteLine(e.StackTrace);
            }
            

            return true;

        }//fim inserir
    }
}
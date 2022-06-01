using AulasPCDev.Respository;
using System;
using System.Collections.Generic;
using System.Text;
 
namespace AulasPCDev.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public Item()
        {
            // o código tem que ser único
            // incremento: adição em um item
            // olhar a minha biblioteca
            // pegar a quantidade de itens
            // fazer um incremento na quantidade de itens
                                 //da minha biblioteca

            List<Item> itens = Armazenamento.Biblioteca;
            int quantidadeDeItens = itens.Count;
            Id = quantidadeDeItens++; // quantidade + 1
        }
    }
}

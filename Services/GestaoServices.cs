using AulasPCDev.Models;
using AulasPCDev.Respository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulasPCDev.Services
{
    public class GestaoServices
    {
        private List<Item> _biblioteca = Armazenamento.Biblioteca;
        public void Cadastrar()
        {
            Console.WriteLine("O que deseja cadastrar?");
            Console.WriteLine("1 - Filme");
            Console.WriteLine("2 - Série");
            Console.WriteLine("Qualquer outro número para voltar");

            int respotas = int.Parse(Console.ReadLine());
            if (respotas == 1)
            {
                CadastrarFilme();
            }
            if (respotas == 2)
            {
                CadastrarSerie();
            }
        }

        public void CadastrarFilme()
        {
            Filme filme = new Filme();

            Console.WriteLine("Qual o nome do filme que deseja cadastrar?");
            filme.Titulo = Console.ReadLine();

            Console.WriteLine("Quantos fitas deste filme existem?");
            filme.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da locação deste filme?");
            filme.Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a duração do filme?");
            filme.Duracao = int.Parse(Console.ReadLine());

            _biblioteca.Add(filme);
        }

        public void CadastrarSerie()
        {
            Serie serie = new Serie();

            Console.WriteLine("Qual o nome da série que deseja cadastrar?");
            serie.Titulo = Console.ReadLine();

            Console.WriteLine("Quantos cópias desta série existem?");
            serie.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da locação deste séries?");
            serie.Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas temporadas tem esta série?");
            serie.Temporadas = int.Parse(Console.ReadLine());

            _biblioteca.Add(serie);
        }

        public void Listar()
        {
            Console.WriteLine("O que deseja listar?");
            Console.WriteLine("1 - Filme");
            Console.WriteLine("2 - Série");
            Console.WriteLine("Qualquer outro número para voltar");

            int respotas = int.Parse(Console.ReadLine());
            if (respotas == 1)
            {
                ListarFilmes();
            }
            if (respotas == 2)
            {
                ListarSeries();
            }
        }


        private static List<Filme> _listaFilmes = Armazenamento.Filmes;
        public void ListarFilmes()
        {
            Console.WriteLine("TITULO - QUANTIDADE - VALOR");
            foreach (Filme filme in _listaFilmes)
            {
                Console.WriteLine($"{filme.Titulo} - {filme.Quantidade} - {filme.Valor}");
            }

        }
        private static List<Serie> _listaSeries = Armazenamento.Series;
        public void ListarSeries()
        {
            Console.WriteLine("TITULO - QUANTIDADE - VALOR");
            foreach (Serie serie in _listaSeries)
            {
                Console.WriteLine($"{serie.Titulo} - {serie.Quantidade} - {serie.Valor}");
            }

        }
    }
}

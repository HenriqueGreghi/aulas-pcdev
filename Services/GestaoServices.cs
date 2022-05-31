using AulasPCDev.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulasPCDev.Services
{
    public class GestaoServices
    {
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

        }

        public void CadastrarSerie()
        {

        }
    }
}

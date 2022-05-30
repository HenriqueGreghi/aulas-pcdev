using System;
using System.Collections.Generic;
using System.Text;

namespace AulasPCDev.Models
{
    internal class Usuario
    {
        private readonly static int IDADE_MAIORIDADE = 18;
        public Usuario(int idade)
        {
            if (idade >= IDADE_MAIORIDADE)
            {
                Idade = idade;
                Conta = new Conta(50);
            }
            else
            {
                throw new Exception();
            }
        }

        public int Idade;

        public string Nome;

        public Conta Conta;

    }
}

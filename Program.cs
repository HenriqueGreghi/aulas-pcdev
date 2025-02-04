﻿using AulasPCDev.Models;
using AulasPCDev.Services;
using System;
using System.Collections.Generic;

namespace AulasPCDev
{
    public class Program
    {
        private static UsuarioServices _usuarioServices = new UsuarioServices();
        private static GestaoServices _gestaoItens = new GestaoServices();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a locadora de vídeos");

            bool continuar = true;
            do
            {
                Console.WriteLine("Digite o número da sua opção:");
                Console.WriteLine("1 - Cadastrar usuários");
                Console.WriteLine("2 - Listar usuários");
                Console.WriteLine("3 - Cadastrar filme/série");
                Console.WriteLine("4 - Listar filme/série");
                Console.WriteLine("5 - Alugar filme/série");
                Console.WriteLine("6 - Devolver filme/série");
                Console.WriteLine("Qualquer outro número para sair");

                int resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        _usuarioServices.CadastrarUsuario();
                        break;
                    case 2:
                        _usuarioServices.ListarUsuarios();
                        break;
                    case 3:
                        _gestaoItens.Cadastrar();
                        break;
                    case 4:
                        _gestaoItens.Listar();
                        break;
                    default:
                        continuar = false;
                        break;
                }
            }while(continuar);
            
        }
    }
}

using AulasPCDev.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulasPCDev.Respository
{
    public class Armazenamento
    {
        public static List<Usuario> Usuarios = 
            new List<Usuario>();

        public static List<Item> Biblioteca = 
            new List<Item>();
        
        public static List<Filme> Filmes =
            new List<Filme>();

        public static List<Serie> Series =
            new List<Serie>();
    }
   
}

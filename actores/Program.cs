using System;
using System.Collections.Generic;
 
namespace actores
{
    class actores
    {
        private string nombre;
        public actores(string n)
        {
            nombre = n;
        }
        public void imprime()
        {
            Console.WriteLine(nombre);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<actores> Actor = new List<actores>();
            Actor.Add(new actores("Daniel Day-Lewis"));
            Actor.Add(new actores("Jack Nicholson"));
            Actor.Add(new actores("Gary Cooper"));
            Actor.Add(new actores("Tom Hanks "));
 
            foreach(actores a in Actor)
            {
                a.imprime();
            }
            
        }
    }
}
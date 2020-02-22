using System;

namespace peliculas
{
    class peliculas
    {
        private string titulo;
        private int año;
        private string pais;
        private string director;

        public string gettitulo()
        {
           return titulo;
        }
          public int getaño()
        {
            return año;
        }
          public string getpais()
        {
            return pais;
        }
          public string getdirector()
        {
            return director;
        }
        public void settitulo(string titulo)
        {
            this.titulo=titulo;
        }
          public void setaño(int año)
        {
            this.año=año;
        }
          public void setpais(string pais)
        {
            this.pais=pais;
        }
          public void setdirector(string director)
        {
          this.director=director;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           peliculas obj1 = new peliculas();
           obj1.settitulo("Parasite");
           obj1.setaño(2019);
           obj1.setpais("Corea del Sur");
           obj1.setdirector("Han Jin-Won");
           Console.WriteLine("titulo: {0}",obj1.gettitulo());
           Console.WriteLine("año: {0}",obj1.getaño());
           Console.WriteLine("pais: {0}",obj1.getpais());
           Console.WriteLine("director: {0}",obj1.getdirector());
           Console.WriteLine("");
            peliculas obj2 = new peliculas();
           obj2.settitulo("Green Book");
           obj2.setaño(2018);
           obj2.setpais("Estados Unidos");
           obj2.setdirector("Peter Farrelly");
           Console.WriteLine("titulo: {0}",obj2.gettitulo());
           Console.WriteLine("año: {0}",obj2.getaño());
           Console.WriteLine("pais: {0}",obj2.getpais());
           Console.WriteLine("director: {0}",obj2.getdirector());
        }
    }
}

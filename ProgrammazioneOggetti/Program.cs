using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            //andiamo a rappresentare modo esterno in classi ed oggetti
            //classe come uno stampino, lo creiamo una soola volta e creiamo oggetto che è una rappresentazione della classe
            //COSTRUTTORE
            Persona persona1 = new Persona("Angelo", "Dalo", 23); //persona1 è un nuovo oggetto
            //SENZA COSTRUTTORE
            //persona1.nome = "Angelo";
            //persona1.cognome = "dalo";
            //persona1.eta = 23;
            //Console.WriteLine(persona1.nome);
            //persona1.Saluta();
            
            //OVERLOAD COSTRUCTOR
            Persona persona2 = new Persona("Dalo2", 24);
        }
    }

    class Persona
    {
        public string nome; //proprietà
        public string cognome;
        public int eta;

        //COSTRUTTORE
        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta ;
        }

        //OVERLOAD COSTRUCTOR
        public Persona(string cognome, int eta)
        {
            this.cognome = cognome;
            this.eta = eta;
        }
        public void Saluta()
        {
            Console.WriteLine($"ciao sono {nome}");
            Console.WriteLine($"ciao sono {this.nome}"); //se metto string nome dentro saluta da problemi quello di sopra
                                                         //perchè prende le variabili nella parentesi
                                                         //con this prendo il vero nome
        }
    }
}

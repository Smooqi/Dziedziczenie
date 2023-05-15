using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    
    public class Figura
    {
        protected float bok1;

        protected float bok2;

        public Figura(float bok1, float bok2) // konstruktor klasy Figura
        {
            this.bok1 = bok1; 
            this.bok2 = bok2;    
        }
        
        public virtual void Pole()  // metoda wirtualna ktora bedzie napisywana
        {                           // w przpadku podania parametru w wierszu polecen podczas uruchominia
            Console.WriteLine("Nie stworzono figury");
        } 
    }

    public class Kwadrat : Figura // klasa Kwadrat dziedziczy po klasie Figura
    {
      
        public Kwadrat(float bok1, float bok2) : base(bok1 , bok2) { }
        // konstruktor na bazie konstruktora klasy rodzica
      
        public override void Pole() // nadpisanie metody w przpadku gdy wywolana bedzie firgura Kwadrat
        {
            Console.WriteLine($"Pole kwadratu: {bok1 * bok2}"); 
        }
     }

    public class Trojkat : Figura
    {
        public Trojkat(float bok1, float bok2) : base(bok1, bok2) { }
        // konstruktor na bazie konstruktora klasy rodzica

        public override void Pole() // nadpisanie metody w przpadku gdy wywolana bedzie firgura trojkat
        {
            Console.WriteLine($"Pole trójkąta: {(bok1 * bok2) / 2}");
        }

    } 

    internal class Program
    {
        static void Main(string[] args)
        {
            Figura f = new Figura(4, 4); // instancja rodzica
            Kwadrat k = new Kwadrat(4, 4); // instancja dziecka kwadrat
            Trojkat t = new Trojkat(4, 4); // instancja dziecka trojkat


            if (args.Length > 0) // jesli wprowadzona parametr w cmd podczas uruchomienia
            {
                switch (args[0])
                {
                    case "/f":
                        f.Pole();
                        break;
                    case "/k":
                        k.Pole();
                        break;
                    case "/t":
                        t.Pole();
                        break;
                    default:
                        Console.WriteLine("Podano nieprawidłowy parametr");
                        break;
                }
            }
            else 
                Console.WriteLine("Nie podano parametru");
            Console.ReadLine();
        }
    }
}

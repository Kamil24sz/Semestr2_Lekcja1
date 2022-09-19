using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr2_Lekcja1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //pkt.3
            Console.WriteLine("Witam, to jest mój program konsolowy" +
                " Kamil");

            //pkt.4
            String ulubionaPotrawa = "Lasagne";
            int wiek = 22;
            decimal kieszonkowe = 12.50m;
            char rozmiar = 'M';
            bool czyEkstraRozmiar = false;

            //pkt.5
            Console.WriteLine("Mam " + wiek + " lat");
            Console.WriteLine("Lubię jeść {0}", ulubionaPotrawa);

            //pkt.6
            for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine( i +" Jestem głodny");
            }

            //pkt.7
            Console.WriteLine("Ile kosztuje " + ulubionaPotrawa + "?");
            decimal cenaPotrawy = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Cena potrawy to: " + cenaPotrawy);

            //pkt.8
            int porcje = 0;
            if(kieszonkowe > cenaPotrawy)
            {
                porcje = (int)(kieszonkowe / cenaPotrawy);
                Console.WriteLine("Możesz kupić " + porcje +
                    " porcji " + ulubionaPotrawa);
            }
            else
            {
                Console.WriteLine("Brak kieszonkowych na "
                    + ulubionaPotrawa);
            }
            //pkt. 10
            Console.WriteLine(ZmienRozmiar(rozmiar));

            //pkt. 12
            Console.WriteLine(ZamienRozmiarExtra(rozmiar,czyEkstraRozmiar));

            Console.ReadLine();




        }
        //pkt. 9
        public static string ZmienRozmiar(char rozmiar)
        {
            if (rozmiar == 'S')
                return "Small";

            if (rozmiar == 'M')
                return "Medium";

            if(rozmiar == 'L')
                return "Large";

            return "Nieodpowiednie oznaczenie";
        }

        //pkt. 11
        public static string ZamienRozmiarExtra(char rozmiar, bool czyEkstraRozmiar)
        {
            if (rozmiar == 'S')
            {
                if (czyEkstraRozmiar)
                    return "Extra Small";
                else
                    return "Small";
            }
                

            if (rozmiar == 'M')
                return "Medium";

            if (rozmiar == 'L')
            {
                if (czyEkstraRozmiar)
                    return "Extra Large";
                else
                    return "Large";
            }
                

            return "Nieodpowiednie oznaczenie";
        }
    }
}

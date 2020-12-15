using System;
using System.Collections.Generic;

namespace Avanade.Cloud
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("La Connection String è:");
            string connectionString = Metodi.GetConnectionString();
            Console.WriteLine(connectionString);


            Console.WriteLine("##################");
            Console.WriteLine("CREO LA NUOVA TABELLA NEL DB SPECIFICATO");
            Metodi.CreaTabella(connectionString);

            Console.WriteLine("##################");
            Console.WriteLine("INSERISCO UN NUOVO PRODOTTO NELLA TABELLA");
            Metodi.InserisciProdotto(connectionString);

            Console.WriteLine("###################");
            Console.WriteLine("INSERIAMO UN SECONDO PRODOTTO");
            Metodi.InserisciProdotto(connectionString);

            Console.WriteLine("###################");
            Console.WriteLine("Salvo i prodotti in una lista e la stampo ora: ");
            List<Products> listap = Metodi.SalvaProdotti(connectionString);
            Metodi.StampaProdottiInLista(listap);
            

            Console.WriteLine("###################");
            Console.WriteLine("Questi sono tutti i prodotti nel DB: ");
            Metodi.StampaProdotti(connectionString);
        }
    }
}

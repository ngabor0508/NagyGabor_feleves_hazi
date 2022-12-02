using System;
using System.IO;

namespace NagyGabor_feleves_hazi
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("jatekosok.txt");
            Random r = new Random();

            int jatekosSzam = int.Parse(sr.ReadLine());
            string[] jatekosok = new string[jatekosSzam];
            int[] jatekosEletkor = new int[jatekosSzam];
            string[] jatekosAzon = new string[jatekosSzam];
            int szamlalo = 0;

            while (!sr.EndOfStream) {
                string[] sor = sr.ReadLine().Split('|');
                jatekosok[szamlalo] = sor[0];
                jatekosEletkor[szamlalo] = int.Parse(sor[1]);
                jatekosAzon[szamlalo] = sor[2];

                szamlalo++;
            }


            string[] elsoJatek = new string[jatekosSzam/2];
            string[] valasztasok = new string[jatekosSzam / 2];
            string[] koPapirOllo = {"kő","papír","olló"};

            for (int i = 0; i < jatekosSzam / 2; i++)
            {
                int jatekosValasztas = r.Next(jatekosok.Length);        
                elsoJatek[i] = jatekosok[jatekosValasztas];
                int koPapirOlloValasztas = r.Next(koPapirOllo.Length);
                valasztasok[i] = koPapirOllo[koPapirOlloValasztas];
            }

            for (int i = 0; i < elsoJatek.Length; i++)
            {
                Console.WriteLine($"{elsoJatek[i]}: {valasztasok[i]}");
                
            }


            if (valasztasok[0] == "kő" && valasztasok[1] == "papír") {
                Console.WriteLine($"{elsoJatek[1]} nyert.");
            }
            else if(valasztasok[0] == "kő" && valasztasok[1] == "papír")
            {
            
            }
            


            //StreamReader sr3 = new StreamReader("taktikak.txt");

            //string[] taktikaAzon = new string[jatekosSzam];
            //string[] taktika = new string[jatekosSzam];


            sr.Close();
        }
    }
}

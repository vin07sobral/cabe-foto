using System;
namespace cabe_foto
{
    class Program
    {
        static void Main(string[] args)
        {
            int fotoX, fotoY, prX, prY;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            fotoX = int.Parse(vet[0]);
            fotoY = int.Parse(vet[1]);
            vet = Console.ReadLine().Split(' ');
            prX = int.Parse(vet[0]);
            prY = int.Parse(vet[1]);
            if ((fotoX <= prX && fotoY <= prY) || (fotoY <= prX && fotoX <= prY))
            {
                Console.WriteLine("SIM");
            }
            else
            {
                Console.WriteLine("NAO");
            }
            Console.ReadLine();
        }
    }
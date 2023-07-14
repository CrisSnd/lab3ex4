
using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau  de la tastatura. Scrieti functii care vor returna
                • Cel mai mare numar din vector
                • Cel mai mic numar din vector
                • Numerele divizibile cu 3
                • Numerele prime din vector
                Apelati functiile si afisati-le rezultatele.*/


            Console.WriteLine("Introduceti numarul de elemente ale vectorului:");
            int elementeVector = int.Parse(Console.ReadLine());


            int[] vector = CitesteVector(elementeVector);


            AfiseazaVectorul(vector);


            Console.WriteLine("Cel mai mare numar din vector este: " + NumarMaximVector(vector));


            Console.WriteLine("Cel mai mic numar din vector este: " + NumarMinimVector(vector));


            NumereDivCu3(vector);


            NumerePrimeDinVector(vector);





            static int[] CitesteVector(int vector)
            {

                int[] vectorElemente = new int[vector];

                Console.WriteLine("\n" + "Introduceti elementele vectorului:");


                for (int i = 0; i < vector; i++)
                {
                    vectorElemente[i] = int.Parse(Console.ReadLine());
                }

                return vectorElemente;

            }





            static void AfiseazaVectorul(int[] elementeVector)
            {
                Console.WriteLine("\n" + "Afisare vector numere intregi:");


                for (int i = 0; i < elementeVector.Length; i++)
                {
                    Console.WriteLine(elementeVector[i]);

                }
            }





            static int NumarMaximVector(int[] elementeVector)
            {

                int valMax = elementeVector[0];

                for (int i = 0; i < elementeVector.Length; i++)
                {

                    if (elementeVector[i] > valMax)
                    {
                        valMax = elementeVector[i];

                    }

                }

                return valMax;

            }




            static int NumarMinimVector(int[] elementeVector)
            {

                int valMin = elementeVector[0];

                for (int i = 0; i < elementeVector.Length; i++)
                {

                    if (elementeVector[i] < valMin)
                    {
                        valMin = elementeVector[i];

                    }

                }
                return valMin;
            }





            static void NumereDivCu3(int[] elementeVector)
            {
                int[] numarDivCu3 = new int[elementeVector.Length];

                for (int i = 0; i < elementeVector.Length; i++)

                {

                    if (elementeVector[i] % 3 == 0)
                    {
                        numarDivCu3[i] = elementeVector[i];
                    }

                    if (numarDivCu3[i] != 0)
                    {

                        Console.WriteLine("\n" + "Numar divizibil cu 3: " + numarDivCu3[i]);
                    }

                }

            }





            static bool NumerePrimeDinVector(int[] elementeVector)
            {
                for (int i = 0; i < elementeVector.Length; i++)
                {
                    bool numarPrim = true;
                    for (int j = 2; j < elementeVector[i]; j++)

                    {
                        if ((elementeVector[i] % j == 0))
                        {
                            numarPrim = false;
                            break;
                        }

                    }

                    if (numarPrim)
                    {
                        Console.WriteLine("\n" + elementeVector[i] + "." + " Numarul este prim");
                    }
                }
                return true;
            }
        }
    }
}


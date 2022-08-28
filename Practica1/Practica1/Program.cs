using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArbolBinario<int> arbolBinarioA = new ArbolBinario<int>(1);

            ArbolBinario<int> hijoIzquierdo = new ArbolBinario<int>(2);
            hijoIzquierdo.agregarHijoIzquierdo(new ArbolBinario<int>(3));
            hijoIzquierdo.agregarHijoDerecho(new ArbolBinario<int>(4));

            ArbolBinario<int> hijoDerecho = new ArbolBinario<int>(5);
            hijoDerecho.agregarHijoIzquierdo(new ArbolBinario<int>(6));
            hijoDerecho.agregarHijoDerecho(new ArbolBinario<int>(7));

            arbolBinarioA.agregarHijoIzquierdo(hijoIzquierdo);
            arbolBinarioA.agregarHijoDerecho(hijoDerecho);

            Console.WriteLine("\t\t\t\tRepresentacion del arbol\n");

            Console.WriteLine("\t\t\t\t\t" + arbolBinarioA.getDatoRaiz());
            Console.WriteLine("\t\t\t" + arbolBinarioA.getHijoIzquierdo().getDatoRaiz() + "\t\t\t\t" + arbolBinarioA.getHijoDerecho().getDatoRaiz());
            Console.WriteLine("\t\t" + hijoIzquierdo.getHijoIzquierdo().getDatoRaiz() + "\t\t" + hijoIzquierdo.getHijoDerecho().getDatoRaiz() + "\t\t"
                              + hijoDerecho.getHijoIzquierdo().getDatoRaiz() + "\t\t" + hijoDerecho.getHijoDerecho().getDatoRaiz()+"\n\n");


            Console.Write("Preorden: ");
            arbolBinarioA.preorden();
            Console.WriteLine();
            Console.Write("Inorden: ");
            arbolBinarioA.inorden();
            Console.WriteLine();
            Console.Write("Postorden: ");
            arbolBinarioA.postorden();
            Console.WriteLine();
            //Console.Write("Por Niveles: ");
            //arbolBinarioA.recorridoPorNiveles();
            //Console.WriteLine();

            Console.ReadKey();

        }
    }
}

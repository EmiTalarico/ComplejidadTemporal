using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class ArbolBinario<T>
    {
		/*Agregue a la clase ArbolBinario el siguiente método:
		- contarHojas() #devuelve la cantidad de subárboles hojas del árbol receptor.*/

		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;


		public ArbolBinario(T dato)
		{
			this.dato = dato;
		}

		public T getDatoRaiz()
		{
			return this.dato;
		}

		public ArbolBinario<T> getHijoIzquierdo()
		{
			return this.hijoIzquierdo;
		}

		public ArbolBinario<T> getHijoDerecho()
		{
			return this.hijoDerecho;
		}

		public void agregarHijoIzquierdo(ArbolBinario<T> hijo)
		{
			this.hijoIzquierdo = hijo;
		}

		public void agregarHijoDerecho(ArbolBinario<T> hijo)
		{
			this.hijoDerecho = hijo;
		}

		public void eliminarHijoIzquierdo()
		{
			this.hijoIzquierdo = null;
		}

		public void eliminarHijoDerecho()
		{
			this.hijoDerecho = null;
		}

		public bool esHoja()
		{
			return this.hijoIzquierdo == null && this.hijoDerecho == null;
		}

		//Se procesa el hijo izquierdo, luego la raíz y último el hijo derecho
		public void inorden()
		{
            //Proceso hijo izquierdo
            if (this.hijoIzquierdo != null)
            
				this.hijoIzquierdo.inorden();
            
			//Proceso raiz
            Console.Write(this.dato + " ");
            //Proceso hijo derecho
            if (this.hijoDerecho != null)
            
				this.hijoDerecho.inorden();
            
		}

		//Se procesa primero la raíz y luego sus hijos, izquierdo y	derecho
		public void preorden()
		{
            //Proceso raiz
            Console.Write(this.dato + " ");
			//Proceso hijo izquierdo
			if (this.hijoIzquierdo != null)
			
				this.hijoIzquierdo.preorden();
			
			//Proceso hijo derecho
			if (this.hijoDerecho != null)
			
				this.hijoDerecho.preorden();

			
		}

		//Se procesan primero los hijos, izquierdo y derecho, y luego la raíz
		public void postorden()
		{
			//Proceso hijo izquierdo
			if (this.hijoIzquierdo != null)
			
				this.hijoIzquierdo.postorden();
			
			//Proceso hijo derecho
			if (this.hijoDerecho != null)
			
				this.hijoDerecho.postorden();
			
            //Proceso raiz
            Console.Write(this.dato + " ");
		}

		//Se procesan los nodos teniendo en cuenta sus niveles, primero
		//la raíz, luego los hijos, los hijos de éstos, etc.
		public void recorridoPorNiveles()
		{
			Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>();
			ArbolBinario<T> arbolAux;

			c.encolar(this);
			while (!c.esVacia())
			{
				arbolAux = c.desencolar();

				Console.Write(arbolAux.dato + " ");

				if (arbolAux.hijoIzquierdo != null)
					c.encolar(arbolAux.hijoIzquierdo);

				if (arbolAux.hijoDerecho != null)
					c.encolar(arbolAux.hijoDerecho);
			}

		}


		public int contarHojas()
		{
			Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>();
			ArbolBinario<T> arbolAux;
			int hoja = 0;

			c.encolar(this);
			while (!c.esVacia())
			{
				arbolAux = c.desencolar();


				if (arbolAux.hijoIzquierdo != null)
				{
					c.encolar(arbolAux.hijoIzquierdo);
				}
				
				if (arbolAux.hijoDerecho != null)
				{
					c.encolar(arbolAux.hijoDerecho);
				}
                else
                {
                    hoja++;
                }
				
			}

			return hoja;
		}

		public void recorridoEntreNiveles(int n, int m)
		{
		}
	}
}

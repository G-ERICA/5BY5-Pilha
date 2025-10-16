using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    internal class Pilha
    {
        public Roupa Topo { get; set; }

        public Pilha() 
        {
            this.Topo = null;
        }

        
        public bool Vazio() 
        {
            if (this.Topo == null) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public void InserirPUSH(Roupa item) 
        {
            if (Vazio()) 
            {
                this.Topo = item;
            }
            else 
            {
                item.Proximo = this.Topo;
                this.Topo = item;
            }

        }

        public void RemoverPOP() 
        {
            if (Vazio())
            {
                Console.WriteLine("Pilha vazia!");
            }
            else
            {
                this.Topo = this.Topo.Proximo;
            }
        }

        public void ImprimirPilha() 
        {
            if (Vazio())
            {
                Console.WriteLine("Pilha vazia!");
            }
            else
            {
                Roupa aux = this.Topo;
                while (aux != null)
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                }
            }

        }
    }
}

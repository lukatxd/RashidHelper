using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RashidHelper
{
    public class Item
    {
        public Item(String nome, int valor)
        {
            this.nome = nome;
            this.valor = valor;
        }

        public String nome;
        public int valor;


        public override string ToString()
        {
            return this.nome + " - " + this.valor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    internal class Roupa
    {
        public string Descricao { get; set; }
        public string Cor { get; set; }
        public Roupa Proximo { get; set; }

        public Roupa(string nome, string descricao) 
        {
            this.Descricao = nome;
            this.Cor = descricao;
            this.Proximo = null; 
        }

        public override string ToString()
        {
            return $"----------------\nPeça {this.Descricao}\nDescrição: {this.Cor}";
        }

    }
}

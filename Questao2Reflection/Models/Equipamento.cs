using Questao2Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2Reflection.Models
{
    internal class Equipamento
    {

        public int Id { get; set; }

        [Exibir]
        public string Nome { get; set; } = string.Empty;

        [Exibir]
        public string Fabricante { get; set; } = string.Empty;

        public string NumeroSerie { get; set; } = string.Empty;

        [Exibir]
        public decimal Valor { get; set; } 

        [Exibir]
        public string Localizacao { get; set; } = string.Empty;


    }
}

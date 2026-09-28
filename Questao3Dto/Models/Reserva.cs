using System;
using System.Collections.Generic;
using System.Text;

namespace Questao3Dto.Models
{
    internal class Reserva
    {

        public int Id { get; set; }
        public string NomeHospede { get; set; } = string.Empty;
        public int NumeroQuarto  { get; set; }
        public int QuantidadeDiarias { get; set; }
        public decimal ValorDiaria { get; set; }
        public string StatusInterno { get; set; } = string.Empty;
        public string ObservacaoInterna { get; set; }

        public Reserva(int id, string nomeHospede, int numeroQuarto, int QuantidadeDiarias, decimal valorDiaria, string statusInterno, string ObservacaoInterna) 
        {
            this.Id = id;
            this.NomeHospede = nomeHospede;
            this.NumeroQuarto = numeroQuarto;
            this.QuantidadeDiarias = QuantidadeDiarias;
            this.ValorDiaria = valorDiaria;
            this.StatusInterno = statusInterno;
            this.ObservacaoInterna = ObservacaoInterna;

        }
    }
}

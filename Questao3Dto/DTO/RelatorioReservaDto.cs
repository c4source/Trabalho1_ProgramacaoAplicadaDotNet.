using System;
using System.Collections.Generic;
using System.Text;

namespace Questao3Dto.DTO
{
    internal record RelatorioReservaDto
    (
        string NomeHospede,
        int NumeroQuarto,
        int QuantidadeDiarias,
        decimal ValorTotal,
        string Situacao


    );
}

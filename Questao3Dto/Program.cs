using Questao3Dto.DTO;
using Questao3Dto.Models;

internal class Program
{
    static void Main(string[] args)
    {   
        Reserva reserva1 = new Reserva(1,"Gabriel Henrique", 14, 7, 850.50m, "Disponível", "Ok");

        RelatorioReservaDto relatorioReservaDto = Mapear(reserva1);

        ExibirRelatorioDto(relatorioReservaDto);

    }

    public static RelatorioReservaDto Mapear(Reserva reserva) 
    {
        decimal ValorTotal = reserva.QuantidadeDiarias * reserva.ValorDiaria;
     

        RelatorioReservaDto relatorioDto = new RelatorioReservaDto
        (
            reserva.NomeHospede,
            reserva.NumeroQuarto,
            reserva.QuantidadeDiarias,
            ValorTotal,
            "Reserva Confirmada"


        );
            return relatorioDto;
    
    }

    public static void ExibirRelatorioDto(RelatorioReservaDto relatorio) 
    {
        Console.WriteLine($"Nome Hóspede: {relatorio.NomeHospede}");
        Console.WriteLine($"Número do quarto: {relatorio.NumeroQuarto}");
        Console.WriteLine($"Quantidade de diárias: {relatorio.QuantidadeDiarias}");
        Console.WriteLine($"Valor Total: {relatorio.ValorTotal}");
        Console.WriteLine($"Situação: {relatorio.Situacao}");
    }

}

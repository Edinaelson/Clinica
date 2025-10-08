
using Clinica.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
namespace Clinica.Services;

public class RelatorioPdfService
{
    public byte[] GerarRelatorio(List<RelatorioConsulta> relatorios, string nomeCliente, string logoPath)
    {
        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(2, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(12));

                page.Header().Column(header =>
                {
                    if (File.Exists(logoPath))
                    {
                        header.Item()
                            .Container()
                            .AlignCenter()
                            .Height(80)
                            .Width(400) // ajusta esse valor conforme o que seria 80% do A4 (~595pt)
                            .Image(logoPath, ImageScaling.FitArea);
        
                        header.Item().PaddingBottom(10); // Espaço abaixo da logo
                    }

                    header.Item().Text($"Olá, {nomeCliente}!").Bold().FontSize(16);
                    header.Item().Text("Abaixo está o resumo das suas consultas:");
                    header.Item().Text("");
                });

                page.Content().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(); // Procedimento
                        columns.ConstantColumn(80); // Preço
                        columns.ConstantColumn(100); // Data
                    });

                    table.Header(header =>
                    {
                        header.Cell().Text("Procedimento").Bold();
                        header.Cell().Text("Preço").Bold();
                        header.Cell().Text("Data").Bold();
                    });

                    foreach (var r in relatorios)
                    {
                        table.Cell().Text(r.Agendamento.Procedimento);
                        table.Cell().Text(r.Agendamento.Procedimento.Preco.ToString("C"));
                        table.Cell().Text(r.DataAgendada.ToString("dd/MM/yyyy"));
                    }
                });

                page.Footer().AlignCenter().Text("Obrigado por escolher a nossa clínica!").FontSize(10);
            });
        }).GeneratePdf();
    }
}
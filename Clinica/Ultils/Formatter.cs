using System.Linq;

namespace Clinica.Ultils;

public class Formatter
{
    public static string FormatarCpf(string? value)
    {
        if (string.IsNullOrWhiteSpace(value)) return string.Empty;

        var input = new string(value.Where(char.IsDigit).ToArray());
        input = input.Length > 11 ? input.Substring(0, 11) : input;

        return input.Length switch
        {
            >= 11 => $"{input[..3]}.{input[3..6]}.{input[6..9]}-{input[9..]}",
            >= 7  => $"{input[..3]}.{input[3..6]}.{input[6..]}",
            >= 4  => $"{input[..3]}.{input[3..]}",
            _     => input
        };
    }

    public static string FormatarTelefone(string? value)
    {
        if (string.IsNullOrWhiteSpace(value)) return string.Empty;

        var input = new string(value.Where(char.IsDigit).ToArray());
        input = input.Length > 11 ? input.Substring(0, 11) : input;

        return input.Length switch
        {
            >= 11 => $"({input[..2]}) {input[2..7]}-{input[7..]}",
            >= 10 => $"({input[..2]}) {input[2..6]}-{input[6..]}",
            >= 7  => $"({input[..2]}) {input[2..7]}-",
            >= 6  => $"({input[..2]}) {input[2..6]}",
            >= 3  => $"({input[..2]}) {input[2..]}",
            >= 1  => $"({input[..input.Length]}",
            _     => input
        };
    }
    
    public static string FormatarDataDeNascimento(string? value)
    {
        if (string.IsNullOrWhiteSpace(value)) return string.Empty;

        var input = new string(value.Where(char.IsDigit).ToArray());
        input = input.Length > 8 ? input.Substring(0, 8) : input;

        return input.Length switch
        {
            >= 8 => $"{input[..2]}/{input[2..4]}/{input[4..]}",
            >= 6 => $"{input[..2]}/{input[2..4]}/{input[4..]}",
            >= 4 => $"{input[..2]}/{input[2..4]}",
            >= 3 => $"{input[..2]}/{input[2..]}",
            >= 1 => input,
            _ => input
        };
    }

    
}
using Exercise9.Interfaces;
using Exercise9.Models;

namespace Exercise9.Services
{
  // Principio de Responsabilidad Única (SRP)
  // Esta clase orquesta el proceso de análisis de pangramas
  public class PangramAnalyzer
  {
    private readonly IFileService _fileService;
    private readonly ITextValidator _textValidator;

    // Principio de Inversión de Dependencias (DIP)
    // Recibimos las dependencias por inyección de constructores
    public PangramAnalyzer(IFileService fileService, ITextValidator textValidator)
    {
      _fileService = fileService;
      _textValidator = textValidator;
    }

    public void ProcessFile(string inputPath, string outputPath)
    {
      string[] lines = _fileService.ReadAllLines(inputPath);

      if (lines.Length == 0 || !int.TryParse(lines[0], out int linesCount))
      {
        Console.WriteLine("Error: El archivo está vacío o el formato es inválido.");
        return;
      }

      var results = ProcessLines(lines.Skip(1));
      _fileService.WriteAllLines(outputPath, results.Select(r => r.ToString()));
    }

    private IEnumerable<PangramResult> ProcessLines(IEnumerable<string> lines)
    {
      foreach (string line in lines)
      {
        bool isPangram = _textValidator.Validate(line, out int characterCount);
        yield return new PangramResult
        {
          IsPangram = isPangram,
          CharacterCount = characterCount
        };
      }
    }
  }
}

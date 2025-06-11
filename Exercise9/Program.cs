using Exercise9.Interfaces;
using Exercise9.Services;

namespace Exercise9
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Principio de Inversión de Dependencias (DIP)
      // Creamos las implementaciones concretas de las interfaces
      IFileService fileService = new FileService();
      ITextValidator textValidator = new PangramValidator();

      // Principio de Responsabilidad Única (SRP)
      // Delegamos todo el procesamiento a una clase especializada
      var analyzer = new PangramAnalyzer(fileService, textValidator);

      string inputPath = "./Exercise9/PANGRAMA.txt";
      string outputPath = "./Exercise9/SOLUCION.txt";

      analyzer.ProcessFile(inputPath, outputPath);
    }
  }
}

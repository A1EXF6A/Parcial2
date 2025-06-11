namespace Exercise9.Interfaces
{
  // Principio de Inversión de Dependencias (DIP)
  // Definimos contratos para las operaciones de archivo
  public interface IFileService
  {
    string[] ReadAllLines(string path);
    void WriteAllLines(string path, IEnumerable<string> lines);
  }

  // Principio de Segregación de Interfaces (ISP)
  // Separamos la validación de texto en su propia interfaz
  public interface ITextValidator
  {
    bool Validate(string text, out int characterCount);
  }
}

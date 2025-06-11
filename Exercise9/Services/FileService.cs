using Exercise9.Interfaces;

namespace Exercise9.Services
{
  // Principio de Responsabilidad Única (SRP)
  // Esta clase solo se encarga de operaciones de archivo
  public class FileService : IFileService
  {
    public string[] ReadAllLines(string path)
    {
      try
      {
        return File.ReadAllLines(path);
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error al leer el archivo: {ex.Message}");
        return [];
      }
    }

    public void WriteAllLines(string path, IEnumerable<string> lines)
    {
      try
      {
        using StreamWriter writer = new(path);
        foreach (string line in lines)
        {
          writer.WriteLine(line);
        }
        Console.WriteLine($"Archivo escrito correctamente en: {path}");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
      }
    }
  }
}

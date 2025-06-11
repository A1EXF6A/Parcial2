using Exercise9.Interfaces;

namespace Exercise9.Services
{
  // Principio de Responsabilidad Única (SRP)
  // Esta clase solo se encarga de validar si un texto es un pangrama
  public class PangramValidator : ITextValidator
  {
    public bool Validate(string text, out int characterCount)
    {
      characterCount = 0;
      HashSet<char> uniqueChars = [];

      foreach (char c in text)
      {
        if (char.IsLetter(c))
        {
          uniqueChars.Add(char.ToUpper(c));
          characterCount++;
        }
      }

      return uniqueChars.Count >= 26;
    }
  }
}

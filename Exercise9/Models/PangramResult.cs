namespace Exercise9.Models
{
  public class PangramResult
  {
    public bool IsPangram { get; set; }
    public int CharacterCount { get; set; }

    public override string ToString()
    {
      return $"{(IsPangram ? "SI" : "NO")}   {CharacterCount}";
    }
  }
}

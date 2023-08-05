
class Musica
{
  public string? Nome {get; set;}
  public Banda Artista {get;}
  public int Duracao {get; set;}
  public bool Disponivel {get; set;}
  public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";
  public Genero Genero {get;set;}  


  public void ExiborFicaTecnica()
  {
    Console.WriteLine($"Nome: {Nome}");
    Console.WriteLine($"Artista: {Artista}");
    Console.WriteLine($"Duração: {Duracao}");
    if (Disponivel)
    {
      Console.WriteLine($"Disponivel no plano.");
    }
    else
    {
      Console.WriteLine($"Adquira o plano Plus+");
    }
  }

}
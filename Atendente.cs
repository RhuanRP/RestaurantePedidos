public class Atendente
{
  private string _nome;

  public Atendente(string nome)
  {
    _nome = nome;
  }

  public void NotificarCliente(string mensagem)
  {
    Console.WriteLine($"[{_nome}] Notificando cliente: {mensagem}");
  }
}

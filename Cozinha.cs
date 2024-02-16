public class Cozinha
{
  private string _nome;

  public Cozinha(string nome)
  {
    _nome = nome;
  }

  public void PrepararPedido(string mensagem)
  {
    Console.WriteLine($"[{_nome}] Pedido recebido e pronto para preparar: {mensagem}");
  }
}
public class ComponenteObservador
{
  private string _nome;

  public ComponenteObservador(string nome)
  {
    _nome = nome;
  }

  public void ReceberNotificacao(string mensagem)
  {
    Console.WriteLine($"{_nome} recebeu a seguinte notificação: {mensagem}");
  }
}
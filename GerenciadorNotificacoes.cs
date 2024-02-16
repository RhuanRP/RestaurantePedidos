public class GerenciadorNotificacoes
{
  private static GerenciadorNotificacoes _instance;
  private Dictionary<string, List<Action<string>>> _inscritos;

  private GerenciadorNotificacoes()
  {
    _inscritos = new Dictionary<string, List<Action<string>>>();
  }

  public static GerenciadorNotificacoes GetInstance()
  {
    if (_instance == null)
    {
      _instance = new GerenciadorNotificacoes();
    }
    return _instance;
  }

  public void Inscrever(string evento, Action<string> callback)
  {
    if (!_inscritos.ContainsKey(evento))
    {
      _inscritos[evento] = new List<Action<string>>();
    }
    _inscritos[evento].Add(callback);
  }

  public void Notificar(string evento, string mensagem)
  {
    if (_inscritos.ContainsKey(evento))
    {
      foreach (var callback in _inscritos[evento])
      {
        callback(mensagem);
      }
    }
  }
}
using System;
using System.Collections.Generic;
class Program
{
  static void Main(string[] args)
  {
    GerenciadorNotificacoes gerenciador = GerenciadorNotificacoes.GetInstance();

    Cozinha cozinha = new Cozinha("Cozinha");
    Atendente atendente = new Atendente("Atendente");

    gerenciador.Inscrever("NovoPedido", cozinha.PrepararPedido);

    gerenciador.Inscrever("PedidoPronto", atendente.NotificarCliente);

    gerenciador.Notificar("NovoPedido", "Pedido #1558: Picanha na chapa");

    gerenciador.Notificar("PedidoPronto", "Pedido #1558 está pronto para ser servido");

  }
}
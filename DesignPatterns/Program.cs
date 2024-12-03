// See https://aka.ms/new-console-template for more information
using DesignPatterns.Comportamentais.TemplateMethod;
using DesignPatterns.Comportamentais.Strategy;
using DesignPatterns.Comportamentais.TemplateMethod;


#region Strategy

var freteComum = new FreteComum();
var freteExpresso = new FreteExpresso();

var pedidoMoveis = new PedidoMoveis();
pedidoMoveis.SetTipoFrete(freteComum);
pedidoMoveis.SetValor(1000);

Console.WriteLine($"Frete Comum para Pedido de Móveis: {pedidoMoveis.CalculaFrete()}");

pedidoMoveis.SetTipoFrete(freteExpresso);
Console.WriteLine($"Frete Expresso para Pedido de Móveis: {pedidoMoveis.CalculaFrete()}");


var pedidoEletronicos = new PedidoEletronicos();
pedidoEletronicos.SetTipoFrete(freteComum);
pedidoEletronicos.SetValor(1000);

Console.WriteLine($"Frete Comum para Pedido de Eletrônicos: {pedidoEletronicos.CalculaFrete()}");

pedidoEletronicos.SetTipoFrete(freteExpresso);
Console.WriteLine($"Frete Expresso para Pedido de Eletrônicos: {pedidoEletronicos.CalculaFrete()}");

#endregion

#region TemplateMethod

//Payment payment = new CreditPayment(1000, new Gateway());
//payment.RealizeCharge();

//Payment paymentDebit = new DebitPayment(1000, new Gateway());
//paymentDebit.RealizeCharge();

//Payment paymentMoney = new MoneyPayment(1000, new Gateway());
//paymentMoney.RealizeCharge();

#endregion

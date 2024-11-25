// See https://aka.ms/new-console-template for more information

using DesignPatterns.Comportamentais.TemplateMethod;

Payment payment = new CreditPayment(1000, new Gateway());
payment.RealizeCharge();

Payment paymentDebit = new DebitPayment(1000, new Gateway());
paymentDebit.RealizeCharge();

Payment paymentMoney = new MoneyPayment(1000, new Gateway());
paymentMoney.RealizeCharge();


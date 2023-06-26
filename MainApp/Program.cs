using Domain.Models;
using Infrastructure.Services;

var ac1 = new Account(22113344,456);
var acService1 = new AccountService(ac1);
Console.WriteLine("Before: " + Environment.NewLine + acService1.toString());

acService1.GetCredit(4);
Console.WriteLine("After credit: " + Environment.NewLine + acService1.toString());

acService1.GetDebit(10);
Console.WriteLine("After debit: " + Environment.NewLine + acService1.toString());

var ac2 = new Account(55778899, 897);
var acService2 = new AccountService(ac2);
Console.WriteLine("Before: " + Environment.NewLine + acService2.toString());

acService2.GetCredit(3);
Console.WriteLine("After credit: " + Environment.NewLine + acService2.toString());

acService2.GetDebit(20);
Console.WriteLine("After debit: " + Environment.NewLine + acService2.toString());


acService2.transferTo(100, ac1);
Console.WriteLine("After transfer: " + Environment.NewLine + acService1.toString());
Console.WriteLine("After transfer: " + Environment.NewLine + acService2.toString());


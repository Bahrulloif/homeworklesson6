var client = new Account(23, 123.0);

System.Console.WriteLine(client.getNumber);
System.Console.WriteLine(client.getBalance);
System.Console.WriteLine(client.toString());

client.credit(124);
System.Console.WriteLine(client.toString());
client.debit(100);
System.Console.WriteLine(client.toString());
var client2 = new Account(24, 100);
client.transferTo(100, client2);
System.Console.WriteLine(client.toString());
System.Console.WriteLine(client2.toString());
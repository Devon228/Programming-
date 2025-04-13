InternetOperator op = new InternetOperator("mts");

op.addClient("Vanya", Client.ClientType.VIP, "t1");
Console.WriteLine(op.calcProfit());
(string Name, long Profit) maxProfit = op.maxProfitClient();
Console.WriteLine("Client: {0} with Profit: {1}", maxProfit.Name, maxProfit.Profit);


op.addTariff("t1", 229);
op.addClient("Vanya", Client.ClientType.VIP, "t1");
op.addClient("Stas", Client.ClientType.Standart, "t1");
op.addTraffic("Vanya", 1);
op.addTraffic("Vabya", 123121);
op.addTraffic("Vanya", 123121);
op.addTraffic("Stas", 123123123);

op.addTariff("t2", 1);
op.addClient("Kolya", Client.ClientType.VIP, "t2");
op.addTraffic("Kolya", 228);

op.addTariff("t3", 0);

Console.WriteLine(op.calcProfit());
maxProfit = op.maxProfitClient();
Console.WriteLine("Client: {0} with Profit: {1}", maxProfit.Name, maxProfit.Profit);


Console.WriteLine("Hello");

InternetOperator op1 = InternetOperator.GetInstance(123, 100000000, "MTS");
InternetOperator op2 = InternetOperator.GetInstance();

Console.WriteLine("operator {1} profit : {0}", op1.calcProfit(), op1.NameOperator);
Console.WriteLine("operator {1} profit : {0}", op2.calcProfit(), op2.NameOperator);

op1.changeTariff(-122);
op2.NameOperator = "A1";
op2.NumberSubscribers = 100;
op2.setTariff(10);

Console.WriteLine("operator {1} profit : {0}", op1.calcProfit(), op1.NameOperator);
Console.WriteLine("operator {1} profit : {0}", op2.calcProfit(), op2.NameOperator);
using System;
using System.Runtime.InteropServices;

public class InternetOperator
{
	private List<Tariff> lstTariff;
	private List<Client> lstClient;
	private string name;


	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public InternetOperator(string name)
	{
		this.name = name;
		lstTariff = new List<Tariff>();
		lstClient = new List<Client>();
	}
    private int FindClientByName(string clientName)
    {
        for (int i = 0; i < lstClient.Count; i++)
            if (lstClient[i].Name == clientName)
            {
                return i;
            }
        return -1;
    }
    private int FindTariffByName(string tariffName)
    {
        for (int i = 0; i < lstTariff.Count; i++)
            if (lstTariff[i].Name == tariffName)
            {
                return i;
            }
        return -1;
    }
	
	public void addTariff(string name, long price)
    {
        lstTariff.Add(new Tariff(name, price));
    }
    public void addClient (string clientName, Client.ClientType clientType, string tariffName)
	{
		int indTariff = FindTariffByName(tariffName);

        if (indTariff != -1)
			lstClient.Add(new Client(clientName, clientType, tariffName, lstTariff[indTariff].Price));
		else
			Console.WriteLine("No suitable tariff for a new client");
	}
	public void addTraffic (string clientName, long mbytes)
	{
		int indClient = FindClientByName(clientName);

        if (indClient != -1)
		{
			if (mbytes >= 0)
				lstClient[indClient].Traffic.Add(mbytes);
			else
                Console.WriteLine("Negative number of mbytes");
        }
        else
            Console.WriteLine("No suitable client");
    }

	public long calcProfit()
	{
        long profit = 0;

		foreach (Client client in lstClient)
		{
			long sumMbytes = 0;
			foreach (long mbytes in client.Traffic)
				sumMbytes += mbytes;

			long clientSum = sumMbytes * client.CurTariff.Price;
			if (client.CType == Client.ClientType.VIP)
				clientSum = (clientSum / 10) * 8;

			profit += clientSum;
		}

		return profit;
	}
    public (string Name, long Profit) maxProfitClient()
    {
		if (lstClient.Count == 0)
			return ("No clients", 0);

        (string Name, long Profit) maxProfit = ("No clients", -1);

		foreach (Client client in lstClient)
        {
            long sumMbytes = 0;
			foreach (long mbytes in client.Traffic)
                sumMbytes += mbytes;

            long clientSum = sumMbytes * client.CurTariff.Price;
            if (client.CType == Client.ClientType.VIP)
                clientSum = (clientSum / 10) * 8;

            if (clientSum > maxProfit.Profit)
			{
				maxProfit.Profit = clientSum;
				maxProfit.Name = client.Name;
			}
        }

        return maxProfit;
    }
}

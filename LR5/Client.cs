using System;
using System.Diagnostics;

public class Client
{
	private string name;
	public enum ClientType
	{
		Standart,
		VIP
	}
	private ClientType cType;
	private Tariff curTariff;
	private List<long> traffic;
	

	public string Name
	{
		get { return name; }
		set { name = value; }
	}
    public ClientType CType
	{
        get { return cType; }
        set { cType = value; }
    }
    public Tariff CurTariff
    {
        get { return curTariff; }
        set { curTariff = value; }
    }
	public List <long> Traffic
	{
        get { return traffic; }
        private set {}
    }

	
	public Client (string name, ClientType type, string tariff, long price)
	{
		this.name = name;
		this.cType = type;
		this.curTariff = new Tariff(tariff, price);
		this.traffic = new List<long>();
	}
}

namespace LR5
{
    public class Client
    {
    }
}
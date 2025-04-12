using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class InternetOperator
{
	private static InternetOperator? instance;
	private Tariff curTariff;
	private string nameOperator;
	private long numberSubscribers;


	public string NameOperator
	{
		get { return nameOperator; }
		set { nameOperator = value; }
	}
	public long NumberSubscribers
	{
		get => numberSubscribers;
		set { numberSubscribers = value; }	
	}
	public long CurTariffPrice
	{
		get { return curTariff.Price; }
		set { curTariff.Price = value; }
	}


    private InternetOperator(long price, long subs, string name)
    {
		curTariff = new Tariff(price);
		nameOperator = name;	
		numberSubscribers = subs;
	}
    public static InternetOperator GetInstance ()
	{
		if (instance == null)
		{
			instance = new InternetOperator(0, 0, String.Empty);
		}
		return instance;

	}    
	public static InternetOperator GetInstance (long price, long subs, string name)
	{
		if (instance == null)
		{
			instance = new InternetOperator(price, subs, name);
		}
		return instance;

	}
	public long calcProfit()
	{
		return curTariff.Price * numberSubscribers;
	}
	public void changeTariff(long value)
	{
		curTariff.Price += value;
	}	
	public void setTariff(long value)
	{
		curTariff.Price = value;
	}

}

using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Tariff
{
	private long price;


	public long Price
	{
		get { return price; }
		set { price = value; }
	}


	public Tariff()
	{
		price = 0;
	}
	public Tariff (long value)
	{
		price = value;
	}

}

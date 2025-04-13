using System;

public class Tariff
{
    private string name;
    private long price;


	public string Name
	{
		get { return name; }
		set { name = value; }
	}
    public long Price
    {
        get { return price; }
        set { price = value; }
    }


    public Tariff() : this(String.Empty, 0)
	{ }	
	public Tariff(string name, long price)
	{
        this.name = name;
        this.price = price;
	}
}

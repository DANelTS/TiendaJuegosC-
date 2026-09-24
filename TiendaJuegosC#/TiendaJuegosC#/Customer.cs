using System;

public class Customer
{
	private int id;
	private string name;
	private double balance;

	public Customer(int id, string name, double balance)
	{
		this.id = id;
		this.name = name;
		this.balance = balance;
	}

	public int Id { get; }
	public string Name { get; }
	public double Balance { get; }

	public void addBalance(double balance)
	{
		if (balance > 0) this.balance += balance;
	}

	public void decreaseBalance(double balance)
	{
		if(balance > 0 && balance <= this.balance) this.balance -= balance;
	}

	public bool enoughBalance(double amount)
	{
		return balance - amount >= 0;
	}

    public override string ToString()
    {
		return string.Format(
			"{0}\n{1, -10} {2}\n{3, -10} {4}\n{5, -10} {6}\n{7}", 
            "============================",
			"ID:", id,
			"Name:", name,
			"Balance:", balance,
            "============================"
            );
    }
}

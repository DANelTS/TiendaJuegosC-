using System;

public class Game
{
	private int id;
	private String title;
	private Genre genre;
	private double price;
	private int stock;

	public Game(int id, String title, Genre genre, double price, int stock)
	{
        this.id = id;
        this.title = title;
        this.genre = genre;
        this.price = price;
        this.stock = stock;
    }

	public int Id { get; }
	public String Title { get; }
	public Genre Genre { get; }
	public double Price { get; }
	public int Stock { get; }

	private void increaseStock(int stock)
	{
		this.stock += stock;
	}

	private void decreaseStock(int stock)
	{
		if (this.stock > stock) this.stock += stock;
		else Console.WriteLine("Stock can't be inferior to 0");
    }

	public void setStock(int stock)
	{
		if (stock > 0) increaseStock(stock);
		else if (stock < 0) decreaseStock(stock);
		else Console.WriteLine("The stock can't be changed to 0");
	}

	public bool enoughStock(int quantity)
	{
		return quantity <= stock;
	}

    public override string ToString()
    {
        return string.Format(
			"{0}\n{1, -10} {2}\n{3, -10} {4}\n{5, -10} {6}\n{7, -10} {8}\n{9, -10} {10}\n{11}",
			"============================",
			"ID:", id,
			"Title:", title,
			"Genre:", genre,
			"Price:", price,
			"Stock:", stock,
            "============================"
        );
    }

}

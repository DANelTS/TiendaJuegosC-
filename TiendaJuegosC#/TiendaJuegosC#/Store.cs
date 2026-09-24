using System;

public class Store
{
	List<Game> games;
	List<Customer> customers;
	List<Purchase> purchases;

	public Store()
	{
		games = new List<Game>();
		customers = new List<Customer>();
		purchases = new List<Purchase>();
	}

	public List<Game> Games => games;
	public List<Customer> Customers => customers;
	public List<Purchase> Purchases => purchases;

	public void addGame(Game game)
	{
		foreach(Game g in games) if (g.Id == game.Id) return;
		games.Add(game);
    }

	public Game searchGame(int id)
	{
		foreach (Game g in games) if (g.Id == id) return g;
		Console.WriteLine("That game is not in the database");
		return null;
	}

	public Customer searchCustomer(int id)
	{
		foreach (Customer c in customers) if (c.Id == id) return c;
		Console.WriteLine("That customer is not in the database");
		return null;
	}

    public List<Game> searchGameTitle(string line)
    {
        List<Game> gameList = new List<Game>();

        foreach (Game g in games) if (g.Title.ToLower().Contains(line.ToLower())) gameList.Add(g);
        if (gameList.Count > 0) return gameList;
        else
        {
            Console.WriteLine("No match found");
            return null;
        }
    }

	public List<Game> filterByGenre(Genre genre)
	{
		List<Game> gameList = new List<Game>();

		foreach(Game g in games) if (g.Genre.Equals(genre)) gameList.Add(g);
		if (gameList.Count > 0) return gameList;
		else
		{
			Console.WriteLine("No games found");
			return null;
		}
	}

	public void purchaseGame(Customer customer, Game game, int quantity)
	{
		if(customers.Contains(customer) && games.Contains(game) && quantity > 0 && game.enoughStock(quantity) && customer.enoughBalance(game.Price * quantity))
		{
			game.setStock(-quantity);
			customer.decreaseBalance(game.Price * quantity);
			purchases.Add(new Purchase(customer, game, quantity));
		}
	}
}

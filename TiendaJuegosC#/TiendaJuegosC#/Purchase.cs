using System;

public class Purchase
{
	private Customer customer;
	private Game game;
	private int quantity;
	private double totalPrice;

	public Purchase(Customer customer, Game game, int quantity)
	{
		this.customer = customer;
		this.game = game;
		this.quantity = quantity;

		totalPrice = game.Price * quantity;
	}

	public Customer Customer { get; }
	public Game Game { get; }
	public int Quantity { get; }
}

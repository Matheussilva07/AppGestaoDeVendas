﻿namespace GestaoDeVendas.Communication.Costumers.Responses;
public class ResponseCostumerJson
{
	public long Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string Telephone { get; set; } = string.Empty;
	public string Address { get; set; } = string.Empty;
}

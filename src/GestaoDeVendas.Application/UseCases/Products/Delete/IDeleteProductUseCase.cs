﻿namespace GestaoDeVendas.Application.UseCases.Products.Delete;
public interface IDeleteProductUseCase
{
	Task ExecuteAsync(long productId);
}

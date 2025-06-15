using AppGestaoDeVendas.GUI.Communication.Products.Requests;
using AppGestaoDeVendas.GUI.Communication.Products.Responses;
using AppGestaoDeVendas.GUI.Entities;
using AppGestaoDeVendas.GUI.HttpClientMethods;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace AppGestaoDeVendas.GUI;
internal class HttpClient_Products : BaseAdress
{
	public static async Task<HttpResponseMessage?> DoPost(RequestRegisterProduct request)
	{
		var client = GetHttpClient();

		return await client.PostAsJsonAsync("/products", request);
	
	}
	public static async Task<ResponseProduct?> DoGetProductById(long id)
	{
		string route = $"/products/{id}";

		var client = GetHttpClient();

		HttpResponseMessage httpResponse = await client.GetAsync(route);

		var content = await httpResponse.Content.ReadAsStringAsync();

		 var product = JsonConvert.DeserializeObject<ResponseProduct>(content);

		return product;
	}
	public static async Task<ResponseProduct?> DoGetProductByName(string productName)
	{
		string content = string.Empty;
		
		try
		{
			string route = $"/products/product-by-name?productName={productName}";

			var client = GetHttpClient();

			HttpResponseMessage httpResponse = await client.GetAsync(route);

			content = await httpResponse.Content.ReadAsStringAsync();

			var product = JsonConvert.DeserializeObject<ResponseProduct>(content);

			return product;
		}
		catch
		{
			MessageBox.Show(content,"Nosso mercado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			return null;
		}
	}
	public static async Task<IList<Product>> DoGetProductsList()
	{
		string route = $"/products";

		var client = GetHttpClient();

		HttpResponseMessage httpResponse = await client.GetAsync(route);

		var response = await httpResponse.Content.ReadAsStringAsync();

		var produtos = JsonConvert.DeserializeObject<IList<Product>>(response);

		return produtos!;
	}
	public static async Task<bool> DoPut(long id, RequestUpdateProduct request)
	{
		string route = $"/products/{id}";

		var client = GetHttpClient();

		var httpMessage = await client.PutAsJsonAsync(route, request);

		return httpMessage.IsSuccessStatusCode;
	}
	public static async Task<string> DoDelete(long id)
	{
		try
		{
			string route = $"/products/{id}";

			var client = GetHttpClient();

			HttpResponseMessage httpResponse = await client.DeleteAsync(route);

			if (httpResponse.IsSuccessStatusCode)
			{
				return "Produto deletado com sucesso.";
			}
			else
			{
				string errorMessage = await httpResponse.Content.ReadAsStringAsync();
				return errorMessage;
			}
		}
		catch (HttpRequestException ex)
		{
			return ex.Message;
		}
	
	}

}

using AppGestaoDeVendas.GUI.Communication.Sales.Requests;
using System.Net.Http.Json;

namespace AppGestaoDeVendas.GUI.HttpClientMethods;
internal class HttpClientSales
{

	public static async Task<bool> DoPost(RequestRegisterSale request)
	{
		string route = "/sales";

		var client = GetHttpClient();

		HttpResponseMessage httpResponse = await client.PostAsJsonAsync(route, request);

		return httpResponse.IsSuccessStatusCode;
	}

	private static HttpClient GetHttpClient()
	{
		var client = new HttpClient
		{
			BaseAddress = new Uri("http://localhost:5221")
		};
		return client;
	}
}

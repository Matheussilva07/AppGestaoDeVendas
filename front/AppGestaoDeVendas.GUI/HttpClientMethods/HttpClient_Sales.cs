using AppGestaoDeVendas.GUI.Communication.Sales.Requests;
using AppGestaoDeVendas.GUI.Communication.Sales.Responses;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace AppGestaoDeVendas.GUI.HttpClientMethods;
internal class HttpClient_Sales : BaseAdress
{

	public static async Task<bool> DoPost(RequestRegisterSale request)
	{
		string route = "/sales";

		var client = GetHttpClient();

		HttpResponseMessage httpResponse = await client.PostAsJsonAsync(route, request);

		return httpResponse.IsSuccessStatusCode;
	}
	public static async Task<List<ResponseSaleFilteredByDate>> FilterSalesByDate(DateOnly period)
	{
		HttpResponseMessage httpResponse = new();

		try
		{
			string route = $"/sales/filter-sales?period={period:MM/yyyy}";

			var client = GetHttpClient();

			httpResponse = await client.GetAsync(route);

			var content = await httpResponse.Content.ReadAsStringAsync();

			var sales = JsonConvert.DeserializeObject<List<ResponseSaleFilteredByDate>>(content);

			return sales!;
		}
		catch
		{
			var errorMessage = await httpResponse.Content.ReadAsStringAsync();

			MessageBox.Show(errorMessage);

			return [];
		}
	}

	public static async Task<bool> DoDelete(long id)
	{
		string route = $"/sales/{id}";
		
		var client = GetHttpClient();

		HttpResponseMessage httpResponse = await client.DeleteAsync(route);

		return httpResponse.IsSuccessStatusCode;
	}

}

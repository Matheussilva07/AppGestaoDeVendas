using AppGestaoDeVendas.GUI.Communication.Customers.Requests;
using AppGestaoDeVendas.GUI.Communication.Customers.Responses;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace AppGestaoDeVendas.GUI.HttpClientMethods;
internal class HttpClient_Customers : BaseAdress
{
	public static async Task<bool> DoPost(RequestCostumerJson request)
	{
		try
		{
			const string ROUTE = "/costumers";

			var client = GetHttpClient();

			Validate(request);

			HttpResponseMessage httpResponse = await client.PostAsJsonAsync(ROUTE, request);

			if (!httpResponse.IsSuccessStatusCode)
			{
				string errorMsg = await httpResponse.Content.ReadAsStringAsync();
				MessageBox.Show($"Erro na resposta da API: {httpResponse.StatusCode}\n{errorMsg}", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Erro na requisição:\n{ex.Message}", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
	}

	public static async Task<List<ResponseShortCostumersJson>> DoGet()
	{
		try
		{
			const string ROUTE = "/costumers";

			var client = GetHttpClient();

			HttpResponseMessage httpResponse = await client.GetAsync(ROUTE);

			var content = await httpResponse.Content.ReadAsStringAsync();

			var costumers = JsonConvert.DeserializeObject<List<ResponseShortCostumersJson>>(content);

			return costumers;
		}
		catch (ArgumentException)
		{
			throw new ArgumentException("Erro na requisição");
		}


	}

	public static async Task<ResponseCostumerJson?> DoGetById(long costumerId)
	{
		try
		{
			string route = $"/costumers/{costumerId}";

			var client = GetHttpClient();

			HttpResponseMessage httpResponse = await client.GetAsync(route);

			var content = await httpResponse.Content.ReadAsStringAsync();

			var costumer = JsonConvert.DeserializeObject<ResponseCostumerJson>(content);

			return costumer;

		}
		catch (Exception ex)
		{
			throw new Exception($"Erro na requisição: {ex.Message}");
		}
	}

	public static async Task<ResponseCostumerJson?> DoGetByName(string nameCostumer)
	{
		string route = $"/costumers/get-by-name?name={nameCostumer}";

		var client = GetHttpClient();

		HttpResponseMessage httpResponse = await client.GetAsync(route);

		var content = await httpResponse.Content.ReadAsStringAsync();

		var costumer = JsonConvert.DeserializeObject<ResponseCostumerJson>(content);

		return costumer;

	}

	public static async Task<bool> DoPut(RequestCostumerJson request, long costumerId)
	{
		try
		{
			string route = $"/costumers/{costumerId}";

			var client = GetHttpClient();

			HttpResponseMessage httpResponse = await client.PutAsJsonAsync(route, request);

			return httpResponse.IsSuccessStatusCode;
		}
		catch (Exception ex)
		{
			throw new ArgumentException($"Erro na requisição: {ex.Message}");
		}
	}

	public static async Task<bool> DoDelete(long costumerId)
	{
		string route = $"/costumers/{costumerId}";

		var client = GetHttpClient();

		HttpResponseMessage httpResponse = await client.DeleteAsync(route);

		return httpResponse.IsSuccessStatusCode;
	}

	private static void Validate(RequestCostumerJson request)
	{
		List<string> errors = [];

		if (string.IsNullOrWhiteSpace(request.Name))
		{
			errors.Add("O nome não pode ser vazio.");
		}

		if (string.IsNullOrWhiteSpace(request.Email))
		{
			errors.Add("O email não pode ser vazio.");
		}

		if (errors.Count != 0)
		{
			throw new ArgumentException(string.Join("\n", errors));
		}
	}
}

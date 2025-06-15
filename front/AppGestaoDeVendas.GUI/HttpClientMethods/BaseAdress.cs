namespace AppGestaoDeVendas.GUI.HttpClientMethods;
internal class BaseAdress
{
	protected static HttpClient GetHttpClient()
	{
		var client = new HttpClient
		{
			BaseAddress = new Uri("http://localhost:5221")
		};
		return client;
	}
}

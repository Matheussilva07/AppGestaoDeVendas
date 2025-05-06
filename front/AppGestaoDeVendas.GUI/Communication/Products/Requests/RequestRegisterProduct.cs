namespace AppGestaoDeVendas.GUI.Communication.Products.Requests;
internal class RequestRegisterProduct
{
    public string Name { get; set; } = string.Empty;
    public string? Discription { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public int Amount { get; set; }
    public decimal Price { get; set; }
}

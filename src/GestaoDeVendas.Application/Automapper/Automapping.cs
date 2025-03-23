using AutoMapper;
using GestaoDeVendas.Communication;
using GestaoDeVendas.Communication.Costumers.Requests;
using GestaoDeVendas.Communication.Costumers.Responses;
using GestaoDeVendas.Communication.Products.Requests;
using GestaoDeVendas.Communication.Products.Responses;
using GestaoDeVendas.Communication.Sales.Requests;
using GestaoDeVendas.Communication.Sales.Responses;
using GestaoDeVendas.Domain.Entities;
using System.Xml.Linq;

namespace GestaoDeVendas.Application.Automapper;
public class Automapping : Profile
{
    public Automapping()
    {
        RequestToEntity();
        EntityToResponse();
  

	}

    private void RequestToEntity()
    {
        CreateMap<RequestRegisterCostumerJson, Costumer>();
        CreateMap<RequestRegisterProductJson, Product>();

        CreateMap<RequestUpdateProductJson, Product>();

        CreateMap<RequestRegisterSaleJson, Sale>();
        CreateMap<SoldProductData, SoldProduct>();
		
	}
    private void EntityToResponse()
    {
        CreateMap<Costumer, ResponseRegisteredCostumerJson>();
        CreateMap<Product, ResponseRegisteredProductJson>();

        CreateMap<Sale, ResponseRegisteredSaleJson>();

        CreateMap<Sale, ResponseSaleByIdJson>()
            .ForMember(dest => dest.Name, config => config.MapFrom(src => src.Costumer.Name))
            .ForMember(dest => dest.Email, config => config.MapFrom(src => src.Costumer.Email));


        CreateMap<Product,ResponseProductsListJson>();

        CreateMap<Product, ResponseProductDetailsJson>();
           
    }

}

using AutoMapper;
using GestaoDeVendas.Communication;
using GestaoDeVendas.Communication.Costumers.Requests;
using GestaoDeVendas.Communication.Costumers.Responses;
using GestaoDeVendas.Communication.Products.Requests;
using GestaoDeVendas.Communication.Products.Responses;
using GestaoDeVendas.Communication.Sales.Requests;
using GestaoDeVendas.Communication.Sales.Responses;
using GestaoDeVendas.Communication.Users.Requests;
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
        CreateMap<RequestUpdateCostumerJson, Costumer>();

        CreateMap<RequestRegisterProductJson, Product>();
        CreateMap<RequestUpdateProductJson, Product>();

        CreateMap<RequestRegisterSaleJson, Sale>();
        CreateMap<SoldProductData, SoldProduct>();


        CreateMap<RequestRegisterUserJson, User>().ForMember(user => user.Password, config => config.Ignore());
		
	}
    private void EntityToResponse()
    {
        CreateMap<Costumer, ResponseRegisteredCostumerJson>();
        CreateMap<Costumer, ResponseShortCostumerJson>();
        CreateMap<Costumer, ResponseCostumerJson>();

        CreateMap<Product, ResponseRegisteredProductJson>();

        CreateMap<Sale, ResponseRegisteredSaleJson>();

        CreateMap<Sale, ResponseSaleByIdJson>()
            .ForMember(dest => dest.Name, config => config.MapFrom(src => src.Costumer.Name))
            .ForMember(dest => dest.Email, config => config.MapFrom(src => src.Costumer.Email));


        CreateMap<Product,ResponseProductsListJson>();

        CreateMap<Product, ResponseProductDetailsJson>();
           
    }

}

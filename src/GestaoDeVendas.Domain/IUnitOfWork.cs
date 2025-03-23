namespace GestaoDeVendas.Domain;
public interface IUnitOfWork
{
	Task CommitAsync();
}

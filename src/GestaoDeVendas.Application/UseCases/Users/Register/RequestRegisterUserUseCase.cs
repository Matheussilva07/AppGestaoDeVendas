using AutoMapper;
using GestaoDeVendas.Communication.Users.Requests;
using GestaoDeVendas.Communication.Users.Responses;
using GestaoDeVendas.Domain;
using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories;
using GestaoDeVendas.Domain.Security.PasswordEncryptor;
using GestaoDeVendas.Domain.Security.Token;

namespace GestaoDeVendas.Application.UseCases.Users.Register;
internal class RequestRegisterUserUseCase : IRequestRegisterUserUseCase
{
	private readonly IMapper _mapper;
	private readonly IUnitOfWork _unitOfWork;
	private readonly ITokenGenerator _tokenGenerator;
	private readonly IPasswordEncryptor _passwordEncryptor;
	private readonly IWriteOnlyUserRepository _userRepository;

	public RequestRegisterUserUseCase(IMapper mapper, IUnitOfWork unitOfWork, IWriteOnlyUserRepository userRepository, IPasswordEncryptor passwordEncryptor, ITokenGenerator tokenGenerator)
	{
		_mapper = mapper;
		_unitOfWork = unitOfWork;
		_userRepository = userRepository;
		_passwordEncryptor = passwordEncryptor;
		_tokenGenerator = tokenGenerator;
	}

	public async Task<ResponseRegisteredUserJson> ExecuteAsync(RequestRegisterUserJson request)
	{
		Validate(request);

		var user = _mapper.Map<User>(request);
		user.Password = _passwordEncryptor.EncryptPassword(request.Password);
		user.UserIdentifier = Guid.NewGuid();

		await _userRepository.AddAsync(user);

		await _unitOfWork.CommitAsync();

		return new ResponseRegisteredUserJson
		{
			Name = user.Name,
			Token = _tokenGenerator.GenerateToken(user),
		};
			
	}
	private static void Validate(RequestRegisterUserJson request)
	{
		var validator = new UserValidator();

		var result = validator.Validate(request);

		if (!result.IsValid)
		{
			throw new ArgumentException("Dados inválidos.");
		}
	}
}

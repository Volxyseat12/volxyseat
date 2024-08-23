using MediatR;

namespace Volxyseat.Api.Application.Commands.CreateUser
{
    public record class CreateUserCommand(
        string Name,
        string Email,
        string Password,
        string PasswordConfirm,
        string Role) : IRequest<bool>
    {
    }
}
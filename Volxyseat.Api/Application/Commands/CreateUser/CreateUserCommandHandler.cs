﻿using MediatR;
using Volxyseat.Domain.Models;
using Volxyseat.Domain.Repositories;

namespace Volxyseat.Api.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IUserRepository _repository;
        public CreateUserCommandHandler(IUserRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var user = new User(request.Name, request.Email, request.Password, request.Role, request.PasswordConfirm);

            _repository.AddAsync(user);

            var result = await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return result > 0;
        }
    }
}
using Application.Features.Mediator.Commands.SocialMediaCommands;
using Application.Features.Mediator.Commands.FooterAddressCommands;
using Application.Features.Mediator.Commands.SocialMediaCommands;
using Application.interfaces;
using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommand, Unit>
    {
        private readonly IRepository<SocialMedia> _repository;

        public CreateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new SocialMedia
            {
                Icon = request.Icon,
                Url = request.Url,
                Name = request.Name


            });

            return Unit.Value;
        }
    }

}

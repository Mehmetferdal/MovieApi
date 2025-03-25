using MediatR;
using MovieApi.Application.Features.MediatorDesingPattern.Command.CastCommand;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesingPattern.Handlers.CastHandlers
{
    public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand>
    {
        private readonly MovieContext _context;

        public CreateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
        {
             _context.Casts.Add(new MoviApi.Domain.Entities.Cast
            {
                Biography = request.Biography,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
                Overview = request.Overview,
                SurName = request.SurName,
                Title = request.Title
            });
            await _context.SaveChangesAsync();
        }
    }
}

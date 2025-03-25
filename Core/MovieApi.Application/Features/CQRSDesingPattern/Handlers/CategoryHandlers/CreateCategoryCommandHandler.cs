using MovieApi.Application.Features.CQRSDesingPattern.Commands.CategoryCommands;
using MovieApi.Persistence.Context;
using MoviApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly MovieContext _context;
        public CreateCategoryCommandHandler(MovieContext connect)
        {
            _context = connect;
            
        }
        public  async Task Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category { CategoryName = command.CategoryName });
            await _context.SaveChangesAsync();
        }
    }
}

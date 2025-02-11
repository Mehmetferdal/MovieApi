﻿using MovieApi.Application.Features.CQRSDesingPattern.Commands.CategoryCommands;
using MovieApi.Persistence.Context;
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
        public  async void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new MoviApi.Domain.Entities.Category { CategoryName = command.CategoryName });
            await _context.SaveChangesAsync();
        }
    }
}

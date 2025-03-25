using Microsoft.EntityFrameworkCore;
using MoviApi.Domain.Entities;
using MovieApi.Application.Features.CQRSDesingPattern.Results.CategoryResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly MovieContext _connext;
        public GetCategoryQueryHandler(MovieContext context)
        {
            _connext = context;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _connext.Categories.ToListAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName
            }).ToList();
        }
    }
}

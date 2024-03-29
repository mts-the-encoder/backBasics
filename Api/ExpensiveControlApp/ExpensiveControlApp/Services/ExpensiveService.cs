﻿using ExpensiveControlApp.Infra.Database;
using ExpensiveControlApp.Models.Expensives;
using Microsoft.EntityFrameworkCore;

namespace ExpensiveControlApp.Services
{
    public class ExpensiveService : IExpensiveServices
    {
        private readonly ExpensiveControlContext _dbContext;

        public ExpensiveService(ExpensiveControlContext context)
        {
            _dbContext = context;
        }

        public async Task Create(DTOs.CreateExpensiveDTO createExpensiveDto)
        {
            await _dbContext.Expensives.AddAsync(new Expensive()
            {
                Description = createExpensiveDto.Description,
                Value = createExpensiveDto.Value,
                Date = createExpensiveDto.Date
            });
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Expensive>> FindBy(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new Exception("Data Final deve ser maior que data inicial");
            }

            var items = await _dbContext.Expensives.Where(e =>
                e.Date >= startDate && e.Date <= endDate).AsNoTracking().ToListAsync();

            return items;
        }
    }
}

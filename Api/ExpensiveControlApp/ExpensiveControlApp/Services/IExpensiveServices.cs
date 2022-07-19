using ExpensiveControlApp.Models.Expensives;

namespace ExpensiveControlApp.Services
{
    public interface IExpensiveServices
    {
        Task Create(DTOs.CreateExpensiveDTO createExpensiveDto);

        Task<List<Expensive>> FindBy(DateTime startDate, DateTime endDate);
    }
}

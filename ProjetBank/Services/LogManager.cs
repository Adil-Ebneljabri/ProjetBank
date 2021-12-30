
namespace ProjetBank.Services
{
    public class LogManager : ILogManager
    {
        private readonly BankContext _context;

        public LogManager(BankContext context)
        {
            this._context = context;
        }
        public void AddLog(string user, string description)
        {
            _context.Logs.Add(new Log
            {
              
            });
        }
    }
}

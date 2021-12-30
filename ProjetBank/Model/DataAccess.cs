using Microsoft.EntityFrameworkCore;

namespace ProjetBank.Model
{
    public class BankContext : DbContext
    {
        public BankContext() { }
        public BankContext(DbContextOptions<BankContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Transaction> transactions { get; set; }

        public DbSet<Log> Logs { get; set; }
    }
    public class Log
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public string Email { get; set; }
        public int AccountBalance { get; set; }
        public string AccountNumber { get; set; }
        public string Administrator { get; set; }



        
    }
    public class Transaction
    {
        public int Id { set; get; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
    }
   

}

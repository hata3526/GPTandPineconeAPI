using ClientModels;
using Microsoft.EntityFrameworkCore;

namespace cgptWebAPITest.Repositories
{
    public class ChatbotDbContext : DbContext
    {
        public ChatbotDbContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Message> Message { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Session> Conversation { get; set; }
        public DbSet<BotCharacter> BotCharacter { get; set; }

    }
}

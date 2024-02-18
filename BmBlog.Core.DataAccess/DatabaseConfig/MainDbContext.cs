namespace BmBlog.Core.DataAccess.DatabaseConfig;

public class MainDbContext : DbContext
{
    //public DbSet<> MyProperty { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured is false)
            _ = 1 + 1; //Set Connection String;

        optionsBuilder.EnableDetailedErrors(ApplicationSetting.IsDebug);
        optionsBuilder.EnableSensitiveDataLogging(ApplicationSetting.IsDebug);

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }


}

namespace BmBlog.Core.DataAccess.DatabaseConfig;

public class ReadDbContext : DbContext
{
    //public DbSet<> MyProperty { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured is false)
            _ = 1 + 1; //Set Connection String;

        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

        optionsBuilder.EnableThreadSafetyChecks(false);
        optionsBuilder.EnableDetailedErrors(ApplicationSetting.IsDebug);
        optionsBuilder.EnableSensitiveDataLogging(ApplicationSetting.IsDebug);

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

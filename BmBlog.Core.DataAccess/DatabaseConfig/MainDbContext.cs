namespace BmBlog.Core.DataAccess.DatabaseConfig;

public class MainDbContext : DbContext
{

    #region DbSet

    //Data
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<CommentRating> CommentRatings { get; set; }
    public DbSet<DefaultMetaTag> DefaultMetaTags { get; set; }
    public DbSet<Gallery> Gallery { get; set; }
    public DbSet<PostHeader> Posts { get; set; }
    public DbSet<PostBody> PostBodies { get; set; }
    public DbSet<PostMetaTag> PostMetaTags { get; set; }
    public DbSet<PostRating> PostRatings { get; set; }
    public DbSet<PostSeen> PostSeens { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
    public DbSet<PostType> PostTypes { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Tag> Tags { get; set; }


    //Content
    public DbSet<MainPageSlider> MainPageSliders { get; set; }

    #endregion


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured is true)
            return;

        optionsBuilder.EnableDetailedErrors(ApplicationSetting.IsDebugMode);
        optionsBuilder.EnableSensitiveDataLogging(ApplicationSetting.IsDebugMode);

        var connectionString = ApplicationSetting.IsDebugMode
            ? "Dev"
            : "Pro";

        optionsBuilder.UseSqlServer(connectionString);

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Data

        modelBuilder.Entity<Category>()
            .ToTable(nameof(Categories), "dbo");

        modelBuilder.Entity<Comment>()
            .ToTable(nameof(Comments), "dbo");

        modelBuilder.Entity<CommentRating>()
            .ToTable(nameof(CommentRatings), "dbo");
        
        modelBuilder.Entity<DefaultMetaTag>()
            .ToTable(nameof(DefaultMetaTags), "dbo");

        modelBuilder.Entity<Gallery>()
            .ToTable(nameof(Gallery), "dbo");

        modelBuilder.Entity<PostHeader>()
            .ToTable(nameof(Posts), "dbo");

        modelBuilder.Entity<PostBody>()
            .ToTable(nameof(PostBodies), "dbo");

        modelBuilder.Entity<PostMetaTag>()
            .ToTable(nameof(PostMetaTags), "dbo");

        modelBuilder.Entity<PostRating>()
            .ToTable(nameof(PostRatings), "dbo");

        modelBuilder.Entity<PostSeen>()
            .ToTable(nameof(PostSeens), "dbo");

        modelBuilder.Entity<PostTag>()
            .ToTable(nameof(PostTags), "dbo");

        modelBuilder.Entity<PostType>()
            .ToTable(nameof(PostTypes), "dbo");

        modelBuilder.Entity<Profile>()
            .ToTable(nameof(Profiles), "dbo");

        modelBuilder.Entity<Tag>()
            .ToTable(nameof(Tags), "dbo");

        #endregion

        #region Content

        modelBuilder.Entity<MainPageSlider>()
            .ToTable(nameof(MainPageSliders), "cnt");

        #endregion

        base.OnModelCreating(modelBuilder);
    }
}

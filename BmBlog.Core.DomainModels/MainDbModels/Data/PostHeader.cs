namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class PostHeader : IDbTable, IAuditable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion



    public int MinutesToRead { get; set; }
    public DateTime PublishDate { get; set; }
    public bool IsPublished { get; set; }
    public float Rating { get; set; }
    public int RateCount { get; set; }

    #region Relations

    public int AuthorId { get; set; }
    public Profile Author { get; set; }

    public int PostBodyId { get; set; }
    public PostBody PostBody { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public ICollection<PostMetaTag> PostMetaTags { get; set; }

    #endregion

    #region IAuditable

    public int CreatedBy { get; set; }
    public DateTime CreatedTime { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedTime { get; set; }

    #endregion
}

namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class Comment : IDbTable, IAuditable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public string Text { get; set; }

    public int LikedCount { get; set; }
    public int DislikedCount { get; set; }

    #region Relations

    public int? ParentId { get; set; }
    public Comment? Parent { get; set; }

    public int PostHeaderId { get; set; }
    public PostHeader PostHeader { get; set; }

    public ICollection<Comment> Children { get; set; }
    public ICollection<CommentRating> CommentRatings { get; set; }

    #endregion

    #region IAuditable

    public int CreatedBy { get; set; }
    public DateTime CreatedTime { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedTime { get; set; }

    #endregion
}

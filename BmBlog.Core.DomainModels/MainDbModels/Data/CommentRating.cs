namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class CommentRating : IDbTable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public bool IsLiked { get; set; }

    #region Relations

    public int profileId { get; set; }
    public Profile profile { get; set; }

    public int CommentId { get; set; }
    public Comment Comment { get; set; }

    #endregion



}

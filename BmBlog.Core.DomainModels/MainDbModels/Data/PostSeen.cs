namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class PostSeen : IDbTable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public short SeenCount { get; set; }

    #region Relations

    public int ProfileId { get; set; }
    public Profile Profile { get; set; }

    public int PostHeaderId { get; set; }
    public PostHeader PostHeader { get; set; }

    #endregion

}

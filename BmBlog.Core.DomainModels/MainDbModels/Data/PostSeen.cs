namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class PostSeen : IDbTable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    //Properties

    #region Relations



    #endregion

}

namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class Tag : IDbTable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    //Properties

    #region Relations



    #endregion

}

﻿namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class PostType : IDbTable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    //Properties

    #region Relations



    #endregion

}

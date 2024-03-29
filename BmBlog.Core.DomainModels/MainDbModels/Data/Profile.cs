﻿namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class Profile : IDbTable, IAuditable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public string FirstName { get; set; }
    public string LastName { get; set; }



    #region Relations


    #endregion


    #region IAuditable

    public int CreatedBy { get; set; }
    public DateTime CreatedTime { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedTime { get; set; }

    #endregion
}

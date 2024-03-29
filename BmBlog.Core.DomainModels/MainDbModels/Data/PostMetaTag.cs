﻿namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class PostMetaTag : IDbTable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public string? MetaTagValue { get; set; }

    #region Relations

    public int PostHeaderId { get; set; }
    public PostHeader PostHeader { get; set; }

    public int? DefaultMetaTagId { get; set; }
    public DefaultMetaTag DefaultMetaTag { get; set; }

    #endregion



}

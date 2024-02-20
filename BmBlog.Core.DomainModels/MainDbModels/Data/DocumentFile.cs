namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class DocumentFile : IDbTable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public bool IsLargeFile { get; set; }
    public string Address { get; set; }

    #region Relations

    public int? DocumentLargeFileId { get; set; }
    public DocumentLargeFile? DocumentLargeFile { get; set; }

    public int? DocumentSmallFileId { get; set; }
    public DocumentSmallFile? DocumentSmallFile { get; set; }

    #endregion

}

public class DocumentLargeFile : IDbTable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public byte[] Content { get; set; }

    #region Relations

    public ICollection<DocumentFile> DocumentFiles { get; set; }

    #endregion

}

public class DocumentSmallFile : IDbTable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public byte[] Content { get; set; }

    #region Relations

    public ICollection<DocumentFile> DocumentFiles { get; set; }

    #endregion

}

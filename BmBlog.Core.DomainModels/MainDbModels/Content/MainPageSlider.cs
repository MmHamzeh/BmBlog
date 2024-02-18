﻿namespace BmBlog.Core.DomainModels.MainDbModels.Content;

public class MainPageSlider : IDbTable, IAuditable
{
    public int Id { get; set; }
    public Guid PublicId { get; set; }


    public int CreatedBy { get; set; }
    public DateTime CreatedTime { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedTime { get; set; }
}

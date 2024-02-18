
namespace BmBlog.Core.DomainModels.Common.Interfaces;

public interface IAuditable
{
    int CreatedBy { get; set; }
    DateTime CreatedTime { get; set; }
    int ModifiedBy { get; set; }
    DateTime ModifiedTime { get; set; }
}
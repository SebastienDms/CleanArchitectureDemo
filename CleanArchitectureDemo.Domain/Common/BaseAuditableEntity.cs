
namespace CleanArchitectureDemo.Domain.Common;

public abstract class BaseAuditableEntity : BaseEntity, IAuditableEntity
{
  public abstract int? CreatedBy { get; set; }
  public abstract DateTime? CreatedDate { get; set; }
  public abstract int? UpdatedBy { get; set; }
  public abstract DateTime? UpdatedDate { get; set; }
}

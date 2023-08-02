namespace Service.Models;

public class UserPermissionV2
{
    public bool IsNumeric { get; set; }
    public ICollection<SecurableAttributeType> SecurableAttributeTypes { get; set; }
}
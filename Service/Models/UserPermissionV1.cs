namespace Service.Models;

public class UserPermissionV1
{
    public string Area { get; set; }
    public string PermissionValue { get; set; }
    public IDictionary<string, IEnumerable<SecurableAttributeV1>>? SecurableAttributes { get; set; }
}
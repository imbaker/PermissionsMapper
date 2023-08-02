namespace Service.Models;

public class SecurableAttributeType
{
    public string DisplayName { get; set; }
    public string ExternalIdentifier { get; set; }
    public ICollection<SecurableAttributeV2> SecurableAttributes { get; set; }
}
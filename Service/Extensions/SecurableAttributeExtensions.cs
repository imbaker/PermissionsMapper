using Service.Models;

namespace Service.Extensions;

public static class SecurableAttributeExtensions
{
    private static readonly IDictionary<string, string> Dictionary = new Dictionary<string, string>()
    {
        { "zzzz", "3" },
        { "external", "internal" }
    };
    
    public static string ToRef(this string identifier)
    {
        if (Dictionary.TryGetValue(identifier, out string description))
        {
            return description;
        }

        return null;
    }

    public static UserPermissionV1 SetSecurableAttributes(this UserPermissionV1 v1Permission, string key, List<SecurableAttributeV1> securableAttributesList)
    {
        v1Permission.SecurableAttributes ??= new Dictionary<string, IEnumerable<SecurableAttributeV1>>() {{ key, securableAttributesList }};
        if (v1Permission.SecurableAttributes.TryGetValue(key, out var retValue ))
        {
            v1Permission.SecurableAttributes[key] = securableAttributesList;
        }
        else
        {
            v1Permission.SecurableAttributes.Add(key, securableAttributesList);
        }

        return v1Permission;
    }
    
}
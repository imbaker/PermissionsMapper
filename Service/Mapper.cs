using System.Diagnostics;
using Service.Extensions;
using Service.Models;

namespace Service;

public static class Mapper
{
    public static List<string> Example1(UserPermissionV1 v1Permission)
    {
        var results = new List<string>();
        var securableAttributes = v1Permission.SecurableAttributes;

        foreach (var item in securableAttributes)
        {
            results.Add(item.Value.ToString() ?? string.Empty);
        }

        return results;
    }

    public static List<string> Example2(UserPermissionV1 v1Permission)
    {
        var results = new List<string>();
        var securableAttributes = v1Permission.SecurableAttributes;

        if (securableAttributes != null && securableAttributes.Any())
        {
            foreach (var item in securableAttributes)
            {
                results.Add(item.Value.ToString() ?? string.Empty);
            }
        }

        return results;
    }

    public static List<string> Example3(UserPermissionV1 v1Permission)
    {
        var securableAttributes = v1Permission.SecurableAttributes ?? new Dictionary<string, IEnumerable<SecurableAttributeV1>>();

        return securableAttributes.Select(item => item.Value.ToString() ?? string.Empty).ToList();
    }
}
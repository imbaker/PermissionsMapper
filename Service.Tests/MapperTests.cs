using FluentAssertions.Execution;
using Service.Models;

namespace Service.Tests;

public class MapperTests
{
    [Fact]
    public void Example1_WhenV1PermissionContainsASecurableAttribute_ThenResultsContainsOneItem()
    {
        // Arrange
        var v1Permission = new UserPermissionV1()
        {
            Area = "area",
            PermissionValue = "permissionValue",
            SecurableAttributes = new Dictionary<string, IEnumerable<SecurableAttributeV1>>()
            {
                {
                    "Agent",
                    new List<SecurableAttributeV1>()
                        { new SecurableAttributeV1() { ExternalRef = "external", InternalRef = "internal" } }
                }
            }
        };
        
        // Act
        var sut = Mapper.Example1(v1Permission);
        
        // Assert
        sut.Should().HaveCount(1);
    }

    [Fact]
    public void Example1_WhenV1PermissionContainsNoSecurableAttributes_ThenResultsIsEmpty()
    {
        // Arrange
        var v1Permission = new UserPermissionV1()
        {
            Area = "area",
            PermissionValue = "permissionValue",
            SecurableAttributes = null
        };
        
        // Act
        var sut = Mapper.Example1(v1Permission);
        
        // Assert - this will fail
        sut.Should().HaveCount(0);
    }
    
    [Fact]
    public void Example2_WhenV1PermissionContainsASecurableAttribute_ThenResultsContainsOneItem()
    {
        // Arrange
        var v1Permission = new UserPermissionV1()
        {
            Area = "area",
            PermissionValue = "permissionValue",
            SecurableAttributes = new Dictionary<string, IEnumerable<SecurableAttributeV1>>()
            {
                {
                    "Agent",
                    new List<SecurableAttributeV1>()
                        { new SecurableAttributeV1() { ExternalRef = "external", InternalRef = "internal" } }
                }
            }
        };
        
        // Act
        var sut = Mapper.Example2(v1Permission);
        
        // Assert
        sut.Should().HaveCount(1);
    }

    [Fact]
    public void Example2_WhenV1PermissionContainsNoSecurableAttributes_ThenResultsIsEmpty()
    {
        // Arrange
        var v1Permission = new UserPermissionV1()
        {
            Area = "area",
            PermissionValue = "permissionValue",
            SecurableAttributes = null
        };
        
        // Act
        var sut = Mapper.Example2(v1Permission);
        
        // Assert
        sut.Should().HaveCount(0);
    }

    [Fact]
    public void Example3_WhenV1PermissionContainsASecurableAttribute_ThenResultsContainsOneItem()
    {
        // Arrange
        var v1Permission = new UserPermissionV1()
        {
            Area = "area",
            PermissionValue = "permissionValue",
            SecurableAttributes = new Dictionary<string, IEnumerable<SecurableAttributeV1>>()
            {
                {
                    "Agent",
                    new List<SecurableAttributeV1>()
                        { new SecurableAttributeV1() { ExternalRef = "external", InternalRef = "internal" } }
                }
            }
        };
        
        // Act
        var sut = Mapper.Example3(v1Permission);
        
        // Assert
        sut.Should().HaveCount(1);
    }

    [Fact]
    public void Example3_WhenV1PermissionContainsNoSecurableAttributes_ThenResultsIsEmpty()
    {
        // Arrange
        var v1Permission = new UserPermissionV1()
        {
            Area = "area",
            PermissionValue = "permissionValue",
            SecurableAttributes = null
        };
        
        // Act
        var sut = Mapper.Example3(v1Permission);
        
        // Assert
        sut.Should().HaveCount(0);
    }
}
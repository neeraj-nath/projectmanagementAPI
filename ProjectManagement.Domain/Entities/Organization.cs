///<summary>
/// Represents the Tenant Model : Individual Organization who would buy this application
///</summary>


using System;

namespace ProjectManagement.Domain.Entities;

internal sealed class Organization(Guid id, string name)
{
    public Guid Id { get; } = id;
    public string Name { get; } = name;
}

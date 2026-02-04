
/// Represents the Tenant Model
/// 
using System;

namespace ProjectManagement.Domain.Entities;

internal sealed class Organization(Guid id, string name)
{
    public Guid Id { get; } = id;
    public string Name { get; } = name;
}

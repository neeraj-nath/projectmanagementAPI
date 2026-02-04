using System;
using ProjectManagement.Domain.Enums;

namespace ProjectManagement.Domain.Entities;

internal class User(Guid id, Guid organizationId, OrganizationRole role) 
{
    public Guid Id { get; } = id;
    public Guid OrganizationId { get; } = organizationId;
    public OrganizationRole Role { get; } = role;

    public bool IsAdmin()
    {
        return Role == OrganizationRole.Admin;
    }
}

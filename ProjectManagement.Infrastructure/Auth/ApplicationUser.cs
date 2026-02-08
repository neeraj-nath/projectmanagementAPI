using System;
using Microsoft.AspNetCore.Identity;
using ProjectManagement.Domain.Enums;

namespace ProjectManagement.Infrastructure.Auth;

public class ApplicationUser : IdentityUser<Guid>
{
    // Following props in Identity context for generating claims.
    public Guid OrganizationId { get; set; } 
    public OrganizationRole Role { get; set; }
}

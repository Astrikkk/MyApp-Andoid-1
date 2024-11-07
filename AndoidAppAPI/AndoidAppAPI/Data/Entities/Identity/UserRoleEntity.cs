﻿using Microsoft.AspNetCore.Identity;

namespace AndoidAppAPI.Data.Entities.Identity
{
    public class UserRoleEntity : IdentityUserRole<int>
    {
        public virtual UserEntity User { get; set; } = new();
        public virtual RoleEntity Role { get; set; } = new();
    }
}

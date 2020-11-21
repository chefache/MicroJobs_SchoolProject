﻿// ReSharper disable VirtualMemberCallInConstructor
namespace MicroJobs.Data.Models
{
    using System;
    using System.Collections.Generic;

    using MicroJobs.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.UserSkills = new HashSet<UserSkill>();
            this.Jobs = new HashSet<Job>();
        }

        public string FirstName { get; set; }

        public string Lastname { get; set; }

        public string ImageId { get; set; }

        public virtual Image Image { get; set; }

        public int TownId { get; set; }

        public virtual Town Town { get; set; }

        public string WalletId { get; set; }

        public virtual Wallet Wallet { get; set; }

        public string PortfolioId { get; set; }

        public virtual Portfolio Portfolio { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }

        public virtual ICollection<UserSkill> UserSkills { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}

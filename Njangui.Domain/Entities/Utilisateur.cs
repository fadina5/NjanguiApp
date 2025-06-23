using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Njangui.Domain.Enum;

namespace Njangui.Domain.Entities
{
    public class Utilisateur
    {
        public Guid Id{ get; set; }
        public required string Mail { get; set; }
        public required string PasswordHash { get; set; }

        public required string FullName { get; set; }
        public required string PhoneNumber	 { get; set; }
        public bool IsVerified { get; set; }

        public Role Role{ get; set; }
        private DateTime CreatedAt { get; set; }
    }
}
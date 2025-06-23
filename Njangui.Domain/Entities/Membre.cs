using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Njangui.Domain.Entities
{
    public class Membre
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required string FullName { get; set; }
        public required string PhoneNumber { get; set; }

        public bool IsActive { get; set; }
        public Guid TontineId { get; set; }     

        public bool HasReceivedTour { get; set; }
    }
}
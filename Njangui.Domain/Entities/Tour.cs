using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Njangui.Domain.Entities
{
    public class Tour
    {
        public Guid Id { get; set; }
        public int Order { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Guid TontineId { get; set; }

        public Guid BeneficiaryId { get; set; }

        public TourStatut Status { get; set; }

        private DateTime CreatedAt { get; set; }

        private DateTime? ClosedAt  { get; set; }
        
    }
}
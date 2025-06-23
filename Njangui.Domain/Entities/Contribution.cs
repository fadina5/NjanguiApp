using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Njangui.Domain.Enum;

namespace Njangui.Domain.Entities
{
    public class Contribution
    {
        public Guid Id { get; set; }
        public Guid TourId	{ get; set; }
public Guid MembreId	 { get; set; }
public decimal Montant { get; set; }
public DateTime PaymentDate	{ get; set; }
public ContributionStatut Statut { get; set; }
public Guid? ValidatedBy { get; set; }
public DateTime CreatedAt { get; set; }
    }
}
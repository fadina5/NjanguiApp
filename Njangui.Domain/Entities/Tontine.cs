using Njangui.Domain.Entities;

namespace Njangui.Domain;

public class Tontine
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Membre> Membres { get; set; } = [];

    public List<Tour> Tours { get; set; } = [];
    
    private DateTime CreatedAt { get; set; }
}

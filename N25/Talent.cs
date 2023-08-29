namespace N25;

public class Talent
{
    public Guid Id { get; set; }

    public TalentLevel Level { get; set; }

    // Eski usul
    // public string Level { get; set; } // Intern, intern, InTeRn, INTERn
    public string Stack { get; set; }
    public Guid UserId { get; set; }

    public Talent(TalentLevel talentLevel, string stack, Guid userId)
    {
        Id = Guid.NewGuid();
        Level = talentLevel;
        Stack = stack;
        UserId = userId;
    }
}
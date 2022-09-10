using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Technology:Entity
{
    public int ProgrammingLanguageId { get; set; }
    
    public string Name { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public ProgrammingLanguage? ProgrammingLanguage { get; set; }

    public Technology()
    {
    }

    public Technology(int id, int programmingLanguageId, string name, string description, string ımageUrl):this()
    {
        Id = id;
        ProgrammingLanguageId = programmingLanguageId;
        Name = name;
        Description = description;
        ImageUrl = ımageUrl;
    }
}
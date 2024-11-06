using PetStoreApi.Services.AnimalService.ViewModels;

namespace PetStoreApi.Entities;

public class Animal : BaseEntity
{
    public int Price { get; set; }
    public string Kind { get; set; } = "";
    public string Name { get; set; } = "";
    public int? OwnerId { get; set; }
    public Account? Owner { get; set; }

    public string GetNameTag()
    {
        return $"{Name} - {Owner?.ToString()}";
    }

    public override string ToString()
    {
        return $"Id: {Id}; Price: {Price}; Kind: {this.GetType().Name}";
    }

    public static bool operator ==(Animal? x, Animal? y)
    {
        return x?.Kind == y?.Kind;
    }

    public static bool operator !=(Animal? x, Animal? y)
    {
        return x?.Kind != y?.Kind;
    }

    public override bool Equals(object? obj)
    {
        return (obj is Animal a) && a.GetHashCode() == GetHashCode();
    }

    public override int GetHashCode()
    {
        return Kind.GetHashCode() ^ Name.GetHashCode() ^ Id.GetHashCode() ^ Price.GetHashCode();
    }

    public AnimalView ToView()
    {
        return new AnimalView(Kind, Name, Owner?.EmailAddress, Price);
    }
}
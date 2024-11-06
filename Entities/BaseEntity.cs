using Microsoft.EntityFrameworkCore;

namespace PetStoreApi.Entities;

[Index(nameof(Id), IsUnique = true)]
public class BaseEntity
{
    public int Id { get; set; }
}

namespace Data.Entities;

public class UserAccount
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }
    
    public string? AddressId { get; set; }

    public UserAddress? Address { get; set; }
}

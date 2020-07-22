using System;

namespace Users_API.Data
{
  public class User
  {
    public Guid Id { get; private set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string UserName { get; private set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string ImagePath { get; set; }


    private User(){}

    public static User Create(string firstName, string lastName, string userName, string email, string password, string imagePath)
    {
      return new User
      {
        Id = Guid.NewGuid(),
        FirstName = firstName,
        LastName = lastName,
        UserName = userName,
        Email = email,
        Password = password,
        ImagePath = imagePath

      };
    }

  }
}

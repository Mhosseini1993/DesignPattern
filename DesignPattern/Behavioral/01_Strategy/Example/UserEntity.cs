using System.Text.RegularExpressions;

namespace DesignPattern.Behavioral._01_Strategy.Example
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Credit { get; set; }
        public override string ToString()
        {
            return $"ID : {Id} firstName : {FirstName} LastName: {LastName} Credit : {Credit}";
        }

        public static UserEntity[] GetUsers()
        {
            var users = Enumerable.Range(1, 3).Select(ef => new UserEntity()
            {
                Id=ef,
                FirstName=$"Mostafa : {ef}",
                LastName=$"Hossein : {ef}",
                Credit=Random.Shared.Next(1000, 100000)
            }).ToArray();

            return users;
        }
    }
}

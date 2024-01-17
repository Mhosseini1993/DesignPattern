namespace DesignPattern.Behavioral._01_Strategy.Example
{
    public class UserEntityClient
    {
        public static void Run()
        {
            UserEntity[] userEntities = UserEntity.GetUsers();
            
            Console.WriteLine("Before sort");
            Display(userEntities);

            Console.WriteLine("Sort by Id");
            Array.Sort(userEntities, new UserEntityIdComparer());
            Display(userEntities);

            Console.WriteLine("Sort by FirstName");
            Array.Sort(userEntities, new UserEntityFirstNameComparer());
            Display(userEntities);

            Console.WriteLine("Sort by Credit");
            Array.Sort(userEntities, new UserEntityCreditComparer());
            Display(userEntities);
        }
        private static void Display(UserEntity[] entities)
        {
            foreach (var entity in entities)
            {
                entity.ToString();
            }
        }
    }
}

namespace DesignPattern.Behavioral._01_Strategy.Example
{
    public class UserEntityFirstNameComparer : IComparer<UserEntity>
    {
        public int Compare(UserEntity? x, UserEntity? y)
        {
            return string.Compare(x.FirstName, y.FirstName);
        }
    }
}

namespace DesignPattern.Behavioral._01_Strategy.Example
{
    public class UserEntityIdComparer : IComparer<UserEntity>
    {
        public int Compare(UserEntity? x, UserEntity? y)
        {
            return string.Compare(x.Id.ToString(), y.Id.ToString());
        }
    }
}

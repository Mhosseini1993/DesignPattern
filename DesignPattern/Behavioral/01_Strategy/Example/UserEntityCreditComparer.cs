namespace DesignPattern.Behavioral._01_Strategy.Example
{
    public class UserEntityCreditComparer : IComparer<UserEntity>
    {
        public int Compare(UserEntity? x, UserEntity? y)
        {
            return string.Compare(x.Credit.ToString(), y.Credit.ToString());
        }
    }
}

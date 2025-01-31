namespace NullObject.AccountModel
{
    public class NullAccount : IAccount
    {
        public int Id => -1;

        public string Name => "Null account";
    }
}

namespace NullObject.AccountModel
{
    public class Account : IAccount
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;
    }
}

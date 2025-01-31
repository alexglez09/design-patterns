using NullObject.AccountModel;

namespace NullObject.Repository
{
    public interface IAccountRepository
    {
        IAccount FindOne(int accountId);
    }

    public class AccountRepository : IAccountRepository
    {
        private readonly IList<Account> accounts = new List<Account>
        {
            new() { Id = 1, Name = "a1" },
            new() { Id = 2, Name = "a2" }
        };

        public IAccount FindOne(int accountId)
        {
            var account = accounts.FirstOrDefault(l => l.Id == accountId);

            if (account == default)
            {
                return new NullAccount();
            }

            return account;
        }
    }
}

using NullObject.Repository;

namespace NullObject
{
    public class Runner
    {
        public string Run(int accountId)
        {
            IAccountRepository accountRepository = new AccountRepository();

            var account = accountRepository.FindOne(accountId);

            return account.Name;
        }
    }
}

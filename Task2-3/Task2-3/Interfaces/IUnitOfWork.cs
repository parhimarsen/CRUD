namespace Task2_3.Interfaces
{
    public interface IUnitOfWork
    {
        IClientService Clients { get; }

        IAccountService Accounts { get; }
    }
}

namespace Course.entities.Exception
{
    internal class AccountException : ApplicationException
    {
        public AccountException(string Message): base(Message) { }
    }
}

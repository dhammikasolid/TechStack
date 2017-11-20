namespace DomainServices
{
    public class Service2000 : BaseService2000, IService2000
    {
        public int Add2000(int input)
        {
            return 1000 + input;
        }
    }
}
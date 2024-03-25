namespace ViewData.Repository
{
    public class DemoService : IDemo
    {
        public string GetGuard()
        {
            //return "I came from DemoService";
            throw new System.Exception("This is a exception message");
        }
    }
}

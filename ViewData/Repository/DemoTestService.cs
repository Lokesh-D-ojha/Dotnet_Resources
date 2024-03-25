namespace ViewData.Repository
{
    public class DemoTestService : IDemo
    {
        public new string GetGuard()
        {
            return "I came from DemoTestService";
        }
    }
}

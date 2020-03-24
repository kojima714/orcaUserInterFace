namespace OrcaClient {
    public interface IShell
    {
        string Name { get; set; }
        bool CanSayHello { get; }
        void SayHello();
    }
}
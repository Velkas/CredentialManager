namespace AdysTech.CredentialManager
{
    public enum CredentialType : uint
    {
        Generic = 1,
        Windows = 2,
        Certificate = 3
    }

    public enum Persistence : uint
    {
        Session = 1,
        LocalMachine = 2,
        Enterprise = 3
    }
}

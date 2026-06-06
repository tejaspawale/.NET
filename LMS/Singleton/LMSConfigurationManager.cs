namespace Singleton.LMSConfigurationManager;

public sealed class LMSConfigurationManager
{
    private static LMSConfigurationManager instance;

    private LMSConfigurationManager()
    {
        InstituteName = "ABC Institute";
        Version = "1.0";
        AdminContact = "admin@abc.com";
    }

    public string InstituteName { get; set; }

    public string Version { get; set; }

    public string AdminContact { get; set; }

    public static LMSConfigurationManager GetInstance()
    {
        if (instance == null)
        {
            instance = new LMSConfigurationManager();
        }

        return instance;
    }
}
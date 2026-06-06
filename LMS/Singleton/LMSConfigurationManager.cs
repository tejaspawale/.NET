namespace Singleton.LMSConfigurationManager;

public sealed class LMSConfigurationManager
{
    private static LMSConfigurationManager instance;

    private LMSConfigurationManager()
    {
        InstituteName = "Tap";
        Version = "2.0";
        AdminContact = "Transflower@gmail..com";
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
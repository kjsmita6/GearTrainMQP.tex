private static GearBoxSettings instance = null;
public static GearBoxSettings Instance
{
    get
    {
        lock (statelock)
        {
            if (instance == null)
            {
                instance = new GearBoxSettings();
            }
            return instance;
        }
    } private set { }
}
private static readonly object statelock = new object();
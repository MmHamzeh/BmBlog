namespace BmBlog.Shared.Services;

public static class ApplicationSetting
{
    public static bool IsDebugMode
    {
        get
        {
#if DEBUG
            return true;
#else   
            return false;
#endif
        }
    }
}

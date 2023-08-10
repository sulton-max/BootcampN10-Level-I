namespace N17.StaticClass;

public static class MessageConstants
{
    public const string UserToken = "{{User}}";
    public const string AppToken = "{{App}}";

    public static string RemoveTokens(string template)
    {
        return template.Replace(UserToken, "").Replace(AppToken, "");
    }
}
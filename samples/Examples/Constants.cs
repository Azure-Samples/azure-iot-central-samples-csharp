namespace Examples {
    public class Constants
    {
        // Need to be replaced after running CLI
        public const string ClientApplicationId = "{AadApplicationId}";

        // Need to be replaced after running CLI
        public const string TenantId = "{TenantId}";

        // Need to be replaced after running CLI
        public const string AppName = "{APP_NAME}";

        public const string ApiVersion = "2022-07-31";

        public const string TestStandardDeviceTemplateId = "dtmi:modelDefinition:e2eStandard;1";

        public static string[] Scopes = new []{ "https://apps.azureiotcentral.com/.default" };
    }
}
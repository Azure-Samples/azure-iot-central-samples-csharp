---
page_type: sample
languages:
- csharp
products:
- dotnet
description: "This sample shows you how to interact with Azure IoT Central APIs"
urlFragment: "update-this-to-unique-url-stub"
---

# Azure IoT Central Samples
This sample shows you how to interact with Azure IoT Central APIs in C#. 
If you have any questions or feature requests, please create new issue with detailed infomation.

## Contents

| File/folder       | Description                                |
|-------------------|--|
| `SDK`      | Auto-generate C# REST client from the swagger|
| `samples`         | Each sample app that interats with single IoT Central API |
| `.gitignore`      | Define what to ignore at commit time.        |
| `README.md`       | This README file.                            |
| `LICENSE`         | The license for the sample.                  |

## Prerequisites

- [.NET Core 6.0](https://dotnet.microsoft.com/download)

## Running the sample in `Examples` folder
1. Make sure [Azure CLI](https://docs.microsoft.com/cli/azure/install-azure-cli?view=azure-cli-latest) has been installed on your dev machine.
2. In console window, run below command to login:

    ```cmd
    az login
    az extension add --name azure-iot
    ```

3. Setup application name
    ```cmd
    APP_NAME = "fleet-manager-$RANDOM"
    echo "Your application name is: $APP_NAME"
    ```

4. Create Azure IoT Central Application from CLI
    ```cmd
    az iot central app create \
        --resource-group [resource group name] \
        --name $APP_NAME --sku ST2 --location centralus \
        --subdomain $APP_NAME --template iotc-pnp-preview \
        --display-name 'Fleet management' 
    ```
5. Register Azure AAD Application
    ```cmd
    aadAppId=$(az ad app create --display-name fleetapp --required-resource-accesses @manifest.json --is-fallback-public-client true --public-client-redirect-uris http://localhost --sign-in-audience AzureADmyOrg | grep -oP '
    (?<="appId": ")[^"]*')
    ```
6. Grant Admin Consent
    ```cmd
    az ad app permission admin-consent --id $aadAppId
    ```
5. Show the required variables from following command
    ```cmd
    echo $tenantId $aadAppId $APP_NAME
    ```
6. Replace from `Examples/Constants.cs` with the results returned from above command line
    ```csharp
        public const string ClientApplicationId = "{aadAppId}"

        public const string TenantId = "{tenantId}";

        public const string AppName = "{APP_NAME}";
    ```

## Running the sample in `samples\Examples` folder

1. Uncomments line by line from following code in `Program.cs`
    ```csharp
            // UserOrgExample.Run(centralClient, options);
            // DeviceTemplateExample.Run(centralClient, options);
            // DeviceExample.Run(centralClient, options);
            // FileUploadExample.Run(centralClient, options);
            // DeviceGroupExample.Run(centralClient, options);
            // EnrollmentGroupExample.Run(centralClient, options);    
    ```

2. In the terminal, type and run `dotnet run`.

## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

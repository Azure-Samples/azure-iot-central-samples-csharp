---
page_type: sample
languages:
- csharp
products:
- dotnet
description: "This sample shows you how to interact with Azure IoT Central APIs"
urlFragment: "update-this-to-unique-url-stub"
---

# Azure IoT Central Sample
This sample shows you how to interact with Azure IoT Central APIs in C#.

## Contents

| File/folder       | Description                                |
|-------------------|--|
| `IoTCentral`      | Auto-generate C# REST client from the swagger|
| `samples`         | Sample apps that interats with IoT Central   |
| `.gitignore`      | Define what to ignore at commit time.        |
| `README.md`       | This README file.                            |
| `LICENSE`         | The license for the sample.                  |

## Prerequisites

- [.NET Core 3.0](https://dotnet.microsoft.com/download)

## Runnning the sample

1. Follow the [steps to create an Azure IoT Central application](https://docs.microsoft.com/azure/iot-central/core/quick-deploy-iot-central)

2. Generate an IoT Central API token.
    - Navigate to **Administration** then **Access Tokens**.
    - Select **Generate Token**.
    - Enter a Token name, select **Next**, and then **Copy**.
    > The token value is only shown once, so it must be copied before closing the dialog. After closing the dialog, it is never shown again.

3. Navigate to `samples/listApplication` folder in your terminal. This app can list the IoT Central applications you have access to.

    ```cmd
    cd samples/listApplication
    ```

4. Update the following placeholders in the sample app.

    - `[ACCESS_TOKEN]`, replace with the API token you generated from last step.
    - `https://[APP_NAME].azureiotcentral.com/api/preview`, replace the `[APP_NAME]` with the app name in your IoT Central app URL.

4. In the terminal, type and run `dotnet run`.

5. Change directory into the sample app you want to run. Repeat step 4 and 5. You might also need to update other placeholders like `deviceID`, `MyDisplayName` and etc. based on the app you selected.

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

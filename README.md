# MyApp "TLT GARequestCenterAPI" v1.0.0 (AGPLv3 Compliance Release)

This is the open-source release of MyApp version 1.0.0, which used the iText PDF library under the AGPLv3 license.  
This source code is published in accordance with the AGPLv3 requirements.

## What’s Included
- The full source code of the production version using iText
- Build files and basic configuration for local compilation
- PDF-related functionality remains intact
- Sensitive and unrelated configuration (e.g., API keys, API endpoint, partner info, Credential) have been removed

## How to Build
1. Clone this repository
2. Ensure you have [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed
3. Navigate to the project directory
4. Run the following command to restore dependencies and build the project:
   ```bash
   dotnet restore
   dotnet build --configuration Release
   ```
5. To run the application locally:
   ```bash
   dotnet run --project ./GARequestCenterAPI.csproj
   ```

## License
This project is licensed under the GNU AGPLv3. See LICENSE file for full text.

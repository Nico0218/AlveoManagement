//using Google.Apis.Auth.OAuth2;
//using Google.Apis.Services;
//using Google.Apis.Sheets.v4;
//using Google.Apis.Sheets.v4.Data;
//using Microsoft.Extensions.Logging;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//namespace GoogleSheets
//{
//    public class GoogleSheetsService : IGoogleSheetsService
//    {
//        //https://medium.com/@semuserable/net-core-google-sheets-api-read-write-5edd919868e3
//        private static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
//        private static SheetsService sheetsService;
//        private readonly ILogger<GoogleSheetsService> logger;
//        private const string SpreadsheetId = "1g_mNkWaOS1y1dAz3zqQlG2tNpRvJQqSmjnsjQa1Ny0M";
//        private const string GoogleCredentialsFileName = "./My First Project-814e97df534e.json";
//        /*
//           Sheet1 - tab name in a spreadsheet
//           A:B     - range of values we want to receive
//        */
//        private const string ReadRange = "Todo!A:C";
//        private const string WriteRange = "A5:C5";

//        public GoogleSheetsService(ILogger<GoogleSheetsService> logger)
//        {
//            this.logger = logger;
//            sheetsService = GetSheetsService();
//        }

//        private SheetsService GetSheetsService()
//        {
//            using (dvar stream = new FileStream(GoogleCredentialsFileName, FileMode.Open, FileAccess.Read))
//            {
//                var serviceInitializer = new BaseClientService.Initializer
//                {
//                    HttpClientInitializer = GoogleCredential.FromStream(stream).CreateScoped(Scopes)
//                };
//                return new SheetsService(serviceInitializer);
//            }

//        }

//        public ValueRange ReadSheet()
//        {
//            SpreadsheetsResource.ValuesResource valuesResource = sheetsService.Spreadsheets.Values;

//            ValueRange response = valuesResource.Get(SpreadsheetId, ReadRange).ExecuteAsync().Result;
//            var values = response.Values;
//            if (values == null || !values.Any())
//            {
//                logger.LogDebug("No data found.");
//                return new ValueRange();
//            }
//            return response;
//        }

//        public void WriteToSheet()
//        {
//            SpreadsheetsResource.ValuesResource valuesResource = sheetsService.Spreadsheets.Values;
//            var valueRange = new ValueRange { 
//                Values = new List<IList<object>> { 
//                    new List<object> { 
//                        "1",
//                        "10",
//                        "Test"
//                    } 
//                } 
//            };
//            var update = valuesResource.Update(valueRange, SpreadsheetId, WriteRange);
//            update.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
//            UpdateValuesResponse response = update.ExecuteAsync().Result;
//        }
//    }
//}

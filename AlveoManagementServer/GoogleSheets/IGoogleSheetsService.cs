using Google.Apis.Sheets.v4.Data;

namespace GoogleSheets
{
    public interface IGoogleSheetsService
    {
        ValueRange ReadSheet();

        void WriteToSheet();
    }
}

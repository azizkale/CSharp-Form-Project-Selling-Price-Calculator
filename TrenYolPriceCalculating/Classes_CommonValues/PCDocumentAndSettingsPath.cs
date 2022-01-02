using System;


namespace TrenYolPriceCalculating.Classes_CommonValues
{
    public static class PCDocumentAndSettingsPath
    {
        public static string DocumentsAndSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static string filePath = DocumentsAndSettingsPath + "\\Ürünler.xls";
    }
}

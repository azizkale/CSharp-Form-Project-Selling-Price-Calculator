using System;
using System.IO;

namespace TrenYolPriceCalculating.Classes_CommonValues
{
   
    public static class PCDocumentAndSettingsPath
    { 
        // the path of the file Document&Settings in PC and of this app in which the app is set
        public static string DocumentsAndSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string filePath = DocumentsAndSettingsPath + "\\Ürünler.xls";        
    }

   
}

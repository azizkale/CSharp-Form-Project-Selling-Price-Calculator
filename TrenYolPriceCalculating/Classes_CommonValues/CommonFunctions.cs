using System.IO;

namespace TrenYolPriceCalculating.Classes_CommonValues
{
    public static class CommonFunctions
    {
        //it controls if the file that is wanted to create is already exist=====
        public static bool controlTheFileExistBeforeInsertProduct(string path)
        {
            return File.Exists(path);
        }
    }
}

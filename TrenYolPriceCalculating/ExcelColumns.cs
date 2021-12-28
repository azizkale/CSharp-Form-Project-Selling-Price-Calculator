using System.Data;

namespace TrenYolPriceCalculating
{
    class ExcelColumns
    {
        public DataTable createExcelColumns(DataTable tbl)
        {
            tbl.Columns.Add("Ürün Adı", typeof(string));
            tbl.Columns.Add("Alış Fiyatı", typeof(decimal));
            tbl.Columns.Add("Trendyol Komisyon Oranı", typeof(decimal));
            tbl.Columns.Add("Trendyol Komisyon Tutarı", typeof(decimal));
            tbl.Columns.Add("KDV Oranı", typeof(decimal));
            tbl.Columns.Add("KDV Tutarı", typeof(decimal));
            tbl.Columns.Add("Kargo Gideri", typeof(decimal));
            tbl.Columns.Add("Kar Oranı", typeof(decimal));
            tbl.Columns.Add("Kar Tutarı", typeof(decimal));
            tbl.Columns.Add("SATIŞ FİYATI", typeof(decimal));
            return tbl;
        }
    }
}

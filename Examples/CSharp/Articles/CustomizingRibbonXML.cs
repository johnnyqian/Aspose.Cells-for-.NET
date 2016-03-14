using System.IO;

using Aspose.Cells;

namespace Aspose.Cells.Examples.Articles
{
    public class CustomizingRibbonXML
    {
        public static void Main()
        {
            //ExStart:1
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            Workbook wb = new Workbook(dataDir+ "aspose-sample.xlsx");
            FileInfo fi = new FileInfo(dataDir+ "CustomUI.xml");
            StreamReader sr = fi.OpenText();
            wb.RibbonXml = sr.ReadToEnd();
            sr.Close();
            //ExEnd:1
            
            
        }
    }
}

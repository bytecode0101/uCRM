using System.IO;

namespace StockManagement
{
    /// <summary>
    /// Product database serialization class, used to save our product DB in external files
    /// </summary>
    public class PDBSerialisation
    {
        string prodDB = "ProductDatabase.csv";
        Stream stream;

        public void LoadList(Product pobj)
        {

        }

        public void UnloadList(Product pobj)
        {
            using(StreamWriter swo = new StreamWriter(stream, swo.Encoding))
            {
                swo.WriteLine(pobj.Name + " , " + pobj.Category + " , " + pobj.SubCategory + " , " + pobj.Amount + " , " + pobj.Status + " , " + pobj.Id + " , " + pobj.ExtraInfo);
                swo.Flush();
               
            }
        }
    }
}

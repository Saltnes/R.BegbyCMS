using System.Data;
using DBLayer;

namespace BusinessLayer
{
    public class Blayer
    {
        public string Content1()
        {
            var dbl = new DbLayer();
            return dbl.GetWebContent();
        }

        public void SaveWebContent1(string content)
        {
            var dbl = new DbLayer();
            dbl.SaveWebContent1(content);
        }
    }
}
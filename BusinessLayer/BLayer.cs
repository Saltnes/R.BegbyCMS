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
        
        public string Content2()
        {
            var dbl = new DbLayer();
            return dbl.GetWebContent2();
        }

        public void SaveWebContent1(string content)
        {
            var dbl = new DbLayer();
            dbl.SaveWebContent1(content);
        }
        
        public void SaveWebContent2(string content)
        {
            var dbl = new DbLayer();
            dbl.SaveWebContent2(content);
        }
    }
}
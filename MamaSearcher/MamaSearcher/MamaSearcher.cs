using System;
using System.Collections.Generic;
using System.Text;

namespace MamaSearcher
{
    public class MamaSearcher : IMamaSearcher
    {
        Dictionary<string, Action<int, string>> patternDict = new Dictionary<string, Action<int, string>>();
        
        
        public void PerformSearch(string content)
        {
            foreach (var item in patternDict)
            {
                string temp = item.Key;
                if(content.Contains(temp))
                {
                    int index = content.IndexOf(temp);
                    patternDict[temp](index, item.Key);
                }
                
            }
            
        }

        public void Subscribe(string pattern, Action<int, string> actionToPreform)
        {
            
            patternDict.Add(pattern, actionToPreform);
        }

        

    }
}

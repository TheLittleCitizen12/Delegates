using System;
using System.Collections.Generic;
using System.Text;

namespace MamaSearcher
{
    public interface IMamaSearcher
    {
        void Subscribe(string pattern, Action<int, string> actionToPreform);
        void PerformSearch(string content);

    }
}

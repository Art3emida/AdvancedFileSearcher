using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFileSearcher
{
    /**
     * Класс для результатов поиска
     */
    public class FoundItem
    {
        public string Path { get; private set; }

        public FoundItem(string path)
        {
            Path = path;
        }

        public override string ToString()
        {
            return Path;
        }
    }
}

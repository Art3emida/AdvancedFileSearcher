using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFileSearcher
{
    /**
     * Класс для событий прогресса ProgressWorker
     */
    class ProgressEventArgs
    {
        public double Progress { get; private set; }
        public string Status { get; private set; }

        public ProgressEventArgs(string status, double progress)
        {
            Status = status;
            Progress = progress;
        }
    }
}

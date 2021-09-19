using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace AdvancedFileSearcher
{
    class Engine
    {
        // Поля
        public delegate void ProgressUpdateHandler(object sender, ProgressEventArgs e);
        public event ProgressUpdateHandler Progressed;
        public static DateTime StartTime = DateTime.Now;
        public string InputPath { get; private set; }
        public bool SubMode { get; private set; }
        public string FilesType { get; private set; }
        public string CondsData { get; private set; }
        public int FilesCount = 0;
        public int ThreadsAmount = 1;
        public static int StatFounded = 0;
        public static int StatFiles = 0;
        public static int Progress = 0;
        public static string Command = "none";
        public static int SpeedValue = 0;
        public static int SpeedProgress = 0;

        // Конструктор
        public Engine(string inputPath, bool subMode, string filesType, string condsData)
        {
            InputPath = inputPath;
            SubMode = subMode;
            FilesType = filesType;
            CondsData = condsData;
            Progress = 0;
            StatFounded = 0;
            StatFiles = 0;
        }

        // Команды
        public static void Stop()
        {
            Command = "stop";
        }
        public static void Pause()
        {
            Command = "pause";
        }
        public static void Continue()
        {
            Command = "continue";
        }

        // Запуск
        public void Start()
        {
            if (!Directory.Exists(InputPath))
            {
                Utils.ShowMessage("Выбран некорректный путь к файлам.");
                UpdateProgress("Поиск отменен.", 100);
                return;
            }
            Command = "start";
            StartTime = DateTime.Now;
            UpdateProgress("Поиск файлов...", 0);
            SearchFiles();
            DateTime CurrertTime = DateTime.Now;
            TimeSpan ExecuteTime = CurrertTime - StartTime;
            if (Command == "stop") UpdateProgress("Поиск отменен.", 100);
            else UpdateProgress(string.Format(@"Поиск завершен. Обработано: {2}. Совпадений: {1}. Затрачено времени: {0}.", ExecuteTime.ToString("hh':'mm':'ss"), StatFounded, StatFiles), 100);
        }

        // Коллбэк таймера
        public static void CheckSpeed()
        {
            SpeedValue = Progress - SpeedProgress;
            SpeedProgress = Progress;
            if (SpeedValue < 0) SpeedValue = 0;
        }

        // Загрузка поиска
        private void SearchFiles()
        {
            string[] Files = Directory.GetFiles(InputPath, "*" + FilesType, SubMode ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            int Count = Files.Length;
            if (Count == 0)
            {
                Utils.ShowMessage("Отсутствуют файлы. Поиск невозможен!");
                Command = "stop";
                return;
            }
            FilesCount = Count;
            Files.AsParallel().WithDegreeOfParallelism(ThreadsAmount).ForAll(FileSearch);
            Files = null;
        }

        // Поиск в файле
        private void FileSearch(string path)
        {
            while (Command == "pause") Thread.Sleep(1000);
            if (Command == "stop") return;
            try
            {
                if (ContentIsValid(File.ReadAllText(path), CondsData))
                {
                    Results.FoundList.Add(path, new FoundItem(path));
                    StatFounded++;
                }
                Progress++;
                StatFiles++;
                DateTime CurrertTime = DateTime.Now;
                TimeSpan ExecuteTime = CurrertTime - StartTime;
                UpdateProgress(string.Format(@"Поиск файлов: {0} из {1}. Совпадений: {4}. Скорость: {3}/с. Прошло времени: {2}.",
                    Progress, FilesCount, ExecuteTime.ToString("hh':'mm':'ss"), SpeedValue, StatFounded), (((double)Progress / FilesCount) * 100));
            }
            catch (Exception e)
            {
                Utils.ShowMessage("Error: " + e.Message + " [" + path + "]");
            }
        }

        // Определение подходит ли содержимое файла под критерии поиска
        public static bool ContentIsValid(string fileText, string conds)
        {
            bool fileCond = false;
            if (!string.IsNullOrEmpty(conds))
            {
                string[] condsList = conds.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string condItem in condsList)
                {
                    int matches = 0;
                    string[] andVars = condItem.Split(new string[] { "[AND]" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string andVar in andVars)
                    {
                        if (Utils.FindText(fileText, andVar))
                        {
                            matches++;
                        }
                    }
                    if (matches == andVars.Length)
                    {
                        fileCond = true;
                        break;
                    }
                }
            }
            return fileCond;
        }

        // Апдейт прогресса для элемента ProgressWorker
        private void UpdateProgress(string status, double progress)
        {
            if (progress > 100) progress = 100;
            var args = new ProgressEventArgs(status, progress);
            Progressed(this, args);
        }
    }
}

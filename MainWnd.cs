using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using AdvancedFileSearcher.Properties;

namespace AdvancedFileSearcher
{
    public partial class MainWnd : Form
    {
        public bool ProgressActive = false;
        public bool PauseActive = false;

        public MainWnd()
        {
            InitializeComponent();
            ProgressStatus.Text = "Программа ждет запуска ...";
        }

        // Клик по кнопке запуска
        private void ButtonStartClick(object sender, EventArgs e)
        {
            if (ProgressActive)
            {
                ProgressActive = false;
                Engine.Stop();
                ProgressWorker.CancelAsync();
                ButtonStart.Text = "Начать поиск";
                ButtonStart.Width = (ButtonPause.Location.X - ButtonStart.Location.X) + 388;
                ButtonPause.Text = "Пауза";
                ButtonPause.Enabled = false;
                ButtonPause.Hide();
            }
            else
            {
                PauseActive = false;
                ProgressActive = true;
                ProgressWorker.RunWorkerAsync();
                ButtonStart.Text = "Отмена";
                ButtonStart.Width = (ButtonPause.Location.X - ButtonStart.Location.X) - 3;
                ButtonPause.Show();
                ButtonPause.Enabled = true;
            }
        }

        // Клик по кнопке паузы
        private void ButtonPauseClick(object sender, EventArgs e)
        {
            if (PauseActive)
            {
                Engine.Continue();
                PauseActive = false;
                ButtonPause.Text = "Пауза";
            }
            else
            {
                Engine.Pause();
                PauseActive = true;
                ButtonPause.Text = "Продолжить";
            }
        }

        // Клик по кнопке выбора рабочей папки
        private void ButtonBrowseInputPathClick(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Укажите путь к каталогу для поиска в нем";
            folderBrowserDialog.SelectedPath = InputPath.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                InputPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        // Событие запуска ProgressWorker
        private void ProgressWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            FoundList.Items.Clear();
            Results.FoundList = new Dictionary<string, FoundItem>();
            ButtonCopyFiles.Enabled = false;
            Engine ct = new Engine(InputPath.Text, SubMode.Checked, FilesType.Text, CondsData.Text);
            ct.Progressed += SendProgressStatus;
            ct.Start();
        }

        // Событие обновления ProgressWorker
        private void ProgressWorkerChanged(object sender, ProgressChangedEventArgs e)
        {
            int percent = e.ProgressPercentage;
            string status = e.UserState.ToString();
            ProgressBar.Value = percent;
            ProgressStatus.Text = status;
            this.Text = "Прогресс: " + percent + "%";
            if (Utils.FindText(status, "Поиск отменен")) this.Text = "Advanced File Searcher";
            if (Utils.FindText(status, "Поиск завершен") || Utils.FindText(status, "Поиск отменен"))
            {
                if (Utils.FindText(status, "Поиск завершен"))
                {
                    if (Results.FoundList.Count > 0)
                    {
                        foreach (var Key in Results.FoundList.Keys)
                        {
                            FoundItem Item = Results.FoundList[Key];
                            FoundList.Items.Add(new FoundItem(Item.Path));
                        }
                        TimeSpan ExecuteTime = DateTime.Now - Engine.StartTime;
                        ProgressStatus.Text = string.Format(@"Поиск завершен. Обработано: {2}. Совпадений: {1}. Затрачено времени: {0}.", ExecuteTime.ToString("hh':'mm':'ss"), Engine.StatFounded, Engine.StatFiles);
                        ButtonCopyFiles.Enabled = true;
                    }
                }
                else if (Utils.FindText(status, "Поиск отменен"))
                {
                    if (Results.FoundList.Count > 0)
                    {
                        foreach (var Key in Results.FoundList.Keys)
                        {
                            FoundItem Item = Results.FoundList[Key];
                            FoundList.Items.Add(new FoundItem(Item.Path));
                        }
                        TimeSpan ExecuteTime = DateTime.Now - Engine.StartTime;
                        ProgressStatus.Text = string.Format(@"Поиск отменен. Совпадений: {1}. Затрачено времени: {0}.", ExecuteTime.ToString("hh':'mm':'ss"), Engine.StatFounded);
                        ButtonCopyFiles.Enabled = true;
                    }
                }
                ProgressActive = false;
                ButtonStart.Text = "Начать поиск";
                ButtonStart.Width = (ButtonPause.Location.X - ButtonStart.Location.X) + 388;
                ProgressWorker.CancelAsync();
                SpeedTimer.Stop();
                SpeedTimer.Enabled = false;
                ButtonPause.Enabled = false;
                ButtonPause.Hide();
                ButtonPause.Text = "Пауза";
            }
        }

        // Событие для передачи в ProgressWorker информации о текущем прогрессе
        private void SendProgressStatus(object sender, ProgressEventArgs e)
        {
            ProgressWorker.ReportProgress(Convert.ToInt32(e.Progress), e.Status);
        }
        
        // Коллбэк на тик таймера для подсчета скорости обработки файлов
        private void SpeedTimerTick(object sender, EventArgs e)
        {
            Engine.CheckSpeed();
        }

        // Открытие (в редакторе по-умолчанию) найденного файла при двойном клике по нему в списке
        private void FoundListMouseDoubleClick(object sender, MouseEventArgs e)
        {
            var listBox = (ListBox)sender;
            if (listBox.SelectedIndex != -1)
            {
                FoundItem item = (FoundItem)listBox.SelectedItem;
                Process.Start(item.Path);
            }
        }

        // Копирование путей к найденным файлам в буфер обмена
        private void FoundListKeyDown(object sender, KeyEventArgs e)
        {
            var listBox = (ListBox)sender;
            if (e.Control)
            {
                // поддержка комбинации CTRL + A для выделения всех путей к найденным файлам
                if (e.KeyCode == Keys.A)
                {
                    for (int i = 1; i <= listBox.Items.Count; i++)
                    {
                        listBox.SetSelected(i - 1, true);
                    }
                    e.SuppressKeyPress = true;
                }
                // поддержка комбинации CTRL + C для копирования всех выделенных путей к найденным файлам
                else if (e.KeyCode == Keys.C)
                {
                    if (listBox.SelectedIndex != -1)
                    {
                        var data = new List<string>();
                        foreach (FoundItem item in listBox.SelectedItems)
                        {
                            data.Add(item.Path);
                        }
                        Clipboard.SetText(string.Join(Environment.NewLine, data));
                    }
                }
            }
        }

        // Копирование путей к найденным файлам в буфер обмена
        private void ButtonCopyFilesClick(object sender, EventArgs e)
        {
            if (FoundList.Items.Count > 0)
            {
                int total = 0;
                var data = new List<string>();
                foreach (FoundItem item in FoundList.Items)
                {
                    data.Add(item.Path);
                    total++;
                }
                Clipboard.SetText(string.Join(Environment.NewLine, data));
                ProgressStatus.Text = string.Format(@"Пути к файлам скопированы в буфер обмена. Количество: {0}.", total);
            }
        }

        // Запуск программы
        private void ProgramOpen(object sender, EventArgs e)
        {
            LoadSettings();
        }

        // Загрузка настроек
        private void LoadSettings()
        {
            InputPath.Text = Settings.Default.InputPath;
            SubMode.Checked = Settings.Default.SubMode;
            FilesType.Text = Settings.Default.FilesType;
            CondsData.Text = Settings.Default.CondsData;
        }

        // Выход из программы
        private void ProgramExit(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        // Сохранение настроек
        private void SaveSettings()
        {
            Settings.Default.InputPath = InputPath.Text;
            Settings.Default.SubMode = SubMode.Checked;
            Settings.Default.FilesType = FilesType.Text;
            Settings.Default.CondsData = CondsData.Text;
            Settings.Default.Save();
        }

        // Клик по кнопке предпросмотра
        private void ButtonPreviewClick(object sender, EventArgs e)
        {
            PreviewWnd wnd = new PreviewWnd(this);
            wnd.Show(this);
        }
    }
}

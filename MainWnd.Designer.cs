namespace AdvancedFileSearcher
{
    partial class MainWnd
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWnd));
            this.FilesPath1Box = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FilesType = new System.Windows.Forms.TextBox();
            this.SubMode = new System.Windows.Forms.CheckBox();
            this.InputPath = new System.Windows.Forms.TextBox();
            this.ButtonBrowseOutputPath = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FilterDataLabel = new System.Windows.Forms.Label();
            this.CondsData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonCopyFiles = new System.Windows.Forms.Button();
            this.FoundList = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressStatus = new System.Windows.Forms.Label();
            this.ProgressWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SpeedTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonPreview = new System.Windows.Forms.Button();
            this.FilesPath1Box.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilesPath1Box
            // 
            this.FilesPath1Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesPath1Box.Controls.Add(this.label10);
            this.FilesPath1Box.Controls.Add(this.FilesType);
            this.FilesPath1Box.Controls.Add(this.SubMode);
            this.FilesPath1Box.Controls.Add(this.InputPath);
            this.FilesPath1Box.Controls.Add(this.ButtonBrowseOutputPath);
            this.FilesPath1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilesPath1Box.Location = new System.Drawing.Point(12, 12);
            this.FilesPath1Box.Name = "FilesPath1Box";
            this.FilesPath1Box.Size = new System.Drawing.Size(734, 75);
            this.FilesPath1Box.TabIndex = 20;
            this.FilesPath1Box.TabStop = false;
            this.FilesPath1Box.Text = "Путь к файлам";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(538, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Расширение файлов :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilesType
            // 
            this.FilesType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesType.Location = new System.Drawing.Point(690, 47);
            this.FilesType.Name = "FilesType";
            this.FilesType.Size = new System.Drawing.Size(35, 22);
            this.FilesType.TabIndex = 23;
            this.FilesType.Text = ".txt";
            this.FilesType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubMode
            // 
            this.SubMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubMode.AutoSize = true;
            this.SubMode.Location = new System.Drawing.Point(12, 49);
            this.SubMode.Name = "SubMode";
            this.SubMode.Size = new System.Drawing.Size(164, 20);
            this.SubMode.TabIndex = 9;
            this.SubMode.Text = "Учитывать подпапки";
            this.SubMode.UseVisualStyleBackColor = true;
            // 
            // InputPath
            // 
            this.InputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPath.Location = new System.Drawing.Point(12, 21);
            this.InputPath.Name = "InputPath";
            this.InputPath.Size = new System.Drawing.Size(539, 22);
            this.InputPath.TabIndex = 2;
            this.InputPath.Text = "F:\\TEST\\articles1";
            // 
            // ButtonBrowseOutputPath
            // 
            this.ButtonBrowseOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowseOutputPath.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonBrowseOutputPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonBrowseOutputPath.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonBrowseOutputPath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBrowseOutputPath.ForeColor = System.Drawing.Color.Cornsilk;
            this.ButtonBrowseOutputPath.Location = new System.Drawing.Point(557, 19);
            this.ButtonBrowseOutputPath.Name = "ButtonBrowseOutputPath";
            this.ButtonBrowseOutputPath.Size = new System.Drawing.Size(168, 26);
            this.ButtonBrowseOutputPath.TabIndex = 0;
            this.ButtonBrowseOutputPath.Text = "Обзор";
            this.ButtonBrowseOutputPath.UseVisualStyleBackColor = false;
            this.ButtonBrowseOutputPath.Click += new System.EventHandler(this.ButtonBrowseInputPathClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ButtonPreview);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.FilterDataLabel);
            this.groupBox3.Controls.Add(this.CondsData);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(734, 233);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Опции";
            // 
            // FilterDataLabel
            // 
            this.FilterDataLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FilterDataLabel.AutoSize = true;
            this.FilterDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterDataLabel.Location = new System.Drawing.Point(194, 15);
            this.FilterDataLabel.Name = "FilterDataLabel";
            this.FilterDataLabel.Size = new System.Drawing.Size(295, 16);
            this.FilterDataLabel.TabIndex = 29;
            this.FilterDataLabel.Text = "Искать файлы со следующим содержанием :";
            this.FilterDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CondsData
            // 
            this.CondsData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CondsData.Location = new System.Drawing.Point(12, 34);
            this.CondsData.Multiline = true;
            this.CondsData.Name = "CondsData";
            this.CondsData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CondsData.Size = new System.Drawing.Size(713, 163);
            this.CondsData.TabIndex = 28;
            this.CondsData.Text = "keyword_1";
            this.CondsData.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ButtonCopyFiles);
            this.groupBox2.Controls.Add(this.FoundList);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 273);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найденные файлы";
            // 
            // ButtonCopyFiles
            // 
            this.ButtonCopyFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCopyFiles.BackColor = System.Drawing.Color.Maroon;
            this.ButtonCopyFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonCopyFiles.Enabled = false;
            this.ButtonCopyFiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonCopyFiles.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCopyFiles.ForeColor = System.Drawing.Color.Cornsilk;
            this.ButtonCopyFiles.Location = new System.Drawing.Point(19, 234);
            this.ButtonCopyFiles.Name = "ButtonCopyFiles";
            this.ButtonCopyFiles.Size = new System.Drawing.Size(694, 26);
            this.ButtonCopyFiles.TabIndex = 14;
            this.ButtonCopyFiles.Text = "Скопировать пути в буфер обмена";
            this.ButtonCopyFiles.UseVisualStyleBackColor = false;
            this.ButtonCopyFiles.Click += new System.EventHandler(this.ButtonCopyFilesClick);
            // 
            // FoundList
            // 
            this.FoundList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoundList.FormattingEnabled = true;
            this.FoundList.HorizontalScrollbar = true;
            this.FoundList.ItemHeight = 16;
            this.FoundList.Location = new System.Drawing.Point(20, 24);
            this.FoundList.Name = "FoundList";
            this.FoundList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.FoundList.Size = new System.Drawing.Size(693, 196);
            this.FoundList.TabIndex = 0;
            this.FoundList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FoundListKeyDown);
            this.FoundList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FoundListMouseDoubleClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.ButtonStart);
            this.groupBox6.Controls.Add(this.ButtonPause);
            this.groupBox6.Controls.Add(this.ProgressBar);
            this.groupBox6.Controls.Add(this.ProgressStatus);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(12, 611);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(734, 137);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.BackColor = System.Drawing.Color.SeaGreen;
            this.ButtonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.ForeColor = System.Drawing.Color.Cornsilk;
            this.ButtonStart.Location = new System.Drawing.Point(6, 15);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(722, 26);
            this.ButtonStart.TabIndex = 12;
            this.ButtonStart.Text = "Начать поиск";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // ButtonPause
            // 
            this.ButtonPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPause.BackColor = System.Drawing.Color.SlateBlue;
            this.ButtonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPause.ForeColor = System.Drawing.Color.Cornsilk;
            this.ButtonPause.Location = new System.Drawing.Point(340, 15);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(388, 26);
            this.ButtonPause.TabIndex = 14;
            this.ButtonPause.Text = "Пауза";
            this.ButtonPause.UseVisualStyleBackColor = false;
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPauseClick);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.BackColor = System.Drawing.Color.Gainsboro;
            this.ProgressBar.Location = new System.Drawing.Point(6, 108);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(722, 23);
            this.ProgressBar.TabIndex = 12;
            // 
            // ProgressStatus
            // 
            this.ProgressStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProgressStatus.Location = new System.Drawing.Point(6, 44);
            this.ProgressStatus.Name = "ProgressStatus";
            this.ProgressStatus.Size = new System.Drawing.Size(722, 59);
            this.ProgressStatus.TabIndex = 13;
            this.ProgressStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressWorker
            // 
            this.ProgressWorker.WorkerReportsProgress = true;
            this.ProgressWorker.WorkerSupportsCancellation = true;
            this.ProgressWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ProgressWorkerDoWork);
            this.ProgressWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ProgressWorkerChanged);
            // 
            // SpeedTimer
            // 
            this.SpeedTimer.Interval = 1000;
            this.SpeedTimer.Tick += new System.EventHandler(this.SpeedTimerTick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "- Поддерживается оператор [AND]";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "- Если любая из строк в этом поле будет обнаружена в файле, он попадет в результа" +
    "т";
            // 
            // ButtonPreview
            // 
            this.ButtonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPreview.Location = new System.Drawing.Point(541, 203);
            this.ButtonPreview.Name = "ButtonPreview";
            this.ButtonPreview.Size = new System.Drawing.Size(184, 23);
            this.ButtonPreview.TabIndex = 32;
            this.ButtonPreview.Text = "Предпросмотр";
            this.ButtonPreview.UseVisualStyleBackColor = true;
            this.ButtonPreview.Click += new System.EventHandler(this.ButtonPreviewClick);
            // 
            // SearcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(759, 756);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FilesPath1Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearcherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Files Searcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgramExit);
            this.Load += new System.EventHandler(this.ProgramOpen);
            this.FilesPath1Box.ResumeLayout(false);
            this.FilesPath1Box.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FilesPath1Box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FilesType;
        private System.Windows.Forms.CheckBox SubMode;
        private System.Windows.Forms.TextBox InputPath;
        private System.Windows.Forms.Button ButtonBrowseOutputPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label FilterDataLabel;
        public System.Windows.Forms.TextBox CondsData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonCopyFiles;
        public System.Windows.Forms.ListBox FoundList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonPause;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label ProgressStatus;
        private System.ComponentModel.BackgroundWorker ProgressWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Timer SpeedTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonPreview;
    }
}


namespace AdvancedFileSearcher
{
    partial class PreviewWnd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewWnd));
            this.ButtonPreview = new System.Windows.Forms.Button();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.PreviewInput = new System.Windows.Forms.TextBox();
            this.PreviewResult = new System.Windows.Forms.Label();
            this.groupBox28.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPreview
            // 
            this.ButtonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPreview.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonPreview.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonPreview.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPreview.ForeColor = System.Drawing.Color.Cornsilk;
            this.ButtonPreview.Location = new System.Drawing.Point(12, 301);
            this.ButtonPreview.Name = "ButtonPreview";
            this.ButtonPreview.Size = new System.Drawing.Size(776, 26);
            this.ButtonPreview.TabIndex = 44;
            this.ButtonPreview.Text = "Проверить";
            this.ButtonPreview.UseVisualStyleBackColor = false;
            this.ButtonPreview.Click += new System.EventHandler(this.ButtonPreviewClick);
            // 
            // groupBox28
            // 
            this.groupBox28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox28.Controls.Add(this.PreviewResult);
            this.groupBox28.Controls.Add(this.OutputLabel);
            this.groupBox28.Controls.Add(this.InputLabel);
            this.groupBox28.Controls.Add(this.PreviewInput);
            this.groupBox28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox28.Location = new System.Drawing.Point(12, 12);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(776, 283);
            this.groupBox28.TabIndex = 43;
            this.groupBox28.TabStop = false;
            // 
            // OutputLabel
            // 
            this.OutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.Location = new System.Drawing.Point(6, 220);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(84, 16);
            this.OutputLabel.TabIndex = 36;
            this.OutputLabel.Text = "Результат :";
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLabel.Location = new System.Drawing.Point(6, 15);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(45, 16);
            this.InputLabel.TabIndex = 34;
            this.InputLabel.Text = "Вход :";
            this.InputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviewInput
            // 
            this.PreviewInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviewInput.Location = new System.Drawing.Point(9, 34);
            this.PreviewInput.MaxLength = 0;
            this.PreviewInput.Multiline = true;
            this.PreviewInput.Name = "PreviewInput";
            this.PreviewInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PreviewInput.Size = new System.Drawing.Size(761, 183);
            this.PreviewInput.TabIndex = 33;
            this.PreviewInput.WordWrap = false;
            // 
            // PreviewResult
            // 
            this.PreviewResult.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviewResult.Location = new System.Drawing.Point(96, 224);
            this.PreviewResult.Name = "PreviewResult";
            this.PreviewResult.Size = new System.Drawing.Size(674, 46);
            this.PreviewResult.TabIndex = 38;
            this.PreviewResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviewWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.ButtonPreview);
            this.Controls.Add(this.groupBox28);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PreviewWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предпросмотр";
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonPreview;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox PreviewInput;
        private System.Windows.Forms.Label PreviewResult;
    }
}
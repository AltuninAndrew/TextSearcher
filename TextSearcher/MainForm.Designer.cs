namespace TextSearcher
{
    partial class MainForm
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
            this.BtnSetDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtBoxDir = new System.Windows.Forms.TextBox();
            this.BtnStartSearch = new System.Windows.Forms.Button();
            this.BtnStopSearch = new System.Windows.Forms.Button();
            this.BtnPauseSearch = new System.Windows.Forms.Button();
            this.txtBoxFound = new System.Windows.Forms.TextBox();
            this.txtBoxPatternFileName = new System.Windows.Forms.TextBox();
            this.txtBoxPattern = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txtCountFile = new System.Windows.Forms.Label();
            this.txtElapsedTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSetDir
            // 
            this.BtnSetDir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSetDir.Location = new System.Drawing.Point(700, 39);
            this.BtnSetDir.Name = "BtnSetDir";
            this.BtnSetDir.Size = new System.Drawing.Size(106, 26);
            this.BtnSetDir.TabIndex = 0;
            this.BtnSetDir.Text = "Set directory";
            this.BtnSetDir.UseVisualStyleBackColor = false;
            this.BtnSetDir.Click += new System.EventHandler(this.BtnSetDir_click);
            // 
            // txtBoxDir
            // 
            this.txtBoxDir.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxDir.Location = new System.Drawing.Point(448, 43);
            this.txtBoxDir.Name = "txtBoxDir";
            this.txtBoxDir.Size = new System.Drawing.Size(246, 20);
            this.txtBoxDir.TabIndex = 1;
            // 
            // BtnStartSearch
            // 
            this.BtnStartSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnStartSearch.Location = new System.Drawing.Point(448, 234);
            this.BtnStartSearch.Name = "BtnStartSearch";
            this.BtnStartSearch.Size = new System.Drawing.Size(108, 34);
            this.BtnStartSearch.TabIndex = 2;
            this.BtnStartSearch.Text = "Start search";
            this.BtnStartSearch.UseVisualStyleBackColor = true;
            this.BtnStartSearch.Click += new System.EventHandler(this.BtnStartSearch_click);
            // 
            // BtnStopSearch
            // 
            this.BtnStopSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnStopSearch.Location = new System.Drawing.Point(562, 234);
            this.BtnStopSearch.Name = "BtnStopSearch";
            this.BtnStopSearch.Size = new System.Drawing.Size(120, 34);
            this.BtnStopSearch.TabIndex = 3;
            this.BtnStopSearch.Text = "Stop search";
            this.BtnStopSearch.UseVisualStyleBackColor = true;
            this.BtnStopSearch.Click += new System.EventHandler(this.BtnStopSearch_Click);
            // 
            // BtnPauseSearch
            // 
            this.BtnPauseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPauseSearch.Location = new System.Drawing.Point(688, 234);
            this.BtnPauseSearch.Name = "BtnPauseSearch";
            this.BtnPauseSearch.Size = new System.Drawing.Size(118, 34);
            this.BtnPauseSearch.TabIndex = 4;
            this.BtnPauseSearch.Text = "Pause search";
            this.BtnPauseSearch.UseVisualStyleBackColor = true;
            this.BtnPauseSearch.Click += new System.EventHandler(this.BtnPauseSearch_Click);
            // 
            // txtBoxFound
            // 
            this.txtBoxFound.Location = new System.Drawing.Point(12, 12);
            this.txtBoxFound.Multiline = true;
            this.txtBoxFound.Name = "txtBoxFound";
            this.txtBoxFound.ReadOnly = true;
            this.txtBoxFound.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxFound.Size = new System.Drawing.Size(413, 574);
            this.txtBoxFound.TabIndex = 5;
            // 
            // txtBoxPatternFileName
            // 
            this.txtBoxPatternFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPatternFileName.Location = new System.Drawing.Point(448, 116);
            this.txtBoxPatternFileName.Multiline = true;
            this.txtBoxPatternFileName.Name = "txtBoxPatternFileName";
            this.txtBoxPatternFileName.Size = new System.Drawing.Size(358, 30);
            this.txtBoxPatternFileName.TabIndex = 6;
            // 
            // txtBoxPattern
            // 
            this.txtBoxPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPattern.Location = new System.Drawing.Point(448, 184);
            this.txtBoxPattern.Multiline = true;
            this.txtBoxPattern.Name = "txtBoxPattern";
            this.txtBoxPattern.Size = new System.Drawing.Size(358, 44);
            this.txtBoxPattern.TabIndex = 7;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoEllipsis = true;
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStatus.Location = new System.Drawing.Point(447, 287);
            this.txtStatus.MaximumSize = new System.Drawing.Size(0, 30);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(199, 20);
            this.txtStatus.TabIndex = 8;
            this.txtStatus.Text = "Search status: Stopped";
            // 
            // txtCountFile
            // 
            this.txtCountFile.AutoSize = true;
            this.txtCountFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountFile.Location = new System.Drawing.Point(447, 325);
            this.txtCountFile.Name = "txtCountFile";
            this.txtCountFile.Size = new System.Drawing.Size(198, 20);
            this.txtCountFile.TabIndex = 9;
            this.txtCountFile.Text = "Сount processing file: 0";
            // 
            // txtElapsedTime
            // 
            this.txtElapsedTime.AutoSize = true;
            this.txtElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold);
            this.txtElapsedTime.Location = new System.Drawing.Point(447, 362);
            this.txtElapsedTime.Name = "txtElapsedTime";
            this.txtElapsedTime.Size = new System.Drawing.Size(123, 20);
            this.txtElapsedTime.TabIndex = 10;
            this.txtElapsedTime.Text = "Elapsed time: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(448, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Path to root directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(448, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pattern files name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(448, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Text for search:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(841, 598);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtElapsedTime);
            this.Controls.Add(this.txtCountFile);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtBoxPattern);
            this.Controls.Add(this.txtBoxPatternFileName);
            this.Controls.Add(this.txtBoxFound);
            this.Controls.Add(this.BtnPauseSearch);
            this.Controls.Add(this.BtnStopSearch);
            this.Controls.Add(this.BtnStartSearch);
            this.Controls.Add(this.txtBoxDir);
            this.Controls.Add(this.BtnSetDir);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text searcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtBoxDir;
        protected System.Windows.Forms.Button BtnSetDir;
        private System.Windows.Forms.Button BtnStartSearch;
        private System.Windows.Forms.Button BtnStopSearch;
        private System.Windows.Forms.Button BtnPauseSearch;
        private System.Windows.Forms.TextBox txtBoxFound;
        private System.Windows.Forms.TextBox txtBoxPatternFileName;
        private System.Windows.Forms.TextBox txtBoxPattern;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label txtCountFile;
        private System.Windows.Forms.Label txtElapsedTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


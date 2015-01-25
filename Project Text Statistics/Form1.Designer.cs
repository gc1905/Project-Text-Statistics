namespace ProjectTextStatistics {
    partial class GUI {
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
        private void InitializeComponent() {
            this.browserDialogDirectoryFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.radioButtonAllOption = new System.Windows.Forms.RadioButton();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.checkboxFilterUseRegex = new System.Windows.Forms.CheckBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.checkBoxFilterEnabled = new System.Windows.Forms.CheckBox();
            this.radioButtonLocalOption = new System.Windows.Forms.RadioButton();
            this.buttonDirectory = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.radioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(12, 9);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(157, 13);
            this.labelDirectory.TabIndex = 0;
            this.labelDirectory.Text = "Folder projektu:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 155);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(117, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(95, 6);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(278, 20);
            this.textBoxDirectory.TabIndex = 2;
            // 
            // radioButtonAllOption
            // 
            this.radioButtonAllOption.AutoSize = true;
            this.radioButtonAllOption.Checked = true;
            this.radioButtonAllOption.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAllOption.Name = "radioButtonAllOption";
            this.radioButtonAllOption.Size = new System.Drawing.Size(108, 17);
            this.radioButtonAllOption.TabIndex = 3;
            this.radioButtonAllOption.TabStop = true;
            this.radioButtonAllOption.Text = "folder i podfoldery";
            this.radioButtonAllOption.UseVisualStyleBackColor = true;
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.checkboxFilterUseRegex);
            this.radioGroupBox.Controls.Add(this.textBoxFilter);
            this.radioGroupBox.Controls.Add(this.checkBoxFilterEnabled);
            this.radioGroupBox.Controls.Add(this.radioButtonLocalOption);
            this.radioGroupBox.Controls.Add(this.radioButtonAllOption);
            this.radioGroupBox.Location = new System.Drawing.Point(15, 32);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(398, 117);
            this.radioGroupBox.TabIndex = 4;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "Zakres analizy plików";
            // 
            // checkboxFilterUseRegex
            // 
            this.checkboxFilterUseRegex.AutoSize = true;
            this.checkboxFilterUseRegex.Enabled = false;
            this.checkboxFilterUseRegex.Location = new System.Drawing.Point(139, 66);
            this.checkboxFilterUseRegex.Name = "checkboxFilterUseRegex";
            this.checkboxFilterUseRegex.Size = new System.Drawing.Size(179, 17);
            this.checkboxFilterUseRegex.TabIndex = 7;
            this.checkboxFilterUseRegex.Text = "Traktuj jako wyrażenie regularne";
            this.checkboxFilterUseRegex.UseVisualStyleBackColor = true;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Enabled = false;
            this.textBoxFilter.Location = new System.Drawing.Point(6, 89);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(386, 20);
            this.textBoxFilter.TabIndex = 6;
            // 
            // checkBoxFilterEnabled
            // 
            this.checkBoxFilterEnabled.AutoSize = true;
            this.checkBoxFilterEnabled.Location = new System.Drawing.Point(7, 66);
            this.checkBoxFilterEnabled.Name = "checkBoxFilterEnabled";
            this.checkBoxFilterEnabled.Size = new System.Drawing.Size(126, 17);
            this.checkBoxFilterEnabled.TabIndex = 5;
            this.checkBoxFilterEnabled.Text = "Filtruj po nazwie pliku";
            this.checkBoxFilterEnabled.UseVisualStyleBackColor = true;
            this.checkBoxFilterEnabled.CheckedChanged += new System.EventHandler(this.filterEnabledCheckBox_CheckedChanged);
            // 
            // radioButtonLocalOption
            // 
            this.radioButtonLocalOption.AutoSize = true;
            this.radioButtonLocalOption.Location = new System.Drawing.Point(6, 42);
            this.radioButtonLocalOption.Name = "radioButtonLocalOption";
            this.radioButtonLocalOption.Size = new System.Drawing.Size(148, 17);
            this.radioButtonLocalOption.TabIndex = 4;
            this.radioButtonLocalOption.TabStop = true;
            this.radioButtonLocalOption.Text = "tylko w wybranym folderze";
            this.radioButtonLocalOption.UseVisualStyleBackColor = true;
            // 
            // buttonDirectory
            // 
            this.buttonDirectory.Image = global::ProjectTextStatistics.Properties.Resources.Lighthouse;
            this.buttonDirectory.Location = new System.Drawing.Point(379, 0);
            this.buttonDirectory.Name = "buttonDirectory";
            this.buttonDirectory.Size = new System.Drawing.Size(30, 31);
            this.buttonDirectory.TabIndex = 5;
            this.buttonDirectory.Text = "";
            this.buttonDirectory.UseVisualStyleBackColor = true;
            this.buttonDirectory.Click += new System.EventHandler(this.directoryButton_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(13, 185);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(396, 235);
            this.textBoxResult.TabIndex = 6;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 432);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonDirectory);
            this.Controls.Add(this.radioGroupBox);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelDirectory);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(437, 470);
            this.MinimumSize = new System.Drawing.Size(437, 470);
            this.Name = "GUI";
            this.Text = "GUI";
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void InitLanguage() {
            this.labelDirectory.Text = language.EnterDirectoryLabel;
            this.buttonStart.Text = language.StartButtonLabel;
            this.radioButtonAllOption.Text = language.AllLevelsScopeLabel;
            this.radioGroupBox.Text = language.AnalysisScopeGroupLabel;
            this.checkboxFilterUseRegex.Text = language.RegexFilterLabel;
            this.checkBoxFilterEnabled.Text = language.NameFilterLabel;
            this.radioButtonLocalOption.Text = language.TopLevelScopeLabel;
            this.Text = language.WindowApplicationLabel;
            this.Name = language.WindowApplicationLabel;
        }

        private System.Windows.Forms.FolderBrowserDialog browserDialogDirectoryFolder;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.RadioButton radioButtonAllOption;
        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.CheckBox checkBoxFilterEnabled;
        private System.Windows.Forms.RadioButton radioButtonLocalOption;
        private System.Windows.Forms.Button buttonDirectory;
        private System.Windows.Forms.CheckBox checkboxFilterUseRegex;
        private System.Windows.Forms.TextBox textBoxResult;

    }
}


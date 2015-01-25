/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         Form1.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectTextStatistics.UI;
using ProjectTextStatistics.Language;
using ProjectTextStatistics.Engine;
using ProjectTextStatistics.Engine.Submodules;

namespace ProjectTextStatistics {
    /// <summary>
    /// Graphical User Interface.
    /// </summary>
    public partial class GUI : Form, UserInterface {
        private GuiLanguagePack language;

        /// <summary>
        /// GUI constructor.
        /// </summary>
        /// <param name="language">Language pack</param>
        public GUI(GuiLanguagePack language) {
            this.language = language;
            InitializeComponent();
            InitLanguage();
        }

        /// <summary>
        /// Presents error message in Graphical User Interface.
        /// </summary>
        /// <param name="message">Message to present</param>
        public void ShowErrorMessage(AnalysisResult result) {
            MessageBox.Show(result.Summary, language.ErrorBoxName);
        }

        /// <summary>
        /// Presents error message in Graphical User Interface using pop-up window.
        /// </summary>
        /// <param name="message">String message to present</param>
        public void ShowErrorMessage(String message) {
            MessageBox.Show(message, language.ErrorBoxName);
        }

        /// <summary>
        /// Presents the results of directory analysis in Graphical User Interface using result textbox.
        /// </summary>
        /// <param name="result">Message to present</param>
        public void ShowSuccededResult(AnalysisResult result) {
            textBoxResult.Text = result.Summary;
        }

        private void directoryButton_Click(object sender, EventArgs e) {
            DialogResult result = browserDialogDirectoryFolder.ShowDialog();
            if (result == DialogResult.OK) {
                textBoxDirectory.Text = browserDialogDirectoryFolder.SelectedPath;
            }
        }

        private void startButton_Click(object sender, EventArgs e) {
            if (TextBoxEmpty(textBoxDirectory)) {
                ShowErrorMessage(language.NoDirectoryError);
            } else {
                if (checkBoxFilterEnabled.Checked) {
                    if (! TextBoxEmpty(textBoxFilter)) {
                        if (checkboxFilterUseRegex.Checked) {
                            ApplicationWrapper.GetSingleton().SetRegexCollector(GetCollectorScope(), textBoxFilter.Text);
                        } else {
                            ApplicationWrapper.GetSingleton().SetSimpleCollector(GetCollectorScope(), textBoxFilter.Text);
                        }
                    } else {
                        ShowErrorMessage(language.NoRuleError);
                        return;
                    }
                } else {
                    ApplicationWrapper.GetSingleton().SetSimpleCollector(GetCollectorScope());
                }
                ApplicationWrapper.GetSingleton().PerformTextAnalysis(textBoxDirectory.Text);
            }
        }

        private FileCollectorScope GetCollectorScope() {
            return radioButtonAllOption.Checked ? FileCollectorScope.TopAndChildDirectories : FileCollectorScope.TopDirectoryOnly;
        }

        private void filterEnabledCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxFilterEnabled.Checked == true) {
                checkboxFilterUseRegex.Enabled = true;
                textBoxFilter.Enabled = true;
            } else {
                checkboxFilterUseRegex.Enabled = false;
                textBoxFilter.Enabled = false;
            }
        }

        static bool TextBoxEmpty(TextBox textBox) {
            return textBox.Text.Trim().Length == 0;
        }
    }
}

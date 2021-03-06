﻿namespace Orc.Controls.Examples.Views
{
    using System;
    using System.Windows;
    using Catel.Windows.Controls;

    /// <summary>
    /// Interaction logic for LogViewer.xaml.
    /// </summary>
    public partial class LogViewer : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogViewer"/> class.
        /// </summary>
        public LogViewer()
        {
            InitializeComponent();
        }

        private void LogViewerControlOnLogRecordDoubleClick(object sender, LogEntryDoubleClickEventArgs e)
        {
            EventsTextBox.AppendText(e.LogEntry.Message + " clicked" + Environment.NewLine);
        }

        private void ClearLog_OnClick(object sender, RoutedEventArgs e)
        {
            LogViewerControl.Clear();
        }
    }
}

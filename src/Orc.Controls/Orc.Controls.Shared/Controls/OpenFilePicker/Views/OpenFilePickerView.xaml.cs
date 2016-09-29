﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenFilePickerView.xaml.cs" company="WildGums">
//   Copyright (c) 2008 - 2015 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Controls
{
    using System.Windows;
    using Catel.MVVM.Views;

    /// <summary>
    ///     Interaction logic for OpenFilePickerView.xaml
    /// </summary>
    public partial class OpenFilePickerView
    {
        static OpenFilePickerView()
        {
            typeof (OpenFilePickerView).AutoDetectViewPropertiesToSubscribe();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenFilePickerView"/> class.
        /// </summary>
        /// <remarks>This method is required for design time support.</remarks>
        public OpenFilePickerView()
        {
            InitializeComponent();
        }

        #region Properties
        [ViewToViewModel(MappingType = ViewToViewModelMappingType.TwoWayViewWins)]
        public double LabelWidth
        {
            get { return (double) GetValue(LabelWidthProperty); }
            set { SetValue(LabelWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelWidthProperty = DependencyProperty.Register("LabelWidth", typeof (double), typeof (OpenFilePickerView), new PropertyMetadata(125d));

        [ViewToViewModel(MappingType = ViewToViewModelMappingType.TwoWayViewWins)]
        public string LabelText
        {
            get { return (string) GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register("LabelText", typeof (string), typeof (OpenFilePickerView), new PropertyMetadata(string.Empty));

        [ViewToViewModel(MappingType = ViewToViewModelMappingType.TwoWayViewWins)]
        public string SelectedFile
        {
            get { return (string) GetValue(SelectedFileProperty); }
            set { SetValue(SelectedFileProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedFile.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedFileProperty = DependencyProperty.Register("SelectedFile", typeof (string),
            typeof (OpenFilePickerView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        [ViewToViewModel(MappingType = ViewToViewModelMappingType.TwoWayViewWins)]
        public string Filter
        {
            get { return (string)GetValue(FilterProperty); }
            set { SetValue(FilterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Filter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterProperty = DependencyProperty.Register("Filter", typeof(string),
            typeof(OpenFilePickerView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        [ViewToViewModel(MappingType = ViewToViewModelMappingType.TwoWayViewWins)]
        public string BaseDirectory
        {
            get { return (string)GetValue(BaseDirectoryProperty); }
            set { SetValue(BaseDirectoryProperty, value); }
        }

        public static readonly DependencyProperty BaseDirectoryProperty = DependencyProperty.Register(
            "BaseDirectory", typeof(string), typeof(OpenFilePickerView), new PropertyMetadata(string.Empty));
        #endregion
    }
}
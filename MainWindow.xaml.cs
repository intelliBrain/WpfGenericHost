﻿using System.Windows;

namespace wpfGenericHost
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(ITextService textService)
        {
            InitializeComponent();

            Label.Content = textService.GetText();
        }
    }
}

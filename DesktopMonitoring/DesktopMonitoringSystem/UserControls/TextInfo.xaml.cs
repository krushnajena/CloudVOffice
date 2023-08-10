﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace DesktopMonitoringSystem.UserControls
{

    public partial class TextInfo : UserControl
    {
        public TextInfo()
        {
            InitializeComponent();
        }

        public string TextTop
        {
            get { return (string)GetValue(TextTopProperty); }
            set { SetValue(TextTopProperty, value); }
        }
        public static readonly DependencyProperty TextTopProperty = DependencyProperty.Register("TextTop", typeof(String), typeof(TextInfo));

        public string TextMiddle
        {
            get { return (string)GetValue(TextMiddleProperty); }
            set { SetValue(TextMiddleProperty, value); }
        }
        public static readonly DependencyProperty TextMiddleProperty = DependencyProperty.Register("TextMiddle", typeof(String), typeof(TextInfo));

        public string TextBottom
        {
            get { return (string)GetValue(TextBottomProperty); }
            set { SetValue(TextBottomProperty, value); }
        }
        public static readonly DependencyProperty TextBottomProperty = DependencyProperty.Register("TextBottom", typeof(String), typeof(TextInfo));
        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(TextInfo));
    }
}

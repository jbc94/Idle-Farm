﻿#pragma checksum "C:\Users\Jono\documents\visual studio 2013\Projects\Idle_Farm\Idle_Farm\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C72208234C95F0C9973E978646E03644"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Idle_Farm {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button Main_Button;
        
        internal System.Windows.Controls.TextBlock textBlockTest;
        
        internal System.Windows.Controls.Button Farmer;
        
        internal System.Windows.Controls.Button Hoe;
        
        internal System.Windows.Controls.Button Market;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Idle_Farm;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Main_Button = ((System.Windows.Controls.Button)(this.FindName("Main_Button")));
            this.textBlockTest = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockTest")));
            this.Farmer = ((System.Windows.Controls.Button)(this.FindName("Farmer")));
            this.Hoe = ((System.Windows.Controls.Button)(this.FindName("Hoe")));
            this.Market = ((System.Windows.Controls.Button)(this.FindName("Market")));
        }
    }
}


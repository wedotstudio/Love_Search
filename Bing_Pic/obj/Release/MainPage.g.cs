﻿#pragma checksum "D:\文件中心\Windows Phone\开发\应用\Bing_Search\Bing_Pic\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9CDAF79CD4280F916521AA5D0DBC96AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace Bing_Pic {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image imageshadow;
        
        internal System.Windows.Controls.Image image;
        
        internal System.Windows.Controls.TextBlock txtCopyrightTitle;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Bing_Pic;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.imageshadow = ((System.Windows.Controls.Image)(this.FindName("imageshadow")));
            this.image = ((System.Windows.Controls.Image)(this.FindName("image")));
            this.txtCopyrightTitle = ((System.Windows.Controls.TextBlock)(this.FindName("txtCopyrightTitle")));
        }
    }
}


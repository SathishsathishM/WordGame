﻿#pragma checksum "..\..\..\MainGame.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4BFCDF27C44C125A138366F6E1E5A03AE7E03D26"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WordGame;
using WordGame.Language;


namespace WordGame {
    
    
    /// <summary>
    /// MainGame
    /// </summary>
    public partial class MainGame : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 68 "..\..\..\MainGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtbname;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\MainGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblcount;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\MainGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtname;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\MainGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblscore;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\MainGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtbscore;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\MainGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnstart;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WordGame;component/maingame.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainGame.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\MainGame.xaml"
            ((WordGame.MainGame)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtbname = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.lblcount = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lblscore = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtbscore = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.btnstart = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\MainGame.xaml"
            this.btnstart.Click += new System.Windows.RoutedEventHandler(this.btnstart_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


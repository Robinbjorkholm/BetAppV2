﻿#pragma checksum "..\..\TeamCreatorWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C419C3C73AAC0622175A825C01BF07207A4E0760790C3839D81B76DA85CD0E07"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// TeamCreatorWindow
    /// </summary>
    public partial class TeamCreatorWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\TeamCreatorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TeamNameTxtBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\TeamCreatorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton HemmaButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\TeamCreatorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton BortaButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\TeamCreatorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KeyPlayerTxtBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\TeamCreatorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HemmaBlock;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\TeamCreatorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateTeambutton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\TeamCreatorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelTeamCreator;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\TeamCreatorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox helloshitter;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/teamcreatorwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TeamCreatorWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TeamNameTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.HemmaButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 20 "..\..\TeamCreatorWindow.xaml"
            this.HemmaButton.Click += new System.Windows.RoutedEventHandler(this.HemmaButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BortaButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 21 "..\..\TeamCreatorWindow.xaml"
            this.BortaButton.Click += new System.Windows.RoutedEventHandler(this.BortaButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.KeyPlayerTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.HemmaBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.CreateTeambutton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\TeamCreatorWindow.xaml"
            this.CreateTeambutton.Click += new System.Windows.RoutedEventHandler(this.CreateTeambutton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CancelTeamCreator = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\TeamCreatorWindow.xaml"
            this.CancelTeamCreator.Click += new System.Windows.RoutedEventHandler(this.CancelTeamCreator_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.helloshitter = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


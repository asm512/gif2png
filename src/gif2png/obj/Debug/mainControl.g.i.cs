﻿#pragma checksum "..\..\mainControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E09809236A25225D1A26551BAEAC7701"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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
using gif2png;


namespace gif2png {
    
    
    /// <summary>
    /// mainControl
    /// </summary>
    public partial class mainControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\mainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UCgrid;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\mainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button selectGIF;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\mainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid attributeGrid;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\mainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock gifNameattrib;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\mainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock gifSizeattrib;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\mainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock gifFramesattrib;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\mainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox formatCombobox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\mainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pathCombobox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\mainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox prefixInput;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\mainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button extractFrames;
        
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
            System.Uri resourceLocater = new System.Uri("/gif2png;component/maincontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\mainControl.xaml"
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
            this.UCgrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.selectGIF = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\mainControl.xaml"
            this.selectGIF.Click += new System.Windows.RoutedEventHandler(this.selectGIF_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.attributeGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.gifNameattrib = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.gifSizeattrib = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.gifFramesattrib = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.formatCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\mainControl.xaml"
            this.formatCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.formatCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.pathCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\mainControl.xaml"
            this.pathCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.pathCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.prefixInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\mainControl.xaml"
            this.prefixInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.prefixInput_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.extractFrames = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\mainControl.xaml"
            this.extractFrames.Click += new System.Windows.RoutedEventHandler(this.extractFrames_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\AddTravelWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4E68418D6429D17BB1CB8BF6949CAA7174D5A72F"
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
using TravelPal;


namespace TravelPal {
    
    
    /// <summary>
    /// AddTravelWindow
    /// </summary>
    public partial class AddTravelWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCity;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCountry;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTravelers;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPurpose;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkAllInclusive;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMeetingDetails;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCountry;
        
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
            System.Uri resourceLocater = new System.Uri("/TravelPal;component/addtravelwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddTravelWindow.xaml"
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
            this.txtCity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtCountry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtTravelers = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cbPurpose = ((System.Windows.Controls.ComboBox)(target));
            
            #line 72 "..\..\..\AddTravelWindow.xaml"
            this.cbPurpose.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbPurpose_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.chkAllInclusive = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.txtMeetingDetails = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cbCountry = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 112 "..\..\..\AddTravelWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Saved_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\Popup\PopupTimeKeeping\ucCreateSaff.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EC95C82EA79B1ED05D834C485754F0C3851C381449D3972A6EF296ED903C8A83"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ChamCong365.Popup.PopupTimeKeeping;
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


namespace ChamCong365.Popup.PopupTimeKeeping {
    
    
    /// <summary>
    /// ucCreateSaff
    /// </summary>
    public partial class ucCreateSaff : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Popup\PopupTimeKeeping\ucCreateSaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bodAddSaff;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Popup\PopupTimeKeeping\ucCreateSaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock bodExitCreateSaff;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Popup\PopupTimeKeeping\ucCreateSaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ExitCreateSaff;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Popup\PopupTimeKeeping\ucCreateSaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bodButonAddFileSaff;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\Popup\PopupTimeKeeping\ucCreateSaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lsvListSaff;
        
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
            System.Uri resourceLocater = new System.Uri("/ChamCong365;component/popup/popuptimekeeping/uccreatesaff.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Popup\PopupTimeKeeping\ucCreateSaff.xaml"
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
            
            #line 9 "..\..\..\..\Popup\PopupTimeKeeping\ucCreateSaff.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bodAddSaff = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.bodExitCreateSaff = ((System.Windows.Controls.TextBlock)(target));
            
            #line 28 "..\..\..\..\Popup\PopupTimeKeeping\ucCreateSaff.xaml"
            this.bodExitCreateSaff.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.bodExitCreateSaff_MouseUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ExitCreateSaff = ((System.Windows.Controls.Image)(target));
            
            #line 37 "..\..\..\..\Popup\PopupTimeKeeping\ucCreateSaff.xaml"
            this.ExitCreateSaff.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ExitCreateSaff_MouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bodButonAddFileSaff = ((System.Windows.Controls.Border)(target));
            
            #line 86 "..\..\..\..\Popup\PopupTimeKeeping\ucCreateSaff.xaml"
            this.bodButonAddFileSaff.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.bodButonAddFileSaff_MouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lsvListSaff = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\Popup\PopupTimeKeeping\ucDeleteCalendarWork.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B54AD00BB7AFC11FACEC2D84033F9481515290453A144C85C481277CBF675ED0"
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
    /// ucDeleteCalendarWork
    /// </summary>
    public partial class ucDeleteCalendarWork : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Popup\PopupTimeKeeping\ucDeleteCalendarWork.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bodDeleteCalendar;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Popup\PopupTimeKeeping\ucDeleteCalendarWork.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bodCancel;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Popup\PopupTimeKeeping\ucDeleteCalendarWork.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/ChamCong365;component/popup/popuptimekeeping/ucdeletecalendarwork.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Popup\PopupTimeKeeping\ucDeleteCalendarWork.xaml"
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
            
            #line 9 "..\..\..\..\Popup\PopupTimeKeeping\ucDeleteCalendarWork.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bodDeleteCalendar = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.bodCancel = ((System.Windows.Controls.Border)(target));
            
            #line 37 "..\..\..\..\Popup\PopupTimeKeeping\ucDeleteCalendarWork.xaml"
            this.bodCancel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.bodCancel_MouseDown);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\..\Popup\PopupTimeKeeping\ucDeleteCalendarWork.xaml"
            this.bodCancel.MouseEnter += new System.Windows.Input.MouseEventHandler(this.bodCancel_MouseEnter);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\..\Popup\PopupTimeKeeping\ucDeleteCalendarWork.xaml"
            this.bodCancel.MouseLeave += new System.Windows.Input.MouseEventHandler(this.bodCancel_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txbCancel = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


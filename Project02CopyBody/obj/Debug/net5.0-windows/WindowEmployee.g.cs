﻿#pragma checksum "..\..\..\WindowEmployee.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47971CD7BCF534F368E51248CDCF39C1A6F83B61"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Project02CopyBody;
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


namespace Project02CopyBody {
    
    
    /// <summary>
    /// WindowEmployee
    /// </summary>
    public partial class WindowEmployee : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\WindowEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WelcomeSNP;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\WindowEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeOrder;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\WindowEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GetOrderAtId;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\WindowEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFoundAtId;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\WindowEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCost;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\WindowEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDateOfAcceptance;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\WindowEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbStatus;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\WindowEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelSNPvendorModelWork;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Project02CopyBody;component/windowemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowEmployee.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.WelcomeSNP = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ChangeOrder = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\WindowEmployee.xaml"
            this.ChangeOrder.Click += new System.Windows.RoutedEventHandler(this.ChangeOrder_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GetOrderAtId = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\WindowEmployee.xaml"
            this.GetOrderAtId.Click += new System.Windows.RoutedEventHandler(this.GetOrderAtId_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbFoundAtId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbDateOfAcceptance = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbStatus = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.labelSNPvendorModelWork = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\WindowClient.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6B3AC65428A42FC4206EE00CDECD8CDFD0695730"
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
    /// WindowClient
    /// </summary>
    public partial class WindowClient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\WindowClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WelcomeSNP;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\WindowClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbVendor;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\WindowClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbModel;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\WindowClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTypeOfWork;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\WindowClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button makeOrder;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\WindowClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GetMyOrders;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\WindowClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lableOrdersList;
        
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
            System.Uri resourceLocater = new System.Uri("/Project02CopyBody;component/windowclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowClient.xaml"
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
            this.tbVendor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbModel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbTypeOfWork = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.makeOrder = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\WindowClient.xaml"
            this.makeOrder.Click += new System.Windows.RoutedEventHandler(this.makeOrder_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GetMyOrders = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\WindowClient.xaml"
            this.GetMyOrders.Click += new System.Windows.RoutedEventHandler(this.GetMyOrders_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lableOrdersList = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

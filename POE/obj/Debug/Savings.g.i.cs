﻿#pragma checksum "..\..\Savings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC82C9F114F33FA8A17F93687D3D31F8980D20E68B1576C6AD742B2D3841257C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using POE;
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


namespace POE {
    
    
    /// <summary>
    /// Savings
    /// </summary>
    public partial class Savings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_amount;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Interest;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Years;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Results;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Calc;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Home;
        
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
            System.Uri resourceLocater = new System.Uri("/POE;component/savings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Savings.xaml"
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
            this.txt_amount = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\Savings.xaml"
            this.txt_amount.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txt_amount_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_Interest = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\Savings.xaml"
            this.txt_Interest.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txt_Interest_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txt_Years = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\Savings.xaml"
            this.txt_Years.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txt_Years_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt_Results = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_Calc = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\Savings.xaml"
            this.btn_Calc.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_Home = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\Savings.xaml"
            this.btn_Home.Click += new System.Windows.RoutedEventHandler(this.btn_Home_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


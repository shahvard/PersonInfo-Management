#pragma checksum "..\..\..\personInsert.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57BF9B44F4771AE99281BFDB224094C5A402AC37"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Midterm;
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


namespace Midterm {
    
    
    /// <summary>
    /// personInsert
    /// </summary>
    public partial class personInsert : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\personInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuNew;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\personInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuSave;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\personInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuInsert;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\personInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuUpdate;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\personInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuDelete;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\personInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Help;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\personInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtId;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\personInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\personInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddress;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\personInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtemail;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\personInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAge;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\personInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBirthday;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Midterm;component/personinsert.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\personInsert.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mnuNew = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 2:
            this.mnuSave = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            
            #line 15 "..\..\..\personInsert.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mnuInsert = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\personInsert.xaml"
            this.mnuInsert.Click += new System.Windows.RoutedEventHandler(this.mnuInsert_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mnuUpdate = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\..\personInsert.xaml"
            this.mnuUpdate.Click += new System.Windows.RoutedEventHandler(this.mnuUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.mnuDelete = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\..\personInsert.xaml"
            this.mnuDelete.Click += new System.Windows.RoutedEventHandler(this.mnuDelete_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Help = ((System.Windows.Controls.MenuItem)(target));
            
            #line 22 "..\..\..\personInsert.xaml"
            this.Help.Click += new System.Windows.RoutedEventHandler(this.Help_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txtemail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.txtAge = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.txtBirthday = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            
            #line 44 "..\..\..\personInsert.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


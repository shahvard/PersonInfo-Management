#pragma checksum "..\..\..\EducationInsert.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ED4416CCB518F021B4C4DC7619C108272E30EEDD"
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
    /// EducationInsert
    /// </summary>
    public partial class EducationInsert : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\EducationInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuNew;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\EducationInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuSave;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\EducationInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuInsert;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\EducationInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuUpdate;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\EducationInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuDelete;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\EducationInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Help;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\EducationInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtId;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\EducationInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPersonId;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\EducationInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCourseName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\EducationInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCourseGrade;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\EducationInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtComments;
        
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
            System.Uri resourceLocater = new System.Uri("/Midterm;component/educationinsert.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EducationInsert.xaml"
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
            
            #line 15 "..\..\..\EducationInsert.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mnuInsert = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\EducationInsert.xaml"
            this.mnuInsert.Click += new System.Windows.RoutedEventHandler(this.mnuInsert_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mnuUpdate = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\..\EducationInsert.xaml"
            this.mnuUpdate.Click += new System.Windows.RoutedEventHandler(this.mnuUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.mnuDelete = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\..\EducationInsert.xaml"
            this.mnuDelete.Click += new System.Windows.RoutedEventHandler(this.mnuDelete_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Help = ((System.Windows.Controls.MenuItem)(target));
            
            #line 22 "..\..\..\EducationInsert.xaml"
            this.Help.Click += new System.Windows.RoutedEventHandler(this.Help_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtPersonId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtCourseName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txtCourseGrade = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.txtComments = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 42 "..\..\..\EducationInsert.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


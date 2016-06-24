﻿#pragma checksum "..\..\..\Controls\NodeControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1070098EFA47F1D93442ACEC285ED968"
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
using VoidNull;
using VoidNull.Controls;


namespace VoidNull.Controls {
    
    
    /// <summary>
    /// NodeControl
    /// </summary>
    public partial class NodeControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VoidNull.Controls.NodeControl control;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle header;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label idLabel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label headerName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse delete;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse output;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse input;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl content;
        
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
            System.Uri resourceLocater = new System.Uri("/VoidProject;component/controls/nodecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\NodeControl.xaml"
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
            this.control = ((VoidNull.Controls.NodeControl)(target));
            
            #line 9 "..\..\..\Controls\NodeControl.xaml"
            this.control.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Select);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Controls\NodeControl.xaml"
            this.control.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Leave);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Controls\NodeControl.xaml"
            this.control.MouseMove += new System.Windows.Input.MouseEventHandler(this.Move);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Controls\NodeControl.xaml"
            this.control.Loaded += new System.Windows.RoutedEventHandler(this.control_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.header = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.idLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.headerName = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.delete = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 19 "..\..\..\Controls\NodeControl.xaml"
            this.delete.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.delete_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.output = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 20 "..\..\..\Controls\NodeControl.xaml"
            this.output.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.output_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.input = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 21 "..\..\..\Controls\NodeControl.xaml"
            this.input.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.input_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.content = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


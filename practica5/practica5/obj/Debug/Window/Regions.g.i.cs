﻿#pragma checksum "..\..\..\Window\Regions.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D4F801D555BABE3CF352A8AE866333E4F1603E94B46D43FF99EB441F866C4956"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using practica5;


namespace practica5 {
    
    
    /// <summary>
    /// Regions
    /// </summary>
    public partial class Regions : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Window\Regions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RegionT;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Window\Regions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn RegionID;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Window\Regions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn RegionName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Window\Regions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn City;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Window\Regions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox regname;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Window\Regions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox city;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Window\Regions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Window\Regions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newreg;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Window\Regions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button update;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Window\Regions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox regID;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Window\Regions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button savwchanges;
        
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
            System.Uri resourceLocater = new System.Uri("/practica5;component/window/regions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window\Regions.xaml"
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
            
            #line 10 "..\..\..\Window\Regions.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RegionT = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\..\Window\Regions.xaml"
            this.RegionT.AddHandler(System.Windows.Controls.DataGridCell.SelectedEvent, new System.Windows.RoutedEventHandler(this.RegionT_Selected));
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\Window\Regions.xaml"
            this.RegionT.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.RegionT_SelectedCellsChanged);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Window\Regions.xaml"
            this.RegionT.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RegionT_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RegionID = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.RegionName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.City = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.regname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.city = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.delete = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Window\Regions.xaml"
            this.delete.Click += new System.Windows.RoutedEventHandler(this.delete_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.newreg = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Window\Regions.xaml"
            this.newreg.Click += new System.Windows.RoutedEventHandler(this.newreg_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.update = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Window\Regions.xaml"
            this.update.Click += new System.Windows.RoutedEventHandler(this.update_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.regID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.savwchanges = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Window\Regions.xaml"
            this.savwchanges.Click += new System.Windows.RoutedEventHandler(this.savwchanges_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

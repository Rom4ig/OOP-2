﻿#pragma checksum "..\..\Cars.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DCF751C7A217C535E5CD7BCA961D9F55D9E9C776B7B14A78ED4D112347D5576B"
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


namespace KP {
    
    
    /// <summary>
    /// Cars
    /// </summary>
    public partial class Cars : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\Cars.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Garage;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Cars.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeCount;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Cars.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button XML;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Cars.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewCar;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Cars.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buy;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Cars.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid List_Cars;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Cars.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FindBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Cars.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FindString;
        
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
            System.Uri resourceLocater = new System.Uri("/KP;component/cars.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Cars.xaml"
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
            this.Garage = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Cars.xaml"
            this.Garage.Click += new System.Windows.RoutedEventHandler(this.Garage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ChangeCount = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Cars.xaml"
            this.ChangeCount.Click += new System.Windows.RoutedEventHandler(this.ChangeCount_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.XML = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Cars.xaml"
            this.XML.Click += new System.Windows.RoutedEventHandler(this.XML_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NewCar = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\Cars.xaml"
            this.NewCar.Click += new System.Windows.RoutedEventHandler(this.NewCar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Buy = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\Cars.xaml"
            this.Buy.Click += new System.Windows.RoutedEventHandler(this.BuyCar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.List_Cars = ((System.Windows.Controls.DataGrid)(target));
            
            #line 40 "..\..\Cars.xaml"
            this.List_Cars.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.List_Cars_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 40 "..\..\Cars.xaml"
            this.List_Cars.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.OnAutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FindBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\Cars.xaml"
            this.FindBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FindBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.FindString = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\Cars.xaml"
            this.FindString.TouchEnter += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.FindBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

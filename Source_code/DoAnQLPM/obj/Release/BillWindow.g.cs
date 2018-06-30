﻿#pragma checksum "..\..\BillWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14D6D2D77401C2691534031343BC7547F3349B3D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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
using System.Windows.Interactivity;
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


namespace DoAnQLPM {
    
    
    /// <summary>
    /// BillWindow
    /// </summary>
    public partial class BillWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\BillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboboxNgayKham;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\BillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TienKham;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\BillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TienThuoc;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\BillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhuThu;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\BillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TongTien;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\BillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonThanhToan;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\BillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewThuoc;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\BillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewHoaDon;
        
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
            System.Uri resourceLocater = new System.Uri("/DoAnQLPM;component/billwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BillWindow.xaml"
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
            
            #line 16 "..\..\BillWindow.xaml"
            ((DoAnQLPM.BillWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 35 "..\..\BillWindow.xaml"
            ((MaterialDesignThemes.Wpf.Card)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Card_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboboxNgayKham = ((System.Windows.Controls.ComboBox)(target));
            
            #line 52 "..\..\BillWindow.xaml"
            this.comboboxNgayKham.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboboxNgayKham_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 52 "..\..\BillWindow.xaml"
            this.comboboxNgayKham.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.comboboxNgayKham_DataContextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TienKham = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TienThuoc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PhuThu = ((System.Windows.Controls.TextBox)(target));
            
            #line 80 "..\..\BillWindow.xaml"
            this.PhuThu.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PhuThu_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TongTien = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.buttonThanhToan = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\BillWindow.xaml"
            this.buttonThanhToan.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ListViewThuoc = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.ListViewHoaDon = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\Dodaj_Ucznia.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "45122ED9D472559C798F938BB9E6DB646F0292C4D7021699FCC96A5C187E0A2F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Dzienniczek;
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


namespace Dzienniczek {
    
    
    /// <summary>
    /// Dodaj_Ucznia
    /// </summary>
    public partial class Dodaj_Ucznia : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\Dodaj_Ucznia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox imietxt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Dodaj_Ucznia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nazwiskotxt;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Dodaj_Ucznia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox plectxt;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Dodaj_Ucznia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inteligencjatxt;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Dodaj_Ucznia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox silatxt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Dodaj_Ucznia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button gotowebtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Dzienniczek;component/dodaj_ucznia.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Dodaj_Ucznia.xaml"
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
            this.imietxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.nazwiskotxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.plectxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.inteligencjatxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\Dodaj_Ucznia.xaml"
            this.inteligencjatxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.inteligencjatxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.silatxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.gotowebtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Dodaj_Ucznia.xaml"
            this.gotowebtn.Click += new System.Windows.RoutedEventHandler(this.gotowebtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

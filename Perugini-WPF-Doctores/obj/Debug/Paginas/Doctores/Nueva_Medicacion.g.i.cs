﻿#pragma checksum "..\..\..\..\Paginas\Doctores\Nueva_Medicacion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "130D0965B3F57CFE4BD15873DC34B28B6F39D30C1360B71775E9CBCB18073D00"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Perugini_WPF_Doctores.Paginas.Doctores;
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


namespace Perugini_WPF_Doctores.Paginas.Doctores {
    
    
    /// <summary>
    /// Nueva_Medicacion
    /// </summary>
    public partial class Nueva_Medicacion : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Paginas\Doctores\Nueva_Medicacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Texto_Inicial;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Paginas\Doctores\Nueva_Medicacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Texto_Doctor;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Paginas\Doctores\Nueva_Medicacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox box_nombre;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Paginas\Doctores\Nueva_Medicacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Texto_Tipo_Turno;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Paginas\Doctores\Nueva_Medicacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox box_dosis;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Paginas\Doctores\Nueva_Medicacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Boton_Nueva_Medicacion;
        
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
            System.Uri resourceLocater = new System.Uri("/Perugini-WPF-Doctores;component/paginas/doctores/nueva_medicacion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Paginas\Doctores\Nueva_Medicacion.xaml"
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
            this.Texto_Inicial = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Texto_Doctor = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.box_nombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Texto_Tipo_Turno = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.box_dosis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Boton_Nueva_Medicacion = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Paginas\Doctores\Nueva_Medicacion.xaml"
            this.Boton_Nueva_Medicacion.Click += new System.Windows.RoutedEventHandler(this.Boton_Nueva_Medicacion_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

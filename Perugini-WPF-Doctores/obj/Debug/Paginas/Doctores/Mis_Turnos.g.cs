#pragma checksum "..\..\..\..\Paginas\Doctores\Mis_Turnos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1CBA1D6C822D2AEDCE0DFB0677BAEF140D280345A06B399F215D2EFB2942B47"
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
    /// Mis_Turnos
    /// </summary>
    public partial class Mis_Turnos : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Paginas\Doctores\Mis_Turnos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Texto_Inicial;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Paginas\Doctores\Mis_Turnos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_Turnos;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Paginas\Doctores\Mis_Turnos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_turnos;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Paginas\Doctores\Mis_Turnos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Boton_Eliminar_Turno;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Paginas\Doctores\Mis_Turnos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Boton_Aceptar_Turno;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Paginas\Doctores\Mis_Turnos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Boton_Rechazar_Turno;
        
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
            System.Uri resourceLocater = new System.Uri("/Perugini-WPF-Doctores;component/paginas/doctores/mis_turnos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Paginas\Doctores\Mis_Turnos.xaml"
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
            this.Grid_Turnos = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.grid_turnos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.Boton_Eliminar_Turno = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Paginas\Doctores\Mis_Turnos.xaml"
            this.Boton_Eliminar_Turno.Click += new System.Windows.RoutedEventHandler(this.Boton_Eliminar_Turno_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Boton_Aceptar_Turno = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Paginas\Doctores\Mis_Turnos.xaml"
            this.Boton_Aceptar_Turno.Click += new System.Windows.RoutedEventHandler(this.Boton_Aceptar_Turno_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Boton_Rechazar_Turno = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\Paginas\Doctores\Mis_Turnos.xaml"
            this.Boton_Rechazar_Turno.Click += new System.Windows.RoutedEventHandler(this.Boton_Rechazar_Turno_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


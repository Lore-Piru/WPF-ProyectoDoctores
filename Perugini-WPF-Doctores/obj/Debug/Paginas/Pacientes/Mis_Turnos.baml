   M S B A M L   `   `   `  ????P  LPerugini-WPF-Doctores, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Perugini_WPF_Doctores.Paginas.Pacientes'Perugini_WPF_Doctores.Paginas.Pacientes  5      8    2Perugini_WPF_Doctores.Paginas.Pacientes.Mis_Turnos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:Perugini_WPF_Doctores.Paginas.Pacientes     5        N? Title$  
Mis_Turnos??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??58 ?6   6*   ?? 5      $
??0.1* ?6   6,   ?? 5      $??* ?6   6)   ?? 5      $
??0.1* ?6   6,   ?? 5      $
??0.5* ?6   6,   ?? 5      $
??0.1* ?6   6,    ? ColumnDefinitions 5   
   ?? 5      $
??0.1* ?6   6.   ?? 5      $
??0.5* ?6   6.   ?? 5      $??* ?6   6+   ?? 5      $
??0.5* ?6   6.   ?? 5      $
??0.1* ?6   6.   .+?5   
   ?? -   5         ??Name$ Texto_Inicial??5   5   $??0??6   $??5??6!   $
??Wrap=?6L   $??
Mis Turnos??6`   $??Cooper Black)?6r   $??50(?6?    ?? TextAlignment$ Center=?6?   $	??Top=?6?   $??58??6?   &   System.Windows.Controls.DataGrid  5   
   -   5        $??grid_turnos??5      $??1??6&   $??3??66   $??2??6J   ???	#FFF7D4F5   RowBackground ?	#FFF979F2   AlternatingRowBackground ?	#FFF7D4F5   CanUserAddRows .     CanUserResizeColumns . 	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6  
   
IsReadOnly
 . 6  ?? 5    
   -   5         ??Name$ Boton_Borrar_Turno??5    /   $??2??6   $??4??6"   $??Eliminar turno??6K   $??Center=?6d   ???#F6A2D7$??Cooper Black)?6?   $??25(?6?    J? RenderTransformOrigin$	 1,0&?6?   $??0,2,0,10q?6?   $	??314??6?   6?   5!      5"      
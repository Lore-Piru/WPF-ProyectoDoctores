   M S B A M L   `   `   `  ????P  LPerugini-WPF-Doctores, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Perugini_WPF_Doctores.Paginas.Doctores&Perugini_WPF_Doctores.Paginas.Doctores  5      7    1Perugini_WPF_Doctores.Paginas.Doctores.Mis_Turnos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:Perugini_WPF_Doctores.Paginas.Doctores     5        N? Title$  
Mis_Turnos??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $	??60* ?6   6+   ?? 5      $
??490* ?6   6,    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   6+   .+?5   
   ?? -   5         ??Name$ Texto_Inicial??5      $
??Wrap=?6+   $??
Mis Turnos??6?   $??Cooper Black)?6Q   $??50(?6k    ?? TextAlignment$ Center=?6y   $??Center=?6?   $??58??6?   ? 5   
   -   5        $??Grid_Turnos??5      $??1??6    5      ?? 5      $
??0.1* ?6    60   ?? 5      $??* ?6    6-   ?? 5      $
??0.1* ?6    60   ?? 5      $??0.15* ?6    61    5      ?? 5      $
??0.1* ?6#   62   ?? 5      $??* ?6#   6/   ?? 5      $
??0.1* ?6#   62   .+?5"      &   System.Windows.Controls.DataGrid  -   5        $??grid_turnos??5"      $??1??6*   $??1??6:   ???	#FFF7D4F5   RowBackground ?	#FFF979F2   AlternatingRowBackground ?	#FFF7D4F5   CanUserAddRows .     CanUserResizeColumns . 	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6?   ? 5$      $??3??6   $??1??6     5%      ?? 5&      $??* ?6$   61    5(      ?? 5)      $??* ?6'   63   ?? 5*      $??0.25* ?6'   67   ?? 5+      $??* ?6'   63   ?? 5,      $??0.25* ?6'   67   ?? 5-      $??* ?6'   63   .+?5/      ?? -   5        
 ??Name$
 Boton_Eliminar_Turno??5/   )   $??0??6   $??Eliminar turno??6G   ???#F6A2D7$??Cooper Black)?6u   $??15(?6?   6?   ?? 50      -   5        $
 Boton_Aceptar_Turno??50   )   $??2??6   $??Aceptar turno??6F   ???#F6A2D7$??Cooper Black)?6s   $??15(?6?   6?   ?? 51      -   5        $
 Boton_Rechazar_Turno??51   )   $??4??6   $??Rechazar turno??6G   ???#F6A2D7$??Cooper Black)?6u   $??15(?6?   6?   52      53      54      55      
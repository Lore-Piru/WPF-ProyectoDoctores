   M S B A M L   `   `   `  ????P  LPerugini-WPF-Doctores, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Perugini_WPF_Doctores.Paginas.Doctores&Perugini_WPF_Doctores.Paginas.Doctores  5      9    3Perugini_WPF_Doctores.Paginas.Doctores.Medicaciones   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:Perugini_WPF_Doctores.Paginas.Doctores     5        N? Title$  Medicaciones??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??58 ?6   6*   ?? 5      $
??0.1* ?6   6,   ?? 5      $??* ?6   6)   ?? 5      $
??0.1* ?6   6,   ?? 5      $
??0.5* ?6   6,   ?? 5      $
??0.1* ?6   6,    ? ColumnDefinitions 5   
   ?? 5      $
??0.1* ?6   6.   ?? 5      $??* ?6   6+   ?? 5      $
??0.5* ?6   6.   ?? 5      $??* ?6   6+   ?? 5      $
??0.1* ?6   6.   .+?5   
   ?? -   5         ??Name$ Texto_Inicial??5   5   $??0??6   $??5??6!   $
??Wrap=?6L   $??Medicaciones??6`   $??Cooper Black)?6t   $??50(?6?    ?? TextAlignment$ Center=?6?   $	??Top=?6?   $??58??6?   &   System.Windows.Controls.DataGrid  5   
   -   5        $??grid_medicaciones??5      $??1??6,   $??3??6<   $??2??6P   ???	#FFF7D4F5   RowBackground ?	#FFF979F2   AlternatingRowBackground ?	#FFF7D4F5   CanUserAddRows .     CanUserResizeColumns . 	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6  ?? 5   
   -   5        
 ??Name$
 Boton_Borrar_Medicacion??5   /   $??1??6   $??4??6"   $??Borrar medicación??6P   $??Center=?6l   ???#F6A2D7$??Cooper Black)?6?   $??25(?6?    J? RenderTransformOrigin$	 1,0&?6?   $??0,2,0,10q?6?   $	??314??6?   6   ?? 5    
   -   5        $!
 Boton_Actualizar_Medicacion??5    /   $??3??6   $??4??6"   $??Center=?6T   ???#F6A2D7$??Cooper Black)?6?   $??25(?6?   $	 1,0&?6?   $??0,2,0,10q?6?   $	??314??6?   ??5!      ?? 5"      $
??Wrap=?6   $(??"Actualizar medicacion seleccionada??60   $??Center=?6Z   $??Center=?6w   $ Center=?6?   5$      5&      5'      
   M S B A M L   `   `   `  ????D  @practica5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:practica5	practica5  5   	       practica5.Regions   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:practica5     5   	     ? Title$  Regions??5   	   $	??450??6   $	??800??6&   .??5	      ? .+?5
   
   ?? -   5        $??
Назад??5
      $??10,10,0,392q?6!   $
??Left=?6K   $	??108??6f   6u   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ RegionT??5         AutoGenerateColumns .     EnableRowVirtualization . $??
37,71,0,76q?5   .   $
??Left=?6B      RowDetailsVisibilityMode$ VisibleWhenSelected=?5      $	??282??6p   ??5      ??    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        RegionID??,  &System.Windows.Controls.DataGridColumn   Header$ Номер региона??5   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   7   ?? *
RegionID+5   <     5      -   5        
RegionName??$ Область??5   %   $ SizeToHeader 66    5   9   ?? *
RegionName+5   6     5      -   5        City??$# Город/Поселение??5   %   $ SizeToHeader 6>    5   3   ?? *City+5   >   5      ?? 5   
   $??Область:??6   $
??Left=?6#   $??494,113,0,0q?6>   $	??Top=?6S   ?? 5   
   $$??Город/Поселение:??6   $
??Left=?6+   $??494,144,0,0q?6F   $	??Top=?6[   ?? 5   
   -   5        	 ??Name$	 regname??5   P   $
??Left=?6a   $??639,117,0,0q?6|   
 ?? TextWrapping$

 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *SelectedItem.RegionName+ ?? ElementName$ RegionT??6?   ?? 5   
   -   5        $
	 city??5   J   $
??Left=?6X   $??639,148,0,0q?6s   $

 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *SelectedItem.City+$ RegionT??6?   ?? 5   
   -   5         ??Name$ delete??5      $??Удалить??6"   $??514,196,0,197q?64   $
??Left=?6`   $	??125??6{   6?   ?? 5   
   -	   5        $ newreg??5      $??Добавить??6"   $??661,196,0,197q?65   $
??Left=?6a   $	??129??6|   6?   ?? 5   
   -
   5        $ update??5      $??Обновить??6"   $??661,244,0,149q?65   $
??Left=?6a   $	??129??6|   ?? 5   
   $ ??Номер региона:??6   $
??Left=?6)   $??
494,82,0,0q?6D   $	??Top=?6X   ?? 5   
   -   5        $	 regID??5   N   $
??Left=?6]   $??
639,86,0,0q?6x   $

 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *SelectedItem.RegionID+$ RegionT??6?   ?? 5    
   -   5        $ savwchanges??5       $+??%Сохранить изменения??6'   $??514,244,0,149q?6E   $
??Left=?6v   5"      5#      
   M S B A M L   `   `   `  ????D  @practica5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:practica5	practica5  5   	       practica5.ProductsW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:practica5     5   	     ? Title$  Products??5   	   $	??450??6   $	??800??6'   .??5	      ? .+?5
   
   ?? -   5        $??
Назад??5
      $??10,10,0,392q?6!   $
??Left=?6K   $??56??6f   6s   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ ProductT??5         AutoGenerateColumns .     EnableRowVirtualization . $??43,74,460,73q?5   .   $
??Left=?6D      RowDetailsVisibilityMode$ VisibleWhenSelected=?5      ??5      ??    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        	ProductID??,  &System.Windows.Controls.DataGridColumn   Header$! Номер продукта??5   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   8   ?? *	ProductID+5   =     5      -   5        ProductName??$ Наименование??5   %   $ SizeToHeader 6;    5   :   ?? *ProductName+5   ;     5      -   5        ProductSort??$ Сорт??5   %   $ SizeToHeader 63    5   :   ?? *ProductSort+5   3     5      -   5        ProductGroup??$ Группа??5   %   $ SizeToHeader 65    5   ;   ?? *ProductGroup+5   5   5      ?? 5   
   -   5        	 ??Name$	 delete??5      $??Удалить??6"   $??513,229,0,164q?64   $
??Left=?6`   $	??128??6{   6?   ?? 5   
   -   5        $	 newreg??5      $??Добавить??6"   $??660,229,0,164q?65   $
??Left=?6a   $??99??6|   6?   ?? 5   
   -	   5        $	 update??5      $??Обновить??6"   $??660,277,0,116q?65   $
??Left=?6a   $??99??6|   ?? 5   
   $??Название:??6   $
??Left=?6$   $??
493,82,0,0q?6?   $	??Top=?6S   ?? 5   
   $??	Сорт:??6   $
??Left=?6    $??493,113,0,0q?6;   $	??Top=?6P   ?? 5   
   $??Группа:??6   $
??Left=?6"   $??493,150,0,0q?6=   $	??Top=?6R   ?? 5    
   -
   5        
 ??Name$
 prname??5    R   $
??Left=?6b   $??
638,86,0,0q?6}    ?? TextWrapping$
 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *SelectedItem.ProductName+ ?? ElementName$ ProductT??6?   ?? 5!   
   -   5        $
 prsort??5!   R   $
??Left=?6b   $??638,117,0,0q?6}   $
 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *SelectedItem.ProductSort+$ ProductT??6?   ?? 5"   
   -   5        $
 prgroup??5"   S   $
??Left=?6d   $??638,158,0,0q?6   $
 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *SelectedItem.ProductGroup+$ ProductT??6?   ?? 5#   
   $"??Номер продукта:??6   $
??Left=?6*   $??
493,56,0,0q?6E   $	??Top=?6Y   ?? 5$   
   -   5        $

 prID??5$   P   $
??Left=?6^   $??
638,60,0,0q?6y   $
 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *SelectedItem.ProductID+$ ProductT??6?   ?? 5%   
   -   5        $	 savwchanges??5%      $+??%Сохранить изменения??6'   $??513,275,0,118q?6E   $
??Left=?6v   $	??128??6?   5(      5)      
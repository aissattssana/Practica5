   M S B A M L   `   `   `  ????D  @practica5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:practica5	practica5  5   	       practica5.Price   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:practica5     5   	     ? Title$  Price??5   	   $	??450??6   $	??800??6$   .??5	      ? .+?5
   
   ?? -   5        $??
Назад??5
      $??10,15,675,372q?6!   6O   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ PriceT??5         AutoGenerateColumns .     EnableRowVirtualization . $??0,74,372,85q?5   .   $
??Left=?6C      RowDetailsVisibilityMode$ VisibleWhenSelected=?5      ??5      ??    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        	ProductID??,  &System.Windows.Controls.DataGridColumn   Header$! Номер продукта??5   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   8   ?? *	ProductID+5   =     5      -   5        PlantID??$# Номер комбината??5   %   $ SizeToHeader 6>    5   6   ?? *	PlantID+5   >     5      -   5        ResponsiblePersonID??$6 0Номер ответственного лица??5   %   $ SizeToHeader 6H    5   B   ?? *ResponsiblePersonID+5   H     5      -   5        Pricestring??$ Цена??5   %   $ SizeToHeader 63    5   :   ?? *Price+5   3     5      -   5        DataOfChange??$! Дата изменения??5   %   $ SizeToHeader 6=    5   ;   ?? *DateOfChange+5   =   5      ?? 5   
   -   5        	 ??Name$	 delete??5      $??Удалить??6"   $??478,229,0,164q?64   $
??Left=?6`   $	??125??6{   6?   ?? 5   
   -	   5        $	 newprice??5      $??Добавить??6$   $??657,229,0,164q?67   $
??Left=?6e   $	??120??6?   6?   ?? 5   
   -
   5        $	 update??5      $??Обновить??6"   $??656,275,0,118q?65   $
??Left=?6a   $	??122??6|   ?? 5   
   -   5        $		 pdf??5      $$??создать ПДФ файл??6   $??638,338,56,51q?6K   $
??Left=?6b   6   ?? 5   
   -   5        
 ??Name$

 prID??5   N   $
??Left=?6\   $??
640,53,0,0q?6w    ?? TextWrapping$
 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *SelectedItem.ProductID+ ?? ElementName$ PriceT??6?   ?? 5    
   -   5        $

 plID??5    L   $
??Left=?6Z   $??
640,84,0,0q?6u   $
 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *SelectedItem.PlantID+$ PriceT??6?   ?? 5!   
   -   5        $

 rpID??5!   X   $
??Left=?6f   $??640,117,0,0q?6?   $
 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *" SelectedItem.ResponsiblePersonID+$ PriceT??6?   ?? 5"   
   -   5        $
 price??5"   J   $
??Left=?6Y   $??640,147,0,0q?6t   $
 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *SelectedItem.Price+$ PriceT??6?   ?? 5#   
   -   5        $

 data??5#   Q   $
??Left=?6_   $??640,177,0,0q?6z   $
 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *SelectedItem.DataOfChange+$ PriceT??6?   ?? 5$   
   $!??Номер продукта??6   $??
510,47,0,0q?6)   $
??Left=?6=   $	??Top=?6X   6r   ?? 5%   
   $!??Дата изменения??6   $??511,171,0,0q?6)   $
??Left=?6>   $	??Top=?6Y   6s   ?? 5&   
   $??Цена продукта??6   $??511,141,0,0q?6(   $
??Left=?6=   $	??Top=?6X   6r   ?? 5'   
   $6??0Номер ответственного лица??6   $??511,113,0,0q?64   $??9(?6I   $
??Left=?6V   $	??Top=?6q   6?   ?? 5(   
   $#??Номер комбината??6   $??
511,78,0,0q?6*   $
??Left=?6>   $	??Top=?6Y   6s   ?? 5)   
   -   5        $
 priceID??5)   L   $
??Left=?6]   $??
640,24,0,0q?6x   $
 Wrap=?6?   $	??Top=?6?   $	??137??6?   ??6   ?? *SelectedItem.PriceID+$ PriceT??6?   ?? 5*   
   $!??Номер операции??6   $??
510,18,0,0q?6)   $
??Left=?6=   $	??Top=?6X   ?? 5+   
   -   5        $	 savwchanges??5+      $+??%Сохранить изменения??6'   $??480,275,0,118q?6E   $
??Left=?6v   5,      5-      
   M S B A M L   `   `   `  ????V  RМагазин одежды, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Магазин_одеждыМагазин_одежды  5   	   0    *Магазин_одежды.Клиенты   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Магазин_одежды     5   	     ? Title$  Клиенты??5   	   $	??722??6   $
??1234??6&    ? WindowStartupLocation$ CenterScreen=?63   .??5	      ? ???	#FFACACAC.+?5
   
   ?? 
???   ?$??1q?6%   $
??Left=?69   $	??146??6T   $??	10,10,0,0q?6a   $	??Top=?6t   $
??1206??6?   
???????._?5      ?? $??
9,9,1062,9q?6   $??3093536-round.png??6(   $
??Fill=?6C   5      ?? 5   
   -   5         ??Name$ search??5      $
??Left=?6"   $??45??6=   $??
163,95,0,0q?6I    ?? TextWrapping$
 Wrap=?6]   $	??Top=?6q   $	??369??6?   
???????$??24(?6?   $??Sitka Small)?6?   .??6?   ??5      ?? 5      .R?5      ??  ?? CornerRadius$ 12??6    ?? Padding$ 2q?6/   $??1q?6;   
???   ?._?5      ??  ??Name$ PART_ContentHost??62   $??0q?6'   62   5      5      .??5       5      ?? 5   
   $??
Поиск??6   $
??Left=?6    $??
163,56,0,0q?6;   $	??Top=?6O   $??34??6g   $	??103??6s   $??Sitka Small)?6   $??24(?6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ tableКлиент??5         AutoGenerateColumns .  $
??Left=?6c   $	??520??6~   $??
10,161,0,0q?6?   $	??Top=?6?   $
??1111??6?   
???????$??Sitka Small)?6?   $??20(?6?   ??6(   ?? *Клиент+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 50 6%      Header$ Код??60   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   ?? *Код+  5      $
 * 6%   $ Имя??6/    6<   ?? *Имя+  5      $
 * 6%   $ Фамилия??6/    6@   ?? *Фамилия+  5      $
 * 6%   $ 
Улица??6/    6>   ?? *
Улица+  5      $
 * 6%   $ Дом??6/    6<   ?? *Дом+  5      $
 * 6%   $ Телефон??6/    6@   ?? *Телефон+5       ?? 5!   
   -   5        $
??Left=?5!      $??1126,601,0,0q?6,   $	??Top=?6B   $??90??6Z   $??80??6e   ???	#FF9CECB5.??5"      ?? $??70??6   $#??icons8-вернуть-100.png??6    $
??Fill=?6@   $??80??6O   5#      ?? 5$   
   -   5        $%??Случайный клиент??5$      $
??Left=?6,   $??
870,95,0,0q?6G   $	??Top=?6[   $	??333??6s   $??45??6   $??Sitka Small)?6?   $??24(?6?   ???	#FF9CECB56?   5%      5&      
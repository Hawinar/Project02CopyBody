   M S B A M L   `   `   `  ????L  HProject02CopyBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Project02CopyBodyProject02CopyBody  5   	   &     Project02CopyBody.WindowEmployee   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Project02CopyBody     5   	     ? Title$  WindowEmployee??5   	   $	??400??6    $	??625??6-    ? 
ResizeMode$ NoResize=?69   .??5	      ? .+?5
   
   ?? -   5         ??Name$ 
WelcomeSNP??5
      $??ФИО??6$   $
??Left=?62   $??	10,10,0,0q?6M   $	??Top=?6`    J? RenderTransformOrigin$ 0.226,0.005&?6x   $??20(?6?   ?? 5   
   -   5         ??Name$ ChangeOrder??5      $+??%Редактировать заказ??6&   $
??Left=?6D   $??	10,0,0,10q?6_   $??Bottom=?6r   $??31??6?   $	??139??6?   6?   ?? 5   
   -   5        $ GetOrderAtId??5      $#??Найти заказ по id??6'   $
??Left=?6C   $??	10,0,0,46q?6^   $??Bottom=?6q   $??31??6?   $	??139??6?   6?   ?? 5   
   -   5         ??Name$ tbFoundAtId??5      $
??Left=?6'   $??	10,0,0,82q?6B    ?? TextWrapping$
 Wrap=?6U   $?? ??6i   $??Bottom=?6q   $	??139??6?   ?? 5   
   -   5        $ tbCost??5      $
??Left=?6"   $??
180,0,0,10q?6=   $
 Wrap=?6Q   $?? ??6e   $??Bottom=?6m   $	??120??6?   $??31??6?   ?? 5   
   -   5        $ tbDateOfAcceptance??5      $
??Left=?6.   $??
323,0,0,10q?6I   $
 Wrap=?6]   $?? ??6q   $??Bottom=?6y   $	??120??6?   $??31??6?   ?? 5   
   -   5        $ tbStatus??5      $
??Left=?6%   $??
470,0,0,10q?6@   $
 Wrap=?6T   $?? ??6h   $??Bottom=?6p   $	??120??6?   $??31??6?   ?? 5   
   $??Цена??6   $
??Left=?6   $??
180,0,0,41q?6:   $??Bottom=?6N   $ 
0.29,0.156&?6i   ?? 5   
   $??Дата принятия??6   $
??Left=?6(   $??
323,0,0,41q?6C   $??Bottom=?6W   ?? 5   
   $??Статус??6   $
??Left=?6!   $??
470,0,0,41q?6<   $??Bottom=?6P   ?? 5   
   -   5        $ labelSNPvendorModelWork??5      $?? ??61   $
??Left=?6<   $??180,192,0,0q?6W   $	??Top=?6l   $	??410??6?   $	??109??6?   5      5      
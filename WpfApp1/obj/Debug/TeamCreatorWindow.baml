   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.TeamCreatorWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     ? Title$  TeamCreatorWindow??5   	   $	??502??6#   $	??807??60    ? 
ResizeMode$ NoResize=?6<   $??20(?6R   .??5
      ? $	??440??6   $??5,2,5,6q?6   .+?5   
   ?? $??30(?6   $??
20,0,0,409q?6   .??62   Create new Team6C   ?? 5   
   
???   ?$??20,60,20,61q?6$   ?? 5   
   
???   ?$??155,190,29,231q?6#   6=   ?? 5   
   $??
Team Name:??6   $??30,78,290,321q?6%   ?? 5   
   $??Knep:??6   $??30,190,334,219q?6    ?? 5   
   $??Key Player:??6   $??30,308,300,103q?6&   ?? 5   
   -   5        $??TeamNameTxtBox??5      $??155,78,29,321q?6)   ???	#FF0000026Z   d? 5   
   -   5         d?Name$ HemmaButton??5   W   $??1q?6    d? 	IsChecked$ FalseY?6E   $??155,190,157,231q?6m   .??6?   Hemma6?   d? 5   
   -   5        $ BortaButton??5   W   $??1q?6   $ FalseY?6E   $??283,190,29,231q?6l   .??6?   Borta6?   ?? 5   
   -   5         ??Name$ KeyPlayerTxtBox??5      $??155,293,29,103q?6,   ???	#FF0000026^   ?? 5   
   -   5        $??
HemmaBlock??5      $??0,463,440,0q?6&   6=   ? 5   
   $??20,428,29,10q?6   .+?5      ?? -   5        $??CreateTeambutton??5   v   $??10,-26,276,10q?6?   {?6   ??  ?? ElementName$ TeamNameTxtBox?? ?? Path$ Text.Length?.??6?   Create6?   ?? 5      -   5        $??CancelTeamCreator??5   5   $??290,-26,0,10q?6N   .??6d   Cancel6l   5      ?? 5   
   -   5         ??Name$ helloshitter??5      $??416,97,-174,185q?6(   6C   5       5!      
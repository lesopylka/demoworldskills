   M S B A M L   `   `   `  ����@  <demo1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:demo1demo1  5   	       demo1.KlientChoices   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:demo1     5   	     � Title$  KlientChoices��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  $��	0,32,0,64q�6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 62   6>     5      $ Код клиента��6%   $ * 6:   6F     5      $' !Паспортные данные��6%   $ * 6@   6L     5      $ Дата рождения��6%   $ * 6<   6H     5      $ 
Адрес��6%   $ * 64   6@     5      $ e-mail��6%   $ * 65   6A     5      $ password��6%   $ * 67   6C   5      �� 5   
      btnStyle#��[  6   $��Добавить��6?   $
��Left=�6R   $��32��6m   $��
33,375,0,0q�6y   $	��Top=�6�   $	��166��6�   ���	#FF76E383$��Comic Sans MS)�6�   �� 5   
   #���   6   $��Удалить��6@   $
��Left=�6R   $��32��6m   $��225,375,0,0q�6y   $	��Top=�6�   $	��175��6�    J� RenderTransformOrigin$ 0.479,0.989&�6�   �� 5   
   #���   6   $ ��Редактировать��6@   $
��Left=�6X   $��32��6s   $��430,375,0,0q�6   $	��Top=�6�   $	��184��6�   �� 5   
   $
��Left=�6   $��20��6-   $��	617,7,0,0q�69    �� TextWrapping$
 Wrap=�6L   $��TextBox��6`   $	��Top=�6o   $	��173��6�   5      5      
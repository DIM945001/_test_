   M S B A M L   `   `   `  ����C  ?WpfApp32, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp32WpfApp32  5   	       WpfApp32.auth   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp32     5   	     � Title$  Авторизация��5   	   $	��250��6   $	��400��6*   .��5	      � -   5         �Name$ authgrid��5	      $��0,0,38,0q�6    � ColumnDefinitions 5   
   �� 5      $	��155 �6   �� 5      .+�5   
   �� $��
Логин��6   $
��Left=�6    $��0��6;   $��	34,46,0,0q�6H   $	��Top=�6[   $��43��6s   $��81��6   $��20(�6�   �� 5   
   -   5         ��Name$ parol��5      $��Пароль��6   $��34,104,28,61q�60   $��20(�6F   �� 5   
   -   5         ��Name$ textbox1��5      $��1��6$   $
��Left=�64   $��38��6O   $��	40,53,0,0q�6[    �� TextWrapping$
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��144��6�   $��20(�6�   G� 5   
   -   5         G�Name$ textbox2��5      $��1��6(   $
��Left=�68   $��
40,104,0,0q�6S   $	��Top=�6g   $	��144��6   $��20(�6�   $��45��6�   �� 5   
   -   5         ��Name$ 	acceptbut��5      $��
Войти��6$   $��1��64   $
��Left=�6D   $��
40,165,0,0q�6_   $	��Top=�6s   $	��144��6�   $��35��6�    �� 	IsDefault . 6�   �� 5   
   -   5        	 ��Name$	 comboBox��5      $
��Left=�6%   $��
34,165,0,0q�6@   $	��Top=�6T   $��93��6l   $��35��6w   .@�5      �� $��клиент��6   �� 5      $��сотрудник��6   �� 5      $��инспектор��6   �� 5      $��бухгалтер��6   5      5      5      
   M S B A M L   `   `   `  ����B  >Midterm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MidtermMidterm  5   	       Midterm.PersonWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Midterm     5   	     � Title$  PersonWindow��5   	   $	��700��6   $
��1500��6+   .��5	      � .+�5
   
   o� $	��Top=�6   .@�5      m� $
��Left=�6   $	��Top=�62   $��_File��6J   .@�5      m� -   5        $��mnuNew��5   )   $
��_New��6    m� InputGestureText$ Ctrl+N��67   m� 5      -   5        $��mnuSave��5   *   $��_Save��6   $ Ctrl+S��69   �� 5      m� 5      -   5        $��E_xit��5      $ Alt+F4��6*   6D   5      m� 5      $
��Left=�6   $	��Top=�62   $��_Edit��6J   .@�5      m� -   5        $��	mnuInsert��5   ,   $��_Insert��6   $ Ctrl+I��6=   6W   m� 5      -   5        $��	mnuUpdate��5   ,   $��_Update��6   $ Ctrl+U��6=   6W   m� 5      -   5        $��	mnuDelete��5   -   $��_Delete��6   $ Ctrl+D��6>   6X   5      m� 5      -   5        $
��Help��5   2   $
��Left=�6   $	��Top=�6>   $��_Help��6V   5      5      � 5   
   $��
0 30 10 10q�6    � ShowGridLines$
 True��6#    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $��* �6    �� 5       $��* �6    .+�5"      �� $��0��6   $��0��6"   $��2q�62   
���   �$��1q�6Q   ���	#FFFFFF806e   �� 5#      -   5        $��0��5#      $��0��6"   $��Insert��62   ���	#FF5A994D$��30(�6o   �� 5$      $��0��6   $��1��6"   $��2q�62   
���   �$��1q�6Q   ���	#FFFF80806e   �� 5%      -	   5        $��0��5%      $��1��6"   $��Update��62   ���	#FF5AA64B$��30(�6q   �� 5&      $��1��6   $��0��6"   $��2q�62   
���   �$��1q�6Q   ���	#FF8080FF6e   �� 5'      -
   5        $��1��5'      $��0��6"   $��Delete��62   ���	#FFF91647$��30(�6q   �� 5(      $��1��6   $��1��6"   $��2q�62   
���   �$��1q�6Q   ���	#FF80FF806e   �� 5)      -   5        $��listBox��5)   -   ���	#FF5A994D$��1��6=   $��2��6J   $��20(�6Z   .@�5*      �� $k��e Id       Name          Address                   Email                                    Age       ��6   5,      5.      5/      51      
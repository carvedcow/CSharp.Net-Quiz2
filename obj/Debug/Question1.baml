   M S B A M L   `   `   `  ����K  GCSharp.Net-Quiz2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CSharp.Net_Quiz2CSharp.Net_Quiz2  5   	   !    CSharp.Net_Quiz2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CSharp.Net_Quiz2     5   	     � Title$  
MainWindow��5   	   $	��220��6   $	��280��6)   
����ح�.��5	      � $��30q�6   
����ح� � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $	��100 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� 
��� � �$
��Bold"�6#   .��65   First Name:6B   �� 5   
   -   5         ��Name$ tbFName��5      $��1��6#   $��0,0,0,10q�63   �� 5   
   $��1��6   
��� � �$
��Bold"�60   .��6B   
Last Name:6N   �� 5   
   -   5        $ tbLName��5      $��1��6#   $��1��60   $��0,0,0,10q�6@   �� 5   
   $��2��6   
��� � �$
��Bold"�60   .��6B   Phone Number:6Q   �� 5   
   -   5        $ tbPhoneNumber��5      $��2��6)   $��1��66   $��0,0,0,10q�6F   �� 5   
   -   5         ��Name$ btnSave��5      $��3��6"   .��6B   Save6H   �� 5   
   -   5        $ btnReset��5      $��3��6#   $��1��60   .��6T   Reset6[   5      5      
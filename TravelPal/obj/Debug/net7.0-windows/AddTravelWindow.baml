   M S B A M L   `   `   `  ����D  @TravelPal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TravelPal	TravelPal  5   	       TravelPal.AddTravelWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TravelPal     5   	     � Title$  AddTravelWindow��5   	   $	��450��6!   $	��800��6.   
������.��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      $��114.286 �6   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��1��5      $��City:��5      $��25(�5      $��Center=�5       $��Center=�5!      �� 5"   
   $��2��5#      $��Country:��5$      $��25(�5%      $��Center=�5&      $��Center=�5'      �� 5(   
   $��3��5)      $��	Travelers��5*      $��25(�5+      $��Center=�5,      $��Center=�5-      �� 5.   
   -   5        $��txtCity��5/      $��1��50      $��1��51      $��2��52      $��35��53      $	��200��54      �� 55   
   -   5        $��
txtCountry��56      $��2��57      $��1��58      $��2��59      $��35��5:      $	��200��5;      �� 5<   
   -   5        $��txtTravelers��5=      $��3��5>      $��1��5?      $��2��5@      $��35��5A      $	��200��5B      �� 5C   
   -   5        $��	cbPurpose��5D      $��1��5E      $��3��5F      $��40��5G      5J      �� 5L   
   -   5        $��chkAllInclusive��5M      $��All Inclusive��5N      $y�	Collapsed=�5O      $��3��5P      $��3��5Q      �� 5T   
   -   5        $��txtMeetingDetails��5U      $��Meeting Details:��5V      $��15(�5W      $y�	Collapsed=�5X      $��3��5Y      $��3��5Z      $��2��5[      �� 5_   
   -   5         ��Name$ 	cbCountry��5a      $��1��5b      $��5��5c      $��40��5d      �� 5e   
   -   5        $��20(�5g      $��50��5h      $	��100��5i      $��4��5j      $��1��5k      $��2��5l      $
��Save��5m      5n      5{      5|      
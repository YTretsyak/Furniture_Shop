   M S B A M L   `   `   `  ����C  ?Capstone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CapstoneCapstone  5   	   A%clr-namespace:Capstone.MVVM.ViewModelCapstone.MVVM.ViewModel  5   	       Capstone.Second   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   "localclr-namespace:Capstone  5   	   5	viewModel%clr-namespace:Capstone.MVVM.ViewModel  5   	   -   5          � Title$  Noted!��5	   	   $	��600��5
      $	��920��6'    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      +   %Capstone.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 12��6"   ._�5   
   �  � RowDefinitions 5      �� 5      $��75 �6    �� 5       � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      .+�5      �� $��Center=�6   $
��Left=�6/   $.��(D:\2sem\OOP2sem\Capstone\Images\Logo.jpg��6J   $	��198��6|   $	��198��6�   �� 5       -   5        $��0��5       $��1��5!      $	��Top=�5"      $��Right=�5#         
ExitButton#��[  5$      5%      �� 5&      $��0��6   $��1��6&   	 �� Orientation$	 
Horizontal=�66   $��Right=�6O   $	��100��6k   $��0, 0, 50, 0q�6w   .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon  ���#CFCFCF
   Kind$

 User=�6?   $��25��6K   $��25��6V   $��Center=�6b   �� 5(      -   5         ��Name$ Username��5(        MaterialDesignTextBlock#��[ 5)      $��Center=�5*      $��Right=�5+       � ToolTip$ Username��5,      ���#CFCFCF5-      5.      �� 5/      $��1��6   $��0��6&   .+�50      	� $
��Home��6   $��50��51      
�������$��14(�53        MenuButtonTheme#��[ 54       d� 	IsChecked$
 TrueY�55      ��56      �� *HomeViewCommand+	� 57      $��	Discovery��6   $��50��58      
�������$��14(�5:      #��[ 5;      ��5<      �� *DiscoveryViewCommand+	� 5=      $��Browse��6   $��50��6/   
�������$��14(�6N   #��[ 6\   5>      �� 5?      -   5         ��Name$ btnLeave��5F      $��1��5?      $��0��5@      $��Bottom=�5A      $��
0, 0,0, 50q�5B      $
 Exit��5C       & "MaterialDesignFloatingActionButton#��[ 5D      ��5E      Z� .��5H        $

 Door=�6)   ���#CFCFCF$��30��6J   $��30��6U   5I      �� 5J      $��Center=�6   $
��Left=�68   $��5q�6S   $��0��6^   $��1��6k     SearchTextBox#��[ 6{   �� 5K      $��1��6   $��1��5L      $��10q�5M      ��5N      �� *CurrentView+5O      5P      5Q      
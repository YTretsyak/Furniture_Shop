   M S B A M L   `   `   `  ����J  FFurniture_Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Furniture_Store.MVVM.ViewModelFurniture_Store.MVVM.ViewModel  5   	   1clr-namespace:Furniture_StoreFurniture_Store  5   	        Furniture_Store.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   B	viewModel,clr-namespace:Furniture_Store.MVVM.ViewModel     5   	   /localclr-namespace:Furniture_Store     5   	   $	��600��5	   	   $	��920��6     � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      2  ,Furniture_Store.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#f8ffc9 �� CornerRadius$ 20��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5       �� $��Mobilia��6   $��Center=�5!      $��Center=�5"      
���   �$��30(�5$      �� 5&      $��1��6   .+�5'      	� -   5         	�Name$ 
HomeButton��5'      $
��Home��5(      $��50��5)      
���   �$��14(�5+         MenuButtonTheme#��[  5,      {�.  ��5.      �� *HomeViewCommand+	� 50      -   5        $ OrdersButton��50      $��Orders��51      $��50��52      
���   �$��14(�54      {�.  #��[  56      ��57      �� *OrdersViewCommand+	� 59      -   5        $ BasketButton��59      $��Basket��5:      $��50��5;      
���   �$��14(�5=      {�.  #��[  5?      ��5@      �� *BasketViewCommand+	� 5B      $��User Management��6   $��50��5C      
���   �$��14(�5E       d� 	IsChecked$
 TrueY�5F      #��[  5G      ��5H      �� *UserViewCommand+5I      �� 5K      $	��250��6   $��40��5L      $��Center=�5M      $
��Left=�5N      $��5q�5O      $��1��5P        ModernTextBox#��[ 5Q      �� 5S      $��1��6   $��1��5T      $��10q�5U      ��5V      �� *CurrentView+5X      5Y      5Z      
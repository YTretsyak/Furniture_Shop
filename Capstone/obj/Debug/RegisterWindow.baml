   M S B A M L   `   `   `  ����C  ?Capstone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CapstoneCapstone  5   	   A%clr-namespace:Capstone.MVVM.ViewModelCapstone.MVVM.ViewModel  5   	       Capstone.RegisterWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   "localclr-namespace:Capstone  5   	   5	viewModel%clr-namespace:Capstone.MVVM.ViewModel  5   	     � Title$  Noted!��5	   	   $	��450��5
      $	��800��6'    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   .��5      � -   5        ��5   
   �� 5       �� 
StartPoint$ 0.1, 0&�6"    �� EndPoint$ 0.9, 1&�66   .��5      �  � Color$ #5BC3FF��6    � Offset$	 0.0Q�6/   � 5      $ #3AA0FF��6   $ 1Q�6/   5      .+�5   
   �� $	��390��6   $	��Top=�6   ���#272537	 �� CornerRadius$	 0, 0, 180, 0��6K   �� 5   
   
 �� Orientation$
 
Horizontal=�6   .+�5      �� $	��350��6   .+�5      �� -   5         ��Name$ btnBack��5      $
��Left=�5      $��10, 20q�5       &  "MaterialDesignFloatingActionButton#��[  5       � ToolTip$
 Back��5      ��5      Z� .��5!      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Arrow=�62   ���#CFCFCF$��30��6U   $��30��6`    J� RenderTransformOrigin$ 0.5, 0.5&�6l   z�5"      �� 5#   "    �� ScaleX$ -1Q�61   5%      5&      �� 5'      $.��(D:\2sem\OOP2sem\Capstone\Images\Logo.jpg��6   $	��198��6N   $	��198��6Z   $	��Top=�6g   $��0, 20, 0, 0q�6   5(      �� 5)      $	��350��6   .+�5*      �� $��20 40q�6   .+�5+      �� $��Registration��6    $��20q�64   ���#CFCFCF �� TextAlignment$ Center=�6U   $��38(�6l   �� 5,      $
 
Horizontal=�6!   $��10q�6:   .+�5-        $ Email=�62   $��25��6?   $��25��6J   ���#CFCFCF6V   �� 5.      -   5         ��Name$ Email��5.   "   $
��10 0q�5/   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter Email��50   "   ���#CFCFCF$	��250��52   "   ���#CFCFCF �� 
CaretBrush �	#FFD94448 �� SelectionBrush �	#FFD9444855   "   56      �� 57      $
 
Horizontal=�6!   $��10q�6:   .+�58        $
 User=�62   $��25��6>   $��25��6I   ���#CFCFCF6U   �� 59      -   5        $ UserName��59   "   $
��10 0q�5:   "   $ Enter Username��5;   "   ���#CFCFCF$	��250��5=   "   ���#CFCFCF �	#FFD94448 �	#FFD944485@   "   5A      �� 5B      $
 
Horizontal=�6!   $��10q�6:   .+�5C        $
 Lock=�62   $��25��6>   $��25��6I   ���#CFCFCF6U   G� 5D      -   5         G�Name$ UserPassword��5D   &   $
��10 0q�5E   "   $ Enter Password��5F   "   ���#CFCFCF$	��250��5H   "   ���#CFCFCF G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD944485K   "   5L      �� 5M      $
 
Horizontal=�6!   $��10q�6:   .+�5N        $
 Lock=�62   $��25��6>   $��25��6I   ���#CFCFCF6U   G� 5O      -   5        $ ConfirmUserPassword��5O   &   $
��10 0q�5P   &   $ Confirm Password��5Q   &   ���#CFCFCF$	��250��5S   &   ���#CFCFCF �	#FFD94448 �	#FFD944485V   &   5W      �� 5X      $��10q�6!   $��Center=�6-   .+�5Y      �� -   5        $ btnRegister��5b   !   $	��100��5Y   !   $��40��5Z   !     MaterialDesignRaisedButton#��[ 5[   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5\   !   $��2q�5]   !   ���#5BC3FF���#5BC3FF
�������$ Login��5a   !   $��Register��5c   !   5d   !   5e      5f      5g      �� 5h      $	��100��6   .+�5i      �� -   5        $ btnExit��5m      $��10 20q�5i      #��[  5j      $ Close��5l      ��5k      Z� .��5o        $ Close=�6.   ���#CFCFCF$��30��6P   $��30��6[   5p      5q      5r      5s      5t      
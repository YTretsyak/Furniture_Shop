   M S B A M L   `   `   `  ����C  ?Capstone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CapstoneCapstone  5   	   A%clr-namespace:Capstone.MVVM.ViewModelCapstone.MVVM.ViewModel  5   	       Capstone.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   "localclr-namespace:Capstone  5   	   5	viewModel%clr-namespace:Capstone.MVVM.ViewModel  5   	     � Title$  Noted!��5	   	   $	��450��5
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
Horizontal=�6   .+�5      �� $	��350��6   .+�5      �� $.��(D:\2sem\OOP2sem\Capstone\Images\Logo.jpg��6   $	��198��6J   $	��198��6V   $	��Top=�6c   $��0, 100, 0, 0q�6{   5      �� 5      $	��350��6   .+�5      �� $��20 40q�6   .+�5      �� $��
User Login��6    $��20q�62   ���#CFCFCF �� TextAlignment$ Center=�6S   $��38(�6j   �� 5      $
 
Horizontal=�6!   $��10q�6:   .+�5       '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�62   $��25��6>   $��25��6I   ���#CFCFCF6U   �� 5!      -   5         ��Name$ UserName��5!   "   $
��10 0q�5"   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter Username��5#   "   ���#CFCFCF$	��250��5%   "   ���#CFCFCF �� 
CaretBrush �	#FFD94448 �� SelectionBrush �	#FFD944485(   "   5)      �� 5*      $
 
Horizontal=�6!   $��10q�6:   .+�5+        $
 Lock=�62   $��25��6>   $��25��6I   ���#CFCFCF6U   G� 5,      -   5         G�Name$ UserPassword��5,   &   $
��10 0q�5-   "   $ Enter Password��5.   "   ���#CFCFCF$	��250��50   "   ���#CFCFCF G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD9444853   "   54      �� 55      $��10q�6!   $��Center=�6-   .+�56      �� -   5         ��Name$ btnLogin��5?   !   $	��100��56   !   $��40��57   !      MaterialDesignRaisedButton#��[  58   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��59   !   $��2q�5:   !   ���#5BC3FF���#5BC3FF
������� � ToolTip$ Login��5>   !   $��Login��5A   !   �� 5B      -   5        $��12(�5B   $   $)��#Don't Have an Account? Register Now��5C   $   ���#CFCFCF$��0, 10, 0, 0q�5E   $   ��5G      �� 5H   "    �� 
TargetType" ��6(    �� Triggers 5I   &   P� 5J   *    P� Property �@J�IsMouseOver P� Value . . �5K   .   ��  �� Property � �� �� Value$ 	Underline{�6P   �� 5L   .    �@�Cursor$
 Hand��6G   5M   +   5O   #   5Q      5R      5S      5T      �� 5U      $	��100��6   .+�5V      �� -   5        $ btnExit��5Z      $��10 20q�5V       & "MaterialDesignFloatingActionButton#��[ 5W      $ Close��5Y      ��5X      Z� .��5\        $ Close=�6.   ���#CFCFCF$��30��6P   $��30��6[   5]      5^      5_      5`      5a      
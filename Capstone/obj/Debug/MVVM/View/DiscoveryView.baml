   M S B A M L   `   `   `  ����C  ?Capstone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Capstone.MVVM.ViewCapstone.MVVM.View  5      A%clr-namespace:Capstone.MVVM.ViewModelCapstone.MVVM.ViewModel  5      &     Capstone.MVVM.View.DiscoveryView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Capstone.MVVM.View     5      ;	viewModel%clr-namespace:Capstone.MVVM.ViewModel     5        � DataContext  5
      +   %Capstone.MVVM.ViewModel.MainViewModel  5   
   .��5      ]� $��1q�6   .+�5   
   o� $	��Top=�6   ���#272537@�5      m� 5      $
��File��6      MenuItemTheme#��[  6F     6)   �� *File+.@�5      m� $	��New��6   
���   � m� Command 6,   �� *
NewCommand+6K   m� 5      $
��Open��6   
���   � 6-   �� *OpenCommand+6M   m� 5      $
��Save��6   
���   � 6-   �� *SaveCommand+6M   m� 5      $��
Save as...��6   
���   � 63   �� *SaveAsCommand+6U   5      m� 5      $��Format��6   #��[  6J     6+   �� *Editor+.@�5      m� $��Format��6   
���   � 6/   �� *FormatCommand+6Q   m� 5      $��	Word wrap��6   
���   � 62   �� *WrapCommand+ m� 	IsChecked 6e   �� *Format.isWrapped+5      5      ]� 5   
   .+�5      �� $��Bottom=�6     5      �� *File.Document+��5       �� *
FilePath+�� 5!      $	��Top=�6   " �� VerticalScrollBarVisibility$ Visible=�5"       �� AcceptsReturn .  �� 
AcceptsTab . ���#272537���#CFCFCF  5#      �� *Editor+��5$      �� *Format.Family+��5%      �� *Format.Size+��5&      �� *Format.Style+��5'      �� *Format.Weight+ �� TextWrapping 5(      �� *Format.Wrap+��5+      �� *Document.Text+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��5-   +   5.      5/      50      51      
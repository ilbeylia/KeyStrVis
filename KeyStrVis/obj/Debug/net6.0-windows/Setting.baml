   M S B A M L   `   `   `  ����D  @KeyStrVis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:KeyStrVis	KeyStrVis  5          KeyStrVis.Setting   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      %localclr-namespace:KeyStrVis   5      .��5      �   � RowDefinitions  5   
   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��50 �6#   .+�5      � $��0��6   .+�5      �� $	��Top=�6   $
��Left=�65   $��Setting��6P   $��	20 10 0 0q�6_   ���#ffff$��18(�6�   $
��Bold"�6�   5      � 5      $��1��6   .+�5      �� 
������ $��5q�62   ._�5      �� -   5         ��Name$ Setting_Save_Button��5         
IconButton#��[  6O   ${�False��6s   .��5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ CheckCircle=�60   $��Center=�6C   $��Center=�6`   5      5      5      5      � 5    
   $��1��6   .+�5!      �� 
������ ._�5"      ��  �� Orientation$ Vertical=�6   .+�5#      �� $	��0.6��6    $	��Top=�6-   $��0 5 0 5q�6E   $	��250��6V   ���#ffffff6b   �� 5$      ._�5%      �� -   5        $ ColorOptions_Button��5%   !     DynemicButton#��[ 6>   $��Color��6e   6u   5&      � 5(      -   5         �Name$ ColorOptionsGrid��5(      $��80��65   $y�Visible=�6A   .+�5)      �� $ Vertical=�6%   .+�5*      �� ���#CED4DA �� CornerRadius$ 5��6:   $	��250��6K   $��30��6W   $�� 0 5 0 5q�6c   ._�5+   "   �� $ 
Horizontal=�6-   .+�5,   &   �� $��
Background��60     TextBlockStyle#��[ 6B   �� 5-   &   -   5         ��Name$ BackgroundColor_rectangel��5-   0   $��20��6S   $��20��6^   $
��Left=�6j   $��20 0 0 0q�6�   ���#FFFF6�   5/   #   50      �� 52      ���#CED4DA$ 5��6:   $	��250��6K   $��30��6W   $�� 0 5 0 5q�6c   ._�53   "   �� $ 
Horizontal=�6-   .+�54   &   �� $��
Foreground��60   #��[ 6B   �� 55   &   -   5        $ ForegroundColor_rectangel��55   0   $��20��6S   $��20��6^   $
��Left=�6j   $��21 0 0 0q�6�   ���#FFFF6�   56   #   57      58      59      �� 5:      $	��0.6��6    $	��Top=�6-   $��0 5 0 5q�6E   $	��250��6V   ���#ffffff6b   �� 5=      ._�5>      �� -   5        $ OpacityOptions_Button��5>   !   #��[ 6@   $��Opacity��6g   6y   5?      � 5@      -   5        $ OpacityOptionsGrid��5@      $y�Visible=�67   .+�5A      �� $ Vertical=�6%   .+�5B      �� ���#CED4DA$ 5��6:   $	��250��6K   $��30��6W   $�� 0 5 0 5q�6c   ._�5C   "   �� $ 
Horizontal=�6-   .+�5D   &   �� $��Opacity��60   #��[ 6?   �� 5E   &   -   5         ��Name$ Opacity_Slider��5E   -   	 � Maximum$	 1Q�6E   
 � Minimum$
 0Q�6Q   $��Center=�6]   $��50 0 0 0q�6x   $	��100��6�   5G   #   5H      5I      5J      �� 5K      $	��0.6��6    $	��Top=�6-   $��0 5 0 5q�6E   $	��250��6V   ���#ffffff6b   �� 5N      ._�5O      �� -	   5        $ TypographyOptions_Button��5O   !   #��[ 6C   $��
Typography��6j   6   5P      � 5R      -
   5        $ TypographyOptionsGrid��5R      $y�Visible=�6:   .+�5S      �� $ Vertical=�6%   .+�5T      �� ���#CED4DA$ 5��6:   $	��250��6K   $��30��6W   $�� 0 5 0 5q�6c   ._�5U   "   �� $ 
Horizontal=�6-   .+�5V   &   �� $
��Font��60   #��[ 6<   5X   #   5Y      �� 5Z      ���#CED4DA$ 5��6:   $	��250��6K   $��30��6W   $�� 0 5 0 5q�6c   ._�5[   "   �� $ 
Horizontal=�6-   .+�5\   &   �� $��	Font Size��60   #��[ 6A   5]   #   5^      �� 5`      ���#CED4DA$ 5��6:   $	��250��6K   $��30��6W   $�� 0 5 0 5q�6c   ._�5a   "   �� $ 
Horizontal=�6-   .+�5b   &   �� $��	Alignment��60   #��[ 6A   �� 5c   &   -   5        $ 
alignRight��5c   -   $��50 0 0 0q�6A   
������ 
������ $��0q�6�    � Cursor$
 Hand��6�   .��5d   *     $ FormatAlignRight=�6@   $��Center=�6Y   ���#ffff6t   5e   '   �� 5f   &   -   5        $ alignCenter��5f   -   $��20 0 0 0q�6B   
������ 
������ $��0q�6�   $
 Hand��6�   .��5g   *     $ FormatAlignCenter=�6A   $��Center=�6[   ���#ffff6v   5h   '   �� 5i   &   -   5        $ 	alignLeft��5i   -   $��20 0 0 0q�6@   
������ 
������ $��0q�6�   $
 Hand��6�   .��5j   *     $ FormatAlignLeft=�6A   $��Center=�6Y   ���#ffff6t   5k   '   5l   #   5m      5n      5q      �� 5s      $	��0.6��6    $	��Top=�6-   $��0 5 0 5q�6E   $	��250��6V   ���#ffffff6b   5t      5u      5v      5x      5y      
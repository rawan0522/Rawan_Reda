   M S B A M L   `   `   `  ����P  Lregisttration desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:registtration_desktopregisttration_desktop  5      "    registtration_desktop.Searsh   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:registtration_desktop     5        N� Title$  Searsh��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��13* �6   �� 5      $	��23* �6   �� 5      $	��54* �6    � ColumnDefinitions 5   
   �� 5      $
��245* �6   �� 5      $
��331* �6   �� 5      $
��224* �6   .+�5   
   �� $��Search Form��6   $
��Left=�6(   $	��Top=�6C   $	��204��6[   $��50��6g   
���   �$��30(�6�   $
��Bold"�6�   $��MV Boli)�6�   $��	53,10,0,0q�6�   $��1��6�   �� 5   
   $
��City��6   $
��Left=�6   $��	98,54,0,0q�6:   $	��Top=�6M   $��37��6e   $��94��6q   $��20(�6|   $
��Bold"�6�   $��MV Boli)�6�    J� RenderTransformOrigin$ 
0.79,0.394&�6�   $��1��6�   �� 5   
   -   5         ��Name$ city_txt��5      $
��Left=�6$   $��	53,54,0,0q�6?    �� TextWrapping$
 Wrap=�6R   $�� ��6f   $	��Top=�6o   $	��233��6�   $��37��6�   $��1��6�   $��1��6�   �� 5   
   -   5         ��Name$ search��5   0    	  task3#��[  6   $��Search��6@   $
��Left=�6Q   $��	40,20,0,0q�6l   $	��Top=�6   $��37��6�   $	��135��6�   
�������
�������$��MV Boli)�6�   $��20(�6�   $
��Bold"�6�   $��2��6   $ 0.666,0.516&�60  $��2��6T  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg��5      $��0,78,0,0q�6J   $��3��6\   $��2��6p   5      5      
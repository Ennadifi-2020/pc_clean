   M S B A M L   `   `   `  ����A  =Update, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UpdateUpdate  5   	       Update.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Update     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $��0* �6   �� 5      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ Black��6    � Offset$ 1Q�6-   � 5      $ 	#FFFCDADA��6   $ 0.986Q�61   5       � ColumnDefinitions 5   
   �� 5      $	��68* �6   �� 5      $	��89* �6   �� 5      $
��637* �6   .+�5   
   � -   5         �Name$ 	prog_bar2��5      $
��Left=�6)   $��29��6E   $y�Hidden=�6Q   $	��Top=�6e   $	��361��6}   $��37.2,59,0,0q�6�   ���	#FFF9F7CF���	#FFFDB827$��2��6�   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   $��1��6�   z�5      V� 5      .~�5      �� �� 5      �� 5      
 �� Angle$
 -0.024Q�6&   T� 5       5!      5#      �� 5$   
   -   5         ��Name$ btn_dwn��5$      $��download��6"   $
��Left=�65   $	��Top=�6P   $	��253��6h   $��118.2,137,0,0q�6t   $��48��6�   $	 0.524,-0.359&�6�   $��24(�6�   ���	#FFFFA5A5���	#FFFFA5A5
�������$��2��6!  $
��Bold"�61  $��Italic$�6C  $��1��6V  �� 5%   
   -   5         ��Name$ 	lbl_prcnt��5%      $�� ��6#   $
��Left=�6.   $��213.2,37,0,0q�6I   $	��Top=�6_   $��2��6w   $��26��6�   $��1��6�   $��10��6�   �� 5&   
   -   5        $ 	lbl_logo1��5&      $��NDF FZ��6#   $
��Left=�64   $	��Top=�6O   $��2��6g   $��245.2,29,0,0q�6w   $	��109��6�   $��18(�6�   $��Italic$�6�   $
��Bold"�6�   ���	#FFFFA5A5$	 0.706,0.566&�6�   $��1��6  $��34��6  �� 5'   
   -   5        $ 	lbl_logo2��5'      $��
PC-CLEANER��6#   $
��Left=�68   $	��Top=�6S   $��2��6k   $��239.2,68,0,0q�6{   $	��120��6�   $��18(�6�   $��Italic$�6�   $
��Bold"�6�   ���	#FFFFA5A5$��1��6�   $��34��6�   �� 5(   
   -   5         ��Name$ img_logo��5(      $��2��6"   $��170.2,23,402.6,319q�62   $��sweeping.png��6N   $
��Fill=�6d   $��1��6s   �� 5)   
   -   5        $ lbl_percent��5)      $	��100��6%   $y�Hidden=�63   $
��Left=�6G   $	��Top=�6b   $��2��6z   $��393.2,54,0,0q�6�   $��22(�6�   $
��Bold"�6�   $��Italic$�6�   
�������$��1��6�   $��40��6�   $��48��6�   5+      5,      
   M S B A M L   `   `   `  ����F  BVoidProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:VoidNullVoidNull  5   	   5clr-namespace:VoidNull.ControlsVoidNull.Controls  5   	       VoidNull.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:VoidNull     5   	   4Controlsclr-namespace:VoidNull.Controls     5   	     � Title$  
MainWindow��5	   	   $
��1080��6   $
��1920��6*    � UseLayoutRounding .  � WindowState$ 	Maximized=�6P    � WindowStartupLocation$ CenterOwner=�6h   .��5
      �  � RowDefinitions 5   
   �� 5      $	��40* �6   $��40��6)   $��40��68   �� 5      $
��917* �6   $	��154��6*   �� 5      $��6* �6   $��5��6(   $��5��66   �� 5      $
��100* �6   $	��100��6*   $	��100��6:    � ColumnDefinitions 5   
   �� 5      $��1685* �6   $	��180��6-   �� 5      $��6* �6   $��5��6*   �� 5      $
��200* �6   $	��200��6,   $	��200��6;   .+�5   
   �� -   5         ��Name$ topMenu��5      $��3��6&      tollbarColor#���   6:    �� Orientation$ 
Horizontal=�6f   .+�5      7  1System.Windows.Controls.Primitives.CalendarButton  -   5          Name$ saveBut��5      $
��save��6.   $��Center=�6=   $��Center=�6_   $
��Left=�6�   $	��100��6�   $��10��6�   $��80��6�   $��17.333(�6�   6    5      -   5        $ openBut��5      $
��open��6.   $��Center=�6=   $��Center=�6_   $
��Left=�6�   $	��100��6�   $��10��6�   $��80��6�   $��17.333(�6�   6  5      �� 5   
   -   5        	 ��Name$	 
editorView��5      $��1��6+   
 � IsSharedSizeScope
 .  �� PanningMode$
 Both=�6V    �� PanningDeceleration$	 0.1Q�6i   $��Stretch=�6�   $��Stretch=�6�   $��Hidden=�6�   $��Hidden=�6�   .��5      �� -   5         ��Name$ canvas��5      $
��4995��6%   $
��5000��63   |�.   EarlGray#���  6Q    � ContextMenu 5      �� 5      -   5         ��Name$ canvasContextMenu��5   "   .@�5      m� $��add node��6#    m� Command$ ApplicationCommands.New��67   �� 5      6&   m� 5       $
��open��6#   $ ApplicationCommands.Open��63   m� 5!      $��clear��6#   $  ApplicationCommands.Delete��64   5"      5$      5%      �� 5&   
   -   5        $	 InspectorView��5&      $��2��6.   $��1��6>    �� PanningRatio$ 2Q�6K   $��Stretch=�6\   $��Stretch=�6�    J� IsManipulationEnabled . $ VerticalFirst=�6�   .��5'      �� -   5        $ inspectorStack��5'      $
��2000��61   #���  6?   |�.  �� CanVerticallyScroll .  �� CanHorizontallyScroll .  .  .+�5(      �� -	   5         ��Name$ selectedName��5(      $��selected��6.   $��21.333(�6A   $��Disabled=�6S   
����������	#33FFFFFF$��
10,10,10,6q�6�   $��10,0,0,0q�6�   $��40��6�   $��Center=�6�   5)      5*      �� 5+   
   -
   5        $	 	itemsView��5+      $��3��6*   $
 Both=�67    . $ 0.0005Q�6g   $ 2Q�6�   $��Stretch=�6�   $��Stretch=�6�   $��3��6�   $��0,0,10,0q�6�   $��Disabled=�6  $��Visible=�6*  .��5,      �� -   5        $ 
itemsStack��5,      #���  6-   $
��4504��6U   $
��Left=�6�   $ 
Horizontal=�6�   .+�5-        -   5        $ addBut��5-   !   $��
color node��61   $��Center=�6F   $��Center=�6h   $
��Left=�6�   $	��100��6�   $��10��6�   $��17.333(�6�   $	��103��6�   
����������	#FF86E0FF6    5.      -   5        $ 
addTextBut��5.   !   $��	text node��65   $��Center=�6I   $��Center=�6k   $
��Left=�6�   $	��100��6�   $��10��6�   $��17.333(�6�   $	��103��6�   
����������	#FF86E0FF6  5/      50      �� 51   
   -   5        $ scrollLabel��51      $��scroll��6%   $
��Left=�66   $	��Top=�6Q   $��	10,10,0,0q�6i   $��1��6|   
�������$��26��6�   $��38��6�   52      53      
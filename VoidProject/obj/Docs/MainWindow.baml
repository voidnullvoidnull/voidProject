   M S B A M L   `   `   `  ���� F  BVoidProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:VoidNullVoidNull  5clr-namespace:VoidNull.ControlsVoidNull.Controls      VoidNull.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:VoidNull     4Controlsclr-namespace:VoidNull.Controls       � Title$  
MainWindow��$
��1080��$
��1920�� � UseLayoutRounding .  � WindowState$ 	Maximized=� � WindowStartupLocation$ CenterOwner=�.���  � RowDefinitions �� $	��40* �$��40��$��40���� $
��917* �$	��154���� $��6* �$��5��$��5���� $
��100* �$	��100��$	��100�� � ColumnDefinitions �� $��1685* �$	��180���� $��6* �$��5���� $
��200* �$	��200��$	��200��.+��� -    ��Name$ topMenu��$��3��   tollbarColor#���    �� Orientation$ 
Horizontal=�.+�7  1System.Windows.Controls.Primitives.CalendarButton  -     Name$ saveBut��$
��save��$��Center=�$��Center=�$
��Left=�$	��100��$��10��$��80��$��17.333(�  -   $ openBut��$
��open��$��Center=�$��Center=�$
��Left=�$	��100��$��10��$��80��$��17.333(��� -   	 ��Name$	 
editorView��$��1��
 � IsSharedSizeScope
 .  �� PanningMode$
 Both=� �� PanningDeceleration$	 0.1Q�$��Stretch=�$��Stretch=�$��Hidden=�$��Hidden=�.���� -    ��Name$ canvas��$
��4995��$
��5000��|�.   EarlGray#���   � ContextMenu �� -    ��Name$ canvasContextMenu��.@�m� $��add node�� m� Command$ ApplicationCommands.New���� m� $
��open��$ ApplicationCommands.Open��m� $��clear��$  ApplicationCommands.Delete���� -   $	 InspectorView��$��2��$��1�� �� PanningRatio$ 2Q�$��Stretch=�$��Stretch=� J� IsManipulationEnabled . $ VerticalFirst=�.���� -   $ inspectorStack��$
��2000��#���  |�.  �� CanVerticallyScroll .  �� CanHorizontallyScroll .  .  .+��� -	    ��Name$ selectedName��$��selected��$��21.333(�$��Disabled=�
����������	#33FFFFFF$��
10,10,10,6q�$��10,0,0,0q�$��40��$��Center=��� -
   $	 	itemsView��$��3��$
 Both=� . $ 0.0005Q�$ 2Q�$��Stretch=�$��Stretch=�$��3��$��0,0,10,0q�$��Disabled=�$��Visible=�.���� -   $ 
itemsStack��#���  $
��4504��$
��Left=�$ 
Horizontal=�.+�  -   $ addBut��$��
color node��$��Center=�$��Center=�$
��Left=�$	��100��$��10��$��17.333(�$	��103��
����������	#FF86E0FF  -   $ 
addTextBut��$��	text node��$��Center=�$��Center=�$
��Left=�$	��100��$��10��$��17.333(�$	��103��
����������	#FF86E0FF�� -   $ scrollLabel��$��scroll��$
��Left=�$	��Top=�$��	10,10,0,0q�$��1��
�������$��26��$��38��
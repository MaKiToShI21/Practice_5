   M S B A M L   `   `   `  ���� G  CWpfPractice5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfPractice5WpfPractice5  #    WpfPractice5.ChangeDevicePage   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:WpfPractice5       N� Title$  ChangeDevicePage�� N� 
Background
 �����.���� $��10q�.+��� -    ��Name$ PrintInfoBox��$��Stretch=�$	��Top=�$	��200��.���� -    ��Name$ listView������ *	Devices+ �� View �� .P���  �� Width$	 120�� �� DisplayMemberBinding ��  �� Path$
 Type�.��тип устройства�� $	 100�� �� $
 Firm�.��
Фирма�� $	 100�� �� $ Model�.��Модель�� $	 100�� �� $ Price�.��
Цена�� $	 100�� �� $ Memory�.��Память�� $	 120�� �� $ NumOfCameras�.��!Количество камер��  �� Orientation$ 
Horizontal=�.+��� -   	 ��Name$	 
BackButton��$��
Назад�����#3498D8$
��Left=�$	��100��$��0, 10, 0, 0q��� -   $	 ChangeDeviceButton��$��Изменить�����#3498D8$
��Left=�$	��100��$��20, 10, 0, 0q�
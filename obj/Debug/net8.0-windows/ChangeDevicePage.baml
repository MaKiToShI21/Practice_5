   M S B A M L   `   `   `  ����G  CWpfPractice5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfPractice5WpfPractice5  5      #    WpfPractice5.ChangeDevicePage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfPractice5     5        N� Title$  ChangeDevicePage��5	       N� 
Background
 �����.��5      �� $��10q�6   .+�5   
   �� -   5         ��Name$ PrintInfoBox��5      $��Stretch=�6-   $	��Top=�6K   $	��200��6c   .��5      �� -   5         ��Name$ listView��5      ��6)   �� *	Devices+ �� View 5      �� 5      .P�5      ��  �� Width$	 120��6T    �� DisplayMemberBinding 6)   ��  �� Path$
 Type�.��6a   тип устройства6q   �� 5      $	 100��6T    6)   �� $
 Firm�.��6a   
Фирма6h   �� 5      $	 100��6U    6)   �� $ Model�.��6b   Модель6j   �� 5      $	 100��6U    6)   �� $ Price�.��6b   
Цена6h   �� 5      $	 100��6V    6)   �� $ Memory�.��6c   Память6k   �� 5      $	 120��6\    6)   �� $ NumOfCameras�.��6i   !Количество камер6{   5      5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        	 ��Name$	 
BackButton��5      $��
Назад��6)   ���#3498D8$
��Left=�6`   $	��100��6{   $��0, 10, 0, 0q�6�   �� 5      -   5        $	 ChangeDeviceButton��5      $��Изменить��61   ���#3498D8$
��Left=�6s   $	��100��6�   $��20, 10, 0, 0q�6�   5      5       5!      
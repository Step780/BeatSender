   M S B A M L   `   `   `  ����E  ABeatSender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BeatSender
BeatSender  5          BeatSender.Sender   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $localclr-namespace:BeatSender  5        N� Title$  Sender��5
      $
��1080��5      $
��1920��5      .��5      � 
�������.+�5   
   �� -   5         ��Name$ 	mailTheme��5      $
��Left=�6%   $��49��6@   $��587,228,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��728��6�   $��0q�6�   ���#90CAF9 !  MaterialDesignOutlinedTextBox#���   6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Тема письма��6     
Background �#90CAF96/  �� 5   
   -   5        $ mailText��5      $
��Left=�6$   $	��328��6?   $��530,320,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��845��6�    �� AcceptsReturn .  �� 
AcceptsTab . $��0q�6�   ���#90CAF9#���   6�   $ Текст письма��6)   �#90CAF96W  �� 5   
   -   5        $��Импорт��5      $
��Left=�6"   $��1342,130,0,0q�6=   $	��Top=�6S   $	��106��6k   $��38��6�     MaterialDesignRaisedButton#���  6�   ���#1E88E5$��0q�6�   �� 5   
   -   5        $ mailBox��5      $
��Left=�6#   $��50��6>   $��	30,74,0,0q�6J   $
 Wrap=�6]   $	��400��6q    . $��15(�6�   $�� ��6�   $	��Top=�6�   $	��200��6�   $��0q�6�   ���#90CAF9#���   6�      
HelperText$ 
Почта��60  G� 5   
   -   5         G�Name$ passwordBox��5      $
��Left=�6+   $	��400��6F   $��15(�6U   $��52��6c   $��
30,157,0,0q�6o   $	��Top=�6�   $	��200��6�    % !MaterialDesignOutlinedPasswordBox#���  6�   $��0q�6�   ���#90CAF9$ Пароль��6  �� 5   
   -   5        	 ��Name$	 btnSend��5      $��Отправить��6"   $
��Left=�66   $��1184,752,0,0q�6Q   $	��Top=�6g   $	��166��6   $��60��6�   #���  6�   ���#1E88E5$��0q�6�   �� 5   
   -   5        $	 btnFile��5      $#��Прикрепить файл��6"   $
��Left=�6<   $��568,752,0,0q�6W   $	��Top=�6l   $	��166��6�   $��60��6�   #���  6�   ���#1E88E5$��0q�6�   �� 5   
   -   5        $ allMails��5      $
��Left=�6$   $��72��6?   $��
587,96,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��728��6�   "
 �� VerticalScrollBarVisibility$

 Auto=�6�   $��0q�6�   ���#90CAF9#���   6�   $ 
Почты��6#  &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ 	filesGrid��5      $
��Left=�6&   $	��198��6A   $��100,320,0,0q�6N   $	��Top=�6c   $	��273��6{      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$! Название файла��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� $	 Delete��6%   -
   5        $��Удалить��5   5   ���#CED4DA���#CED4DA
���   �6�   5      5!      5#      5$      5%      
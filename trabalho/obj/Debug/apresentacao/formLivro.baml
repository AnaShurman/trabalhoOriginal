   M S B A M L   `   `   `  ����C  ?trabalho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:trabalho.apresentacaotrabalho.apresentacao  5   	   %    trabalho.apresentacao.formLivro   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:trabalho.apresentacao     5   	     � Title$  	formLivro��5   	   $	��400��5	      $	��700��6    � WindowStartupLocation$ CenterScreen=�6   .��5
      � $��10,6,0,5q�6    � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $	��500 �6   6-   �� 5      $��1* �6   6,    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��1* �6   6*   �� 5      $��50 �6   6*   .+�5   
   �� -   5         ��Name$
 logo��5      $	��Top=�6   $��81��66   $��../imagens/logo.png��6B   $��-29,-11,480,0q�6�   $��2��6�   $��2��6�    J� OpacityMask 5      �� 5       �� ImageSource$ ../imagens/logo.png��6   5      	� 5   
   -   5        $��16/07/2021,Terça, 14:50��5      $��1��68   $
��Left=�6H   $��110,74.6,0,0q�6c   $��1��6y   $	��Top=�6�   6�   	� 5   
   $��20/08/2021-10:00��6   $��1��61   $
��Left=�6A   $��110,94.6,0,0q�6\   $��1��6r   $	��Top=�6    d� IsThreeState . 6�   	� 5   
   $��01/09/2021- 18:00��6   $��1��62   $
��Left=�6B   $��110,114.6,0,0q�6]   $��1��6t   $	��Top=�6�   	� 5    
   $��Shopping Dom Pedro��6   $��1��63   $
��Left=�6C   $��268,116.6,0,0q�6^   $��1��6u   $	��Top=�6�   	� 5!   
   $��Biblioteca Municipal��6   $��1��65   $
��Left=�6E   $��268,96.6,0,0q�6`   $��1��6v   $	��Top=�6�   	� 5"   
   $��Shopping de Hortolândia��6   $��1��68   $
��Left=�6H   $��268,73.6,0,0q�6c   $��1��6y   $	��Top=�6�   �� 5$   
   -   5         ��Name$ 
btn_enviar��5$      $��Enviar solicitação��6%   $��1��6B   $
��Left=�6R   $��22��6m   $��303,212.6,0,0q�6y   $��1��6�   $	��Top=�6�   $��97��6�   6�   �� 5%   
   -   5        $ btn_cancelar��5%      $��Cancelar��6'   $��1��6:   $
��Left=�6J   $��22��6e   $��411,212.6,0,0q�6q   $��1��6�   $	��Top=�6�   $��79��6�   6�   �� 5&   
   $��Datas disponiveis��6   $��1��6,   $
��Left=�6<   $��99,40.6,0,0q�6W   $��1��6l   $	��Top=�6y   $	��146��6�   $
��Bold"�6�   $��16(�6�   �� 5'   
   $��Lugares disponiveis��6   $��1��6.   $
��Left=�6>   $��268,39.6,0,0q�6Y   $��1��6o   $	��Top=�6|   $	��162��6�   $
��Bold"�6�   $��16(�6�   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   z�5(      V� 5)      .~�5*      �� �� 5+      �� 5,      
 �� Angle$
 -0.657Q�6&   T� 5-      5.      50      52      53      
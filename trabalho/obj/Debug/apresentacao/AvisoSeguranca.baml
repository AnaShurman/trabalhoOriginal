   M S B A M L   `   `   `  ����C  ?trabalho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:trabalho.apresentacaotrabalho.apresentacao  5   	   *    $trabalho.apresentacao.AvisoSeguranca   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:trabalho.apresentacao     5   	     � Title$  Aviso��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��400��6=   $	��700��6J   
�������.��5	      � $��10,6,0,5q�6    � ColumnDefinitions 5
   
   �� 5      $	��92* �6   6-   �� 5      $	��500 �6   6-   �� 5      $	��85* �6   6-   �� 5      $��7* �6    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��1* �6   6*   �� 5      $��50 �6   6*   .+�5   
   �� -   5         ��Name$
 logo��5      $	��Top=�6   $��81��66   $��../imagens/logo.png��6B   $��-29,-11,480,0q�6�   $��2��6�   $��2��6�    J� OpacityMask 5      �� 5       �� ImageSource$ ../imagens/logo.png��6   5      �� 5   
   $����Eu estou ciente sobre todas as instruções de segurança e tomo total responsabilidade 
por possiveis acidentes e imprevistos relacionados a entrega do livro.��6   $
��Left=�6�   $��4,191.6,0,0q�6�   $��1��6�   $	��Top=�6   $��35��6  $	��490��6$  $��1��60  �� 5   
   -   5         ��Name$ btn_finalizar��5      $��	Finalizar��6(   $��1��6<   $
��Left=�6L   $��395,229.6,0,0q�6g   $��1��6~   $	��Top=�6�   $��75��6�   6�   �� 5   
   $��1��6   $
��Left=�6    $	��100��6;   $��374,62.6,0,0q�6H   $��1��6^   $	��Top=�6k   $	��130��6�   $ ��../imagens/logogrande2.png��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��2��6�   	 �� StretchDirection$	 DownOnly=�6�   z�5      V� 5       .~�5!      �� 
 �� ScaleX$
 -1Q�6%   �� 5"      �� 5#      T� 5$      5%      5'      �� 5(   
   $��Dicas de segurança:��6   $��1��6.   $
��Left=�6>   $��	20,20,0,0q�6Y   $	��Top=�6l   $	��248��6�   $
��Bold"�6�   $��16(�6�   $��Sitka Heading)�6�   �� 5)   
   $����-Compartilhe sua localização com algum conhecido;
-Sempre diga para alguém de sua confiança onde você esta indo;
- Marque sempre em lugares seguros e com uma boa
 circulação de pessoas;��6   $��1��6�   $
��Left=�6�   $��10,24.6,0,0q�6  $��1��6/  $	��Top=�6<  $	��368��6T  $��97��6`  5*      5+      
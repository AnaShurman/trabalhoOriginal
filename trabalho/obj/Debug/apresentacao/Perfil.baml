   M S B A M L   `   `   `  ����C  ?trabalho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:trabalho.apresentacaotrabalho.apresentacao  5   	   "    trabalho.apresentacao.Perfil   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:trabalho.apresentacao     5   	     � Title$  Perfil��5   	   $	��680��6   $
��1370��6%    � WindowState$ 	Maximized=�62    J� OpacityMask
 �   ���5	      �� 5
   
    �� ImageSource$1 +/trabalho;component/imagens/background1.jpg��6   .��5      � $��10,6,0,5q�6    � RowDefinitions 5   
   �� 5      $	��97* �6   �� 5      $
��489* �6   �� 5      $	��54* �6    � ColumnDefinitions 5   
   �� 5      $
��186* �6   �� 5      $
��Auto �6   $	��880��6,   �� 5      $
��287* �6   .+�5   
   �� $��Center=�6   $	��485��61   
���   �$	��Top=�6M   $	��666��6e   ���	#FF1A1A1A �� RadiusX$ 8��6�    �� RadiusY$ 8��6�    J� Opacity$
 0.37Q�6�   $��1��6�   $��1��6�   $��110.8,0.2,111.2,0q�6�   �� 5   
   -   5        	 ��Name$	 lblLivrosLidos��5      $��Livros lidos:��6(   $��1��6@   $
��Left=�6P   $��224.8,73.2,0,0q�6k   $��1��6�   $	��Top=�6�   $��38��6�   $	��146��6�   
�������$
��Bold"�6�   $��22(�6�   �� 5   
   -   5        
 ��Name$
 btn_Meus_Livros��5      $��Meus livros��6*   $��1��6@   $
��Left=�6P   $��580.8,58.2,0,0q�6k   $��1��6�   $	��Top=�6�   $	��181��6�    J� RenderTransformOrigin$ 
0.494,2.85&�6�   $��50��6�   $��20(�6�   6�   �� 5    
   -   5        $
 btn_Cadastrar_Livro��5       $��Cadastrar livro��6.   $��1��6H   $
��Left=�6X   $��580.8,118.2,0,0q�6s   $��1��6�   $	��Top=�6�   $	��181��6�   $��50��6�   $��20(�6�   6�   �� 5!   
   -   5        $
 btn_add_livro_lido��5!      $��Adicionar livro lido��6-   $��1��6L   $
��Left=�6\   $��323.8,175.4,0,-153.8q�6w   $��2��6�   $	��Top=�6�   $	��146��6�   6�   �� 5"   
   -   5         ��Name$ lbLivros��5"   +   $��1��6=   $
��Left=�6M   $	��243��6h   $��224.8,141.2,0,0q�6u   $��1��6�   $	��Top=�6�   $	��146��6�   
����������	#FFFDFDFD6�   �� 5#   
   -   5         ��Name$ txtPageTotal��5#      $��1��6F   $
��Left=�6V   $��28��6q   $��407.8,141.2,0,0q�6}   $��1��6�    �� TextWrapping$
 Wrap=�6�   $��TextBox��6�   $	��Top=�6�   $	��116��6�   
�������6�   �� 5$   
   $��Páginas��6   $��1��6"   $
��Left=�62   $��407.8,72.2,0,0q�6M   $��1��6e   $	��Top=�6r   $	��116��6�   
�������$
��Bold"�6�   $��22(�6�   $��37��6�   o� 5%   
   -   5         o�Name$
 menu��5%      $
��Left=�6   $	��132��6N   $
 0.85Q�6Z   $��55,90.2,0,112.6q�6i   $��1��6�   $��0q�6�   $��2��6�   ��68   Z� .@�5&      m� 
�������$
��Bold"�6@   $��27(�6R   $��
Simplicity)�6`   $��
Meu Perfil��6x   $	��147��6�   $��37��6�   $��
16,0,-80,0q�6�   ��6   Z� 6�   m� 5'      $��
Categorias��6   
�������$	��153��6V   $��
Simplicity)�6b   $��27(�6z   $
��Bold"�6�   $��31��6�   $��
16,0,-86,0q�6�   $��0,32,0,0q�6�   $��0q�6�   ��6,   Z� .@�5)      m� -   5         m�Name$ Romance��5)      $��Romance��6,   ���	#FF323232���	#FFFFF6F66k   m� 5*      -	   5        $ Mangas��5*      $��Mangás��6+   ���	#FF323232
�������6e   m� 5+      -
   5        $ Misterio��5+      $��Misterio��6-   ���	#FF323232
�������6i   m� 5,      -   5        $ Terror��5,      $��Terror��6+   ���	#FF323232
�������6e   5-      5.      �� 5/   
   $,��&/trabalho;component/imagens/perfil.png��6   $��1��6@   $	��Top=�6M   $
��Left=�6e   $��75��6�   $��72��6�   $��
0,72.2,0,0q�6�   �� 50   
   $
��Left=�6   $��55��6+   $��8,152.2,0,0q�67   $��1��6L   $	��Top=�6Y   $��79��6q   $/��)/trabalho;component/imagens/categoria.png��6|   $ -0.532,0.52&�6�   52      53      
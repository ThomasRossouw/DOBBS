   M S B A M L   `   `   `  ����>  :POE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:POEPOE  5   	       POE.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:POE     5   	     � Title$  	Home Page��5   	   $	��800��6   $��1394.4��6(   .��5	      � -   5         �Name$ 	Home_Page��5	       J� RenderTransformOrigin$ 0.5,0.48&�6   $��0,-25,-91.4,-106.6q�6?    � RowDefinitions 5
   
   �� 5      $
��181* �6   �� 5      $	��11* �6   �� 5      $	��87* �6   �� 5      $
��350* �6   �� 5      $��9* �6   �� 5      $	��49* �6   �� 5      $��0* �6   �� 5      $
��215* �6   ��5   
   �� 5       �� ImageSource$ PictureOne.jpg��6   .+�5   
   �� -   5         ��Name$ lbl_heading��5      $7��1Welcome to DOBBS your Digital Financial Friend :D��6%   $
��Left=�6a   $��
121,18,0,0q�6|   $	��Top=�6�   $��86��6�   $
��1113��6�   $��48(�6�   
�������6�   �� 5   
   -   5        $ 
lbl_Income��5      $��Gross Monthly Income:��6$   $
��Left=�6D   $��6,25,0,0q�6_   $	��Top=�6q   $	��255��6�   $��24(�6�   
�������$��2��6�   $��42��6�   �� 5   
   -   5        $ lbl_Tax��5      $(��" Estimated Monthly Tax Deductions:��6!   $
��Left=�6N   $��1,73,0,0q�6i   $	��Top=�6{   $��24(�6�   $	��388��6�   ���	#FFFCFCFC$��2��6�   $��2��6�   $��42��6�   �� 5   
   -   5        $ lbl_Grocery��5      $��Grocery spending amount:��6%   $
��Left=�6H   $��
6,32.8,0,0q�6c   $	��Top=�6w   $��24(�6�   $	��295��6�   
�������$��3��6�   $��42��6�   �� 5    
   -   5        $ 	lbl_Water��5       $(��" Water and Lights spending amount:��6#   $
��Left=�6P   $��
2,80.8,0,0q�6k   $	��Top=�6   $��24(�6�   $	��404��6�   
�������$��3��6�   $��42��6�   �� 5!   
   -   5        $ lbl_Cell��5!      $2��, Cellphone and/or Telephone spending amount:��6"   $
��Left=�6Y   $��1,133.8,0,0q�6t   $	��Top=�6�   $��24(�6�   $	��519��6�   
�������$��3��6�   $��42��6�   �� 5"   
   -   5        $ 
lbl_Travel��5"      $�� Travel spending amount:��6$   $
��Left=�6G   $��1,183.8,0,0q�6b   $	��Top=�6w   $ 0.221,-0.391&�6�   $��24(�6�   $	��279��6�   
�������$��3��6�   $��42��6�   �� 5#   
   -	   5        $ 	lbl_Other��5#      $3��- Any other spending amounts not listed above:��6#   $
��Left=�6[   $��2,232.8,0,0q�6v   $	��Top=�6�   $��24(�6�   $	��518��6�   
�������$��3��6�   $��42��6�   �� 5$   
   -
   5        $ lbl_Main��5$      $$��Please Enter the Following in:��6"   $
��Left=�6K   $��262,104,0,0q�6f   $	��Top=�6{   $	��502��6�   $��36(�6�   $��63��6�   
�������6�   �� 5(   
   -   5         ��Name$ 	btn_Clear��5(      $��CLEAR��6$   $
��Left=�64   $��164,333.8,0,0q�6O   $	��Top=�6f   $	��137��6~   $��30(�6�   $��63��6�   $��3��6�   $��3��6�   �� 5)   
   -   5        $ btn_Proceed��5)      $��PROCEED��6&   $
��Left=�68   $��1075,5.6,0,0q�6S   $	��Top=�6i   $	��153��6�   $��30(�6�   $��63��6�   $ -0.829,-0.034&�6�   $��7��6�   �� 5*   
   -   5        $ 
btn_Submit��5*      $��SUBMIT��6%   $
��Left=�66   $��625,333.8,0,0q�6Q   $��3��6h   $	��Top=�6u   $	��153��6�   $��63��6�   $��3��6�   $��30(�6�   6�   �� 5.   
   -   5         ��Name$ 
txt_Income��5.      $
��Left=�6&   $��23��6A   $��
568,37,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��280��6�   $��2��6�   6�   �� 5/   
   -   5        $ txt_Tax��5/      $
��Left=�6#   $��23��6>   $��
568,85,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��280��6�   $��2��6�   $��2��6�   6�   �� 50   
   -   5        $ txt_Cell��50      $
��Left=�6$   $��23��6?   $��568,144.8,0,0q�6K   $
 Wrap=�6b   $	��Top=�6v   $	��280��6�   $��3��6�   6�   �� 51   
   -   5        $ txt_Grocery��51      $
��Left=�6'   $��23��6B   $��568,45.8,0,0q�6N   $
 Wrap=�6d   $	��Top=�6x   $	��280��6�   $��3��6�   6�   �� 52   
   -   5        $ 	txt_Water��52      $
��Left=�6%   $��23��6@   $��568,92.8,0,0q�6L   $
 Wrap=�6b   $	��Top=�6v   $	��280��6�   $��3��6�   6�   �� 53   
   -   5        $ 
txt_Travel��53      $
��Left=�6&   $��23��6A   $��568,193.8,0,0q�6M   $
 Wrap=�6d   $	��Top=�6x   $	��280��6�   $��3��6�   6�   �� 54   
   -   5        $ 	txt_Other��54      $
��Left=�6%   $��23��6@   $��568,244.8,0,0q�6L   $
 Wrap=�6c   $	��Top=�6w   $	��280��6�   $��3��6�   6�   �� 55   
   -   5        $ 
tb_Expense��55      $
��Left=�6&   $	��162��6A   $��996,127.8,0,0q�6N   $
 Wrap=�6e   $-��'                PLEASE DO NOT TYPE HERE��6y   $	��Top=�6�   $	��298��6�   $��3��6�   $��14(�6�   �� 56   
   -   5        $ 
tb_DeduTax��56      $
��Left=�6&   $��71��6A   $��996,0,0,287.8q�6M   $
 Wrap=�6d   $-��'                PLEASE DO NOT TYPE HERE��6x   $��Bottom=�6�   $	��298��6�   $��2��6�   $��2��6�   $��14(�6�   �� 57   
   -   5        $ tb_Dedu1��57      $
��Left=�6$   $��47��6?   $��996,175,0,0q�6K   $
 Wrap=�6`   $-��'                PLEASE DO NOT TYPE HERE��6t   $	��Top=�6�   $	��298��6�   $��3��6�   $��14(�6�   
�������6�   5=      5>      
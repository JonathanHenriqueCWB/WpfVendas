   M S B A M L   `   `   `  ����D  @WPFVendas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPFVendas.ViewsWPFVendas.Views  5   	   '    !WPFVendas.Views.frmCadastrarVenda   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WPFVendas.Views     5   	   -   5          � Title$  Cadastrar Venda��5   	   $��573.5��6!   $	��686��60    � WindowStartupLocation$ CenterScreen=�6<   $��24(�6a   $
��Bold"�6o   .��5	      � .+�5
   
   �� $��Cliente:��6   $
��Left=�6#   $��	10,10,0,0q�6>   $	��Top=�6Q   �� 5   
   -   5         ��Name$ 
txtCliente��5      $
��Left=�6&   $��41��6A   $��	10,57,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��317��6�   �� 5   
   $��Funcionário:��6   $
��Left=�6'   $��
332,10,0,0q�6B   $	��Top=�6V   �� 5   
   -   5        $ txtFuncionario��5      $
��Left=�6*   $��41��6E   $��
332,57,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��317��6�   �� 5   
   $��	Produtos:��6   $
��Left=�6$   $��
10,103,0,0q�6?   $	��Top=�6S   �� 5   
   -   5         ��Name$ cboProdutos��5      $
��Left=�6(   $��
10,150,0,0q�6C   $	��Top=�6W   $	��237��6o   6{   �� 5   
   -   5        $ txtQuantidade��5      $
��Left=�6)   $��41��6D   $��252,147,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��179��6�   �� 5   
   $��Quantidade:��6   $
��Left=�6&   $��252,103,0,0q�6A   $	��Top=�6V   �� 5   
   -   5         ��Name$ btnAdicionar��5      $��Adicionar
��6'   $
��Left=�6E   $��436,147,0,0q�6`   $	��Top=�6u   $	��213��6�   $��41��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtaProdutos��5         AutoGenerateColumns .  $
��Left=�6D   $	��164��6_   $��
10,211,0,0q�6l   $	��Top=�6�   $	��639��6�   $��18(�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Produto��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 150 66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *	Produto+  5      $	 
Quantidade��6%   $	
 150 69    6E   �� *
Quantidade+  5      $	 Preço��6%   $	
 150 64    6@   �� *Preco+ �� StringFormat$ C2��  5      $	 Subtotal��6%   $	
 150 67    6C   �� *
Subtotal+$ C2��5      �� 5   
   -   5         ��Name$ lblTotal��5      $��Total:��6"   $
��Left=�63   $��
10,380,0,0q�6N   $	��Top=�6b   $	��390��6z   
���  ��6�   �� 5   
   -	   5        $��Mostrar dados��5      $
��Left=�6)   $��418,383,0,0q�6D   $	��Top=�6Y   $	��231��6q   6}   (  "System.Windows.Controls.DatePicker  5   
   -
   5          Name$ dteData��5      $
��Left=�6&   $��
10,427,0,0q�6A   $	��Top=�6U   $	��390��6m   �� 5   
   -   5        $ cboHora��5      $
��Left=�6$   $��
10,472,0,0q�6?   $	��Top=�6S   $	��390��6k    J� RenderTransformOrigin$ 0.375,0.026&�6w   .@�5      �� $��18:00��6   $
��Left=�6+   $	��388��6F   �� 5       $��19:00��6   $
��Left=�6+   $	��388��6F   5!      �� 5"   
   -   5        $��Data e Hora��5"      $
��Left=�6'   $��418,474,0,0q�6B   $	��Top=�6W   $	��231��6o   6{   5$      5%      
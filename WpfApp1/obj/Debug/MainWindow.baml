   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency . 
������  � Title$ 
MainWindow��5   	   $
��1080��6   $
��1920��6*   .��5	      � ��5
   
   �� 5       �� ImageSource$ /images/back.jpg��6    j� Stretch$ UniformToFill=�68   .+�5   
   �� $	��740��5      $��Center=�5      $��Center=�5      $��2q�5       �� CornerRadius$ 50��5      
�������$	��600��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#   	   	Direction$		 -90Q�5   #   
   RenderingBias$
 Quality=�5   #      ShadowDepth$ 2Q�5   #      Color$ Black��5   #   ._�5      �� $	��Top=�6   $��Center=�61   $	��740��6N   $	��600��6Z   .+�5      �� $-��'/images/university-of-kelaniya-logo.png��6    J� RenderTransformOrigin$ 0.593,0.243&�5       $	��165��5!      $	��134��6%   �� 5#      $��Student Attendence System��5$         	titleText#��[  5%      $	��530��5&      $ 0.5,0.5&�5'      $��62��5(       �� TextAlignment$
 Left=�5)      �� 5+      $��1q�6   
���   �$��70,30q�6A   $ 25��6P   $��66��6b   ._�5,      � $	��7,9q�6    � ColumnDefinitions 5-      �� 5.      $
��auto �6/   �� 5/      $��* �6/   .+�51      �� -   5         ��Name$ textUser��51   $   $��UserName��66     textHint#��[ 6F   $��2��6h   $��	23,3,23,7q�6|   �� 52      -   5         ��Name$ txtUser��52   "     textBox#��[ 63   54      56      �� 58      $��1q�6   
���   �$
��70,0q�6A   $ 25��6O   $��66��6a   ._�59      � $	��7,9q�6    5:      �� 5;      $
��auto �6/   �� 5<      $��* �6/   .+�5>      �� -   5        $ textPassword��5>   $   $��Password��6:   #��[ 6J   $��2��6l   $��	23,3,23,7q�6�   G� 5?      -   5         G�Name$ txtPassword��5?   &   #��[ 6;   5A      5C      �� 5F      -   5        $��Sign Up��5G       
 Button#��[ 5I      $��85��5J      $	��614��5K      5L      5P      5R      5S      
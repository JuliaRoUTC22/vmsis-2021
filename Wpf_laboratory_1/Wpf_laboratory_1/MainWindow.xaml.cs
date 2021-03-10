using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_laboratory_1
{



        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
                tbr1.Text = "";
                tbr2.Text = "";
            }

            private void from_21_to_10_Click(object sender, RoutedEventArgs e)
            {
            try 
            { 
                if (tb1.Text.Contains("."))
                {
                    tb1.Text = tb1.Text.Replace(".", ",");
                }

                int radix = 21;

                int Case = 0;

                int integer = 0;
                double fraction = 0;

                string user_entered = tb1.Text;

                char[] entered_number = user_entered.ToCharArray();


                int comma = 0;
                for (int i = 0; i < entered_number.Length; i++)
                {
                    if (Convert.ToString(entered_number[i]) == ",")
                    {
                    comma = i;
                    }
                }


                List<int> Numbers_int = new List<int>();
                List<int> Numbers_fraction = new List<int>();


                if (comma != 0)
                {
                    for (int i = 0; i < comma; i++)
                    {
                        Case = 0;
                        if (Convert.ToString(entered_number[i]) == "A")
                        {
                        Case = 1;
                        }
                        if (Convert.ToString(entered_number[i]) == "B")
                        {
                        Case = 2;
                        }
                        if (Convert.ToString(entered_number[i]) == "C")
                        {
                        Case = 3;
                        }
                        if (Convert.ToString(entered_number[i]) == "D")
                        {
                        Case = 4;
                        }
                        if (Convert.ToString(entered_number[i]) == "E")
                        {
                        Case = 5;
                        }
                        if (Convert.ToString(entered_number[i]) == "F")
                        {
                        Case = 6;
                        }
                        if (Convert.ToString(entered_number[i]) == "G")
                        {
                        Case = 7;
                        }
                        if (Convert.ToString(entered_number[i]) == "H")
                        {
                        Case = 8;
                        }
                        if (Convert.ToString(entered_number[i]) == "I")
                        {
                        Case = 9;
                        }
                        if (Convert.ToString(entered_number[i]) == "J")
                        {
                        Case = 10;
                        }
                        if (Convert.ToString(entered_number[i]) == "K")
                        {
                        Case = 11;
                        }

                       switch (Case)
                       {
                        case 1:
                            Numbers_int.Add(10);
                            break;
                        case 2:
                            Numbers_int.Add(11);
                            break;
                        case 3:
                            Numbers_int.Add(12);
                            break;
                        case 4:
                            Numbers_int.Add(13);
                            break;
                        case 5:
                            Numbers_int.Add(14);
                            break;
                        case 6:
                            Numbers_int.Add(15);
                            break;
                        case 7:
                            Numbers_int.Add(16);
                            break;
                        case 8:
                            Numbers_int.Add(17);
                            break;
                        case 9:
                            Numbers_int.Add(18);
                            break;
                        case 10:
                            Numbers_int.Add(19);
                            break;
                        case 11:
                            Numbers_int.Add(20);
                            break;

                        default:
                                Numbers_int.Add(Convert.ToInt32(Convert.ToString(entered_number[i])));
                                break;
                       }
                    }

                    for (int i = comma + 1; i < entered_number.Length; i++)
                    {
                    Case = 0;
                        if (Convert.ToString(entered_number[i]) == "A")
                        {
                        Case = 1;
                        }
                        if (Convert.ToString(entered_number[i]) == "B")
                        {
                        Case = 2;
                        }
                        if (Convert.ToString(entered_number[i]) == "C")
                        {
                        Case = 3;
                        }
                        if (Convert.ToString(entered_number[i]) == "D")
                        {
                        Case = 4;
                        }
                        if (Convert.ToString(entered_number[i]) == "E")
                        {
                        Case = 5;
                        }
                        if (Convert.ToString(entered_number[i]) == "F")
                        {
                        Case = 6;
                        }
                        if (Convert.ToString(entered_number[i]) == "G")
                        {
                        Case = 7;
                        }
                        if (Convert.ToString(entered_number[i]) == "H")
                        {
                        Case = 8;
                        }
                        if (Convert.ToString(entered_number[i]) == "I")
                        {
                        Case = 9;
                        }
                        if (Convert.ToString(entered_number[i]) == "J")
                        {
                        Case = 10;
                        }
                        if (Convert.ToString(entered_number[i]) == "K")
                        {
                        Case = 11;
                        }

                        switch (Case)
                        {
                            case 1:
                                Numbers_fraction.Add(10);
                                break;
                            case 2:
                                Numbers_fraction.Add(11);
                                break;
                            case 3:
                                Numbers_fraction.Add(12);
                                break;
                            case 4:
                                Numbers_fraction.Add(13);
                                break;
                            case 5:
                                Numbers_fraction.Add(14);
                                break;
                            case 6:
                                Numbers_fraction.Add(15);
                                break;
                            case 7:
                                Numbers_fraction.Add(16);
                                break;
                            case 8:
                                Numbers_fraction.Add(17);
                                break;
                            case 9:
                                Numbers_fraction.Add(18);
                                break;
                            case 10:
                                Numbers_fraction.Add(19);
                                break;
                            case 11:
                                Numbers_fraction.Add(20);
                                break;
                            default:
                                Numbers_fraction.Add(Convert.ToInt32(Convert.ToString(entered_number[i])));
                                break;
                        }

                    }

                    for (int i = 0; i < Numbers_int.Count; i++)
                    {

                        int a = Numbers_int[i] * Convert.ToInt32(Math.Pow(radix, Numbers_int.Count - 1 - i));
                        integer = integer + a;
                    }


                    for (int i = 0; i < Numbers_fraction.Count; i++)
                    {
                        double b = Numbers_fraction[i] * (Math.Pow(radix, -i - 1));
                       fraction = fraction + b;
                    }
                }
                else
                {

                    for (int i = 0; i < entered_number.Length; i++)
                    {

                    Case = 0;
                        if (Convert.ToString(entered_number[i]) == "A")
                        {
                        Case = 1;

                        }
                        if (Convert.ToString(entered_number[i]) == "B")
                        {
                        Case = 2;
                        }
                        if (Convert.ToString(entered_number[i]) == "C")
                        {
                        Case = 3;
                        }
                        if (Convert.ToString(entered_number[i]) == "D")
                        {
                        Case = 4;
                        }
                        if (Convert.ToString(entered_number[i]) == "E")
                        {
                        Case = 5;
                        }
                        if (Convert.ToString(entered_number[i]) == "F")
                        {
                        Case = 6;
                        }
                        if (Convert.ToString(entered_number[i]) == "G")
                        {
                        Case = 7;
                        }
                        if (Convert.ToString(entered_number[i]) == "H")
                        {
                        Case = 8;
                        }
                        if (Convert.ToString(entered_number[i]) == "I")
                        {
                        Case = 9;
                        }
                        if (Convert.ToString(entered_number[i]) == "J")
                        {
                        Case = 10;
                        }
                        if (Convert.ToString(entered_number[i]) == "K")
                        {
                        Case = 11;
                        }

                        switch (Case)
                        {
                            case 1:
                                Numbers_int.Add(10);
                                break;
                            case 2:
                                Numbers_int.Add(11);
                                break;
                            case 3:
                                Numbers_int.Add(12);
                                break;
                            case 4:
                                Numbers_int.Add(13);
                                break;
                            case 5:
                                Numbers_int.Add(14);
                                break;
                            case 6:
                                Numbers_int.Add(15);
                                break;
                            case 7:
                                Numbers_int.Add(16);
                                break;
                            case 8:
                                Numbers_int.Add(17);
                                break;
                            case 9:
                                Numbers_int.Add(18);
                                break;
                            case 10:
                                Numbers_int.Add(19);
                                break;
                            case 11:
                                Numbers_int.Add(20);
                                break;

                            default:
                                Numbers_int.Add(Convert.ToInt32(Convert.ToString(entered_number[i])));
                                break;
                        }

                    }

                    for (int i = 0; i < Numbers_int.Count; i++)
                    {

                        int a = Numbers_int[i] * Convert.ToInt32(Math.Pow(radix, Numbers_int.Count - 1 - i));
                        integer = integer + a;
                    }

                }
              double final_number = integer + fraction;
                tbr1.Text = Convert.ToString(final_number);
            }

            catch (Exception)
            {
                MessageBox.Show("Неверный формат числа. Двадцатиодноричное число может содержать только цифры 0-9, буквы A-K, а также точку для дробных чисел.");
                tb1.Text = Convert.ToString(0);
                return;
            }
        }


        private void from_10_to_21_Click(object sender, RoutedEventArgs e)
        {
            tbr2.Text = "";

            int radix1 = 21;
            if (tb2.Text.Contains("."))
            {
                tb2.Text = tb2.Text.Replace(".", ",");
            }


            string enter_number1 = tb2.Text;
            try
            {
                double Number = Math.Truncate(double.Parse(enter_number1));


                int Number_integer = Convert.ToInt32(Number);
        
            double Number_fract = double.Parse(enter_number1) - Math.Truncate(double.Parse(enter_number1));


                char[] UseNumbers1 = enter_number1.ToCharArray();


                int comma1 = 0;
                for (int i = 0; i < UseNumbers1.Length; i++)
                {
                    if (Convert.ToString(UseNumbers1[i]) == ",")
                    {
                    comma1 = i;
                    }
                }
                List<string> Int_abs = new List<string>();
                List<string> Fract_abs = new List<string>();
                int remainder;

                while (Number_integer > radix1)
                {

                remainder = Number_integer % radix1;
                Int_abs.Add(Convert.ToString(remainder));
                    Number_integer = Number_integer / radix1;
                }
                if (Number_integer < radix1)
                {
                Int_abs.Add(Convert.ToString(Number_integer));
                }

            Int_abs.Reverse();

                for (int i = 0; i < Int_abs.Count; i++)
                {
                    if (Int_abs[i] == "10")
                    {
                    Int_abs[i] = "A";
                    }
                    if (Int_abs[i] == "11")
                    {
                    Int_abs[i] = "B";
                    }
                    if (Int_abs[i] == "12")
                    {
                    Int_abs[i] = "C";
                    }
                    if (Int_abs[i] == "13")
                    {
                    Int_abs[i] = "D";
                    }
                    if (Int_abs[i] == "14")
                    {
                    Int_abs[i] = "E";
                    }
                    if (Int_abs[i] == "15")
                    {
                    Int_abs[i] = "F";
                    }
                    if (Int_abs[i] == "16")
                    {
                    Int_abs[i] = "G";
                    }
                    if (Int_abs[i] == "17")
                    {
                    Int_abs[i] = "H";
                    }
                    if (Int_abs[i] == "18")
                    {
                    Int_abs[i] = "I";
                    }
                    if (Int_abs[i] == "19")
                    {
                    Int_abs[i] = "J";
                    }
                    if (Int_abs[i] == "20")
                    {
                    Int_abs[i] = "K";
                    }

                    tbr2.Text = tbr2.Text + Int_abs[i];
                }
                tbr2.Text = tbr2.Text + ",";


                int remainder1;
                for (int i = 0; i < 11; i++)
                {
                    Number_fract = Number_fract * radix1;
                remainder1 = Convert.ToInt32(Math.Truncate(Number_fract));
                    Number_fract = Number_fract - Math.Truncate(Number_fract);
                    Fract_abs.Add(Convert.ToString(remainder1));
                }

                for (int i = 0; i < Fract_abs.Count; i++)
                {
                    if (Fract_abs[i] == "10")
                    {
                    Fract_abs[i] = "A";
                    }
                    if (Fract_abs[i] == "11")
                    {
                    Fract_abs[i] = "B";
                    }
                    if (Fract_abs[i] == "12")
                    {
                    Fract_abs[i] = "C";
                    }
                    if (Fract_abs[i] == "13")
                    {
                    Fract_abs[i] = "D";
                    }
                    if (Fract_abs[i] == "14")
                    {
                    Fract_abs[i] = "E";
                    }
                    if (Fract_abs[i] == "15")
                    {
                    Fract_abs[i] = "F";
                    }
                    if (Fract_abs[i] == "16")
                    {
                    Fract_abs[i] = "G";
                    }
                    if (Fract_abs[i] == "17")
                    {
                    Fract_abs[i] = "H";
                    }
                    if (Fract_abs[i] == "18")
                    {
                    Fract_abs[i] = "I";
                    }
                    if (Fract_abs[i] == "19")
                    {
                    Fract_abs[i] = "J";
                    }
                    if (Fract_abs[i] == "20")
                    {
                    Fract_abs[i] = "K";
                    }

                    tbr2.Text = tbr2.Text + Fract_abs[i];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат числа.");
                tb2.Text = Convert.ToString(0);
                return;
            }
        }

        }
    }


 /*
10=A
11=B
12=C
13=D
14=E
15=F
16=G
17=H
18=I
19=J
20=K
 */
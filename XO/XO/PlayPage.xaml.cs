using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayPage : ContentPage
    {
        public interface IClpseApplication
        {
            void closeApplication();
        }
        public PlayPage()
        {
            InitializeComponent();
            bu1.Text = "";
            bu2.Text = "";
            bu3.Text = "";
            bu4.Text = "";
            bu5.Text = "";
            bu6.Text = "";
            bu7.Text = "";
            bu8.Text = "";
            bu9.Text = "";
        }
        public string number_of_player = "";
        public PlayPage(string n)
        {
            InitializeComponent();
            number_of_player = n;
            bu1.Text = "";
            bu2.Text = "";
            bu3.Text = "";
            bu4.Text = "";
            bu5.Text = "";
            bu6.Text = "";
            bu7.Text = "";
            bu8.Text = "";
            bu9.Text = "";
        }
        public string First_player="X";
		public string Second_player="O";
        public async void start_play(Button bu)
        {
            if (bu.Text != "X" && bu.Text != "O")
            {
                bu.Text = First_player;
                if (winer() == "")
                {
                    Second_Player();
                }
            }
           if (winer() != "")
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
                await Application.Current.MainPage.Navigation.PushModalAsync(new HomePage(winer()));
            }
        }

        public int number_button;
        public int chose_boutton()
        {
            //أول لعبه
            
            //اسبقية الفوز
            if ((bu5.Text == Second_player && bu9.Text == Second_player || bu2.Text == Second_player && bu3.Text == Second_player
                || bu4.Text == Second_player && bu7.Text == Second_player)
                && (bu1.Text != "X" && bu1.Text != "O"))
                number_button = 1;

            else if ((bu8.Text == Second_player && bu5.Text == Second_player
                || bu1.Text == Second_player && bu3.Text == Second_player)
                && (bu2.Text != "X" && bu2.Text != "O"))
                number_button = 2;


            else if ((bu6.Text == Second_player && bu9.Text == Second_player || bu2.Text == Second_player && bu1.Text == Second_player
                || bu5.Text == Second_player && bu7.Text == Second_player)
                && (bu3.Text != "X" && bu3.Text != "O"))
                number_button = 3;


            else if ((bu5.Text == Second_player && bu6.Text == Second_player || bu1.Text == Second_player && bu7.Text == Second_player)
                && (bu4.Text != "X" && bu4.Text != "O"))
                number_button = 4;

            else if ((bu1.Text == Second_player && bu9.Text == Second_player || bu7.Text == Second_player && bu3.Text == Second_player
                || bu4.Text == Second_player && bu6.Text == Second_player
                || bu8.Text == Second_player && bu2.Text == Second_player)
                && (bu5.Text != "X" && bu5.Text != "O"))
                number_button = 5;


            else if ((bu5.Text == Second_player && bu4.Text == Second_player || bu9.Text == Second_player && bu3.Text == Second_player)
                && (bu6.Text != "X" && bu6.Text != "O"))
                number_button = 6;

            else if ((bu8.Text == Second_player && bu9.Text == Second_player || bu5.Text == Second_player && bu3.Text == Second_player ||
                bu4.Text == Second_player && bu1.Text == Second_player) && (bu7.Text != "X" && bu7.Text != "O"))
                number_button = 7;


            else if ((bu2.Text == Second_player && bu5.Text == Second_player || bu7.Text == Second_player && bu9.Text == Second_player)
                && (bu8.Text != "X" && bu8.Text != "O"))
                number_button = 8;

            else if ((bu1.Text == Second_player && bu5.Text == Second_player || bu7.Text == Second_player && bu8.Text == Second_player ||
                bu3.Text == Second_player && bu6.Text == Second_player) && (bu9.Text != "X" && bu9.Text != "O"))
                number_button = 9;
            // الدفاع
            else if ((bu5.Text == First_player && bu9.Text == First_player || bu2.Text == First_player && bu3.Text == First_player
                || bu4.Text == First_player && bu7.Text == First_player)
         && (bu1.Text != "X" && bu1.Text != "O"))
                number_button = 1;

            else if ((bu8.Text == First_player && bu5.Text == First_player || bu1.Text == First_player && bu3.Text == First_player)
         && (bu2.Text != "X" && bu2.Text != "O"))
                number_button = 2;


            else if ((bu6.Text == First_player && bu9.Text == First_player || bu2.Text == First_player && bu1.Text == First_player
                || bu5.Text == First_player && bu7.Text == First_player)
         && (bu3.Text != "X" && bu3.Text != "O"))
                number_button = 3;


            else if ((bu5.Text == First_player && bu6.Text == First_player || bu1.Text == First_player && bu7.Text == First_player)
         && (bu4.Text != "X" && bu4.Text != "O"))
                number_button = 4;

            else if ((bu1.Text == First_player && bu9.Text == First_player || bu7.Text == First_player && bu3.Text == First_player
                || bu4.Text == First_player && bu6.Text == First_player
                || bu8.Text == First_player && bu2.Text == First_player) && (bu5.Text != "X" && bu5.Text != "O"))
                number_button = 5;


            else if ((bu5.Text == First_player && bu4.Text == First_player || bu9.Text == First_player && bu3.Text == First_player)
         && (bu6.Text != "X" && bu6.Text != "O"))
                number_button = 6;

            else if ((bu8.Text == First_player && bu9.Text == First_player || bu5.Text == First_player && bu3.Text == First_player ||
                bu4.Text == First_player && bu1.Text == First_player) && (bu7.Text != "X" && bu7.Text != "O"))
                number_button = 7;


            else if ((bu2.Text == First_player && bu5.Text == First_player || bu7.Text == First_player && bu9.Text == First_player)
         && (bu8.Text != "X" && bu8.Text != "O"))
                number_button = 8;

            else if ((bu1.Text == First_player && bu5.Text == First_player || bu7.Text == First_player && bu8.Text == First_player ||
                bu3.Text == First_player && bu6.Text == First_player) && (bu9.Text != "X" && bu9.Text != "O"))
                number_button = 9;
            else
            // استراتيجية الفوز 
            {
                if ((bu1.Text != First_player) && (bu2.Text != First_player) && (bu3.Text != First_player))
                {
                    if (bu1.Text != Second_player)
                        number_button = 1;
                    else if (bu2.Text != Second_player)
                        number_button = 2;
                    else if (bu3.Text != Second_player)
                        number_button = 3;
                }
                else if ((bu4.Text != First_player) && (bu5.Text != First_player) && (bu6.Text != First_player))
                {
                    if (bu4.Text != Second_player)
                        number_button = 4;
                    else if (bu5.Text != Second_player)
                        number_button = 5;
                    else if (bu6.Text != Second_player)
                        number_button = 6;
                }
                else if ((bu7.Text != First_player) && (bu8.Text != First_player) && (bu9.Text != First_player))
                {
                    if (bu7.Text != Second_player)
                        number_button = 7;
                    else if (bu8.Text != Second_player)
                        number_button = 8;
                    else if (bu9.Text != Second_player)
                        number_button = 9;
                }
                else if ((bu1.Text != First_player) && (bu4.Text != First_player) && (bu7.Text != First_player))
                {
                    if (bu1.Text != Second_player)
                        number_button = 1;
                    else if (bu4.Text != Second_player)
                        number_button = 4;
                    else if (bu7.Text != Second_player)
                        number_button = 7;
                }
                else if ((bu2.Text != First_player) && (bu5.Text != First_player) && (bu8.Text != First_player))
                {
                    if (bu2.Text != Second_player)
                        number_button = 2;
                    else if (bu5.Text != Second_player)
                        number_button = 5;
                    else if (bu8.Text != Second_player)
                        number_button = 8;
                }
                else if ((bu3.Text != First_player) && (bu6.Text != First_player) && (bu9.Text != First_player))
                {
                    if (bu3.Text != Second_player)
                        number_button = 3;
                    else if (bu6.Text != Second_player)
                        number_button = 6;
                    else if (bu9.Text != Second_player)
                        number_button = 9;
                }
                else if ((bu1.Text != First_player) && (bu5.Text != First_player) && (bu9.Text != First_player))
                {
                    if (bu1.Text != Second_player)
                        number_button = 1;
                    else if (bu5.Text != Second_player)
                        number_button = 5;
                    else if (bu9.Text != Second_player)
                        number_button = 9;
                }
                else if ((bu3.Text != First_player) && (bu5.Text != First_player) && (bu7.Text != First_player))
                {
                    if (bu3.Text != Second_player)
                        number_button = 3;
                    else if (bu5.Text != Second_player)
                        number_button = 5;
                    else if (bu7.Text != Second_player)
                        number_button = 7;
                }

                else
                // العب العشوائي
                {
                    for (; ; )
                    {
                        Random rand = new Random();
                        string r = rand.Next(1, 10).ToString();
                        if (r == "1" && (bu1.Text != "X" && bu1.Text != "O"))
                        {
                            number_button = 1;
                            break;
                        }
                        else if (r == "2" && (bu2.Text != "X" && bu2.Text != "O"))
                        {
                            number_button = 2;
                            break;
                        }
                        else if (r == "3" && (bu3.Text != "X" && bu3.Text != "O"))
                        {
                            number_button = 3;
                            break;
                        }
                        else if (r == "4" && (bu4.Text != "X" && bu4.Text != "O"))
                        {
                            number_button = 4;
                            break;
                        }
                        else if (r == "5" && (bu5.Text != "X" && bu5.Text != "O"))
                        {
                            number_button = 5;
                            break;
                        }
                        else if (r == "6" && (bu6.Text != "X" && bu6.Text != "O"))
                        {
                            number_button = 6;
                            break;
                        }
                        else if (r == "7" && (bu7.Text != "X" && bu7.Text != "O"))
                        {
                            number_button = 7;
                            break;
                        }
                        else if (r == "8" && (bu8.Text != "X" && bu8.Text != "O"))
                        {
                            number_button = 8;
                            break;
                        }
                        else if (r == "9" && (bu9.Text != "X" && bu9.Text != "O"))
                        {
                            number_button = 9;
                            break;
                        }
                        // نهاية اللعبه
                        else if (((bu1.Text != First_player) || (bu1.Text == First_player)) && ((bu2.Text == "X") || (bu2.Text == "O")) && ((bu3.Text == "X") || (bu3.Text == "O"))
                            && ((bu4.Text == "X") || (bu4.Text == "O")) && ((bu5.Text == "X") || (bu5.Text == "O")) && ((bu6.Text == "X") || (bu6.Text == "O"))
                            && ((bu7.Text == "X") || (bu7.Text == "O")) && ((bu8.Text == "X") || (bu8.Text == "O")) && ((bu9.Text == "X") || (bu9.Text == "O")))
                            break;
                        else if (((bu1.Text == "X") || (bu1.Text == "O")) && ((bu2.Text != First_player) || (bu2.Text == First_player)) && ((bu3.Text == "X") || (bu3.Text == "O"))
                            && ((bu4.Text == "X") || (bu4.Text == "O")) && ((bu5.Text == "X") || (bu5.Text == "O")) && ((bu6.Text == "X") || (bu6.Text == "O"))
                            && ((bu7.Text == "X") || (bu7.Text == "O")) && ((bu8.Text == "X") || (bu8.Text == "O")) && ((bu9.Text == "X") || (bu9.Text == "O")))
                            break;
                        else if (((bu1.Text == "X") || (bu1.Text == "O")) && ((bu2.Text == "X") || (bu2.Text == "O")) && ((bu3.Text != First_player) || (bu3.Text == First_player))
                            && ((bu4.Text == "X") || (bu4.Text == "O")) && ((bu5.Text == "X") || (bu5.Text == "O")) && ((bu6.Text == "X") || (bu6.Text == "O"))
                            && ((bu7.Text == "X") || (bu7.Text == "O")) && ((bu8.Text == "X") || (bu8.Text == "O")) && ((bu9.Text == "X") || (bu9.Text == "O")))
                            break;
                        else if (((bu1.Text == "X") || (bu1.Text == "O")) && ((bu2.Text == "X") || (bu2.Text == "O")) && ((bu3.Text == "X") || (bu3.Text == "O"))
                            && ((bu4.Text != First_player) || (bu4.Text == First_player)) && ((bu5.Text == "X") || (bu5.Text == "O")) && ((bu6.Text == "X") || (bu6.Text == "O"))
                            && ((bu7.Text == "X") || (bu7.Text == "O")) && ((bu8.Text == "X") || (bu8.Text == "O")) && ((bu9.Text == "X") || (bu9.Text == "O")))
                            break;
                        else if (((bu1.Text == "X") || (bu1.Text == "O")) && ((bu2.Text == "X") || (bu2.Text == "O")) && ((bu3.Text == "X") || (bu3.Text == "O"))
                            && ((bu4.Text == "X") || (bu4.Text == "O")) && ((bu5.Text != First_player) || (bu5.Text == First_player)) && ((bu6.Text == "X") || (bu6.Text == "O"))
                            && ((bu7.Text == "X") || (bu7.Text == "O")) && ((bu8.Text == "X") || (bu8.Text == "O")) && ((bu9.Text == "X") || (bu9.Text == "O")))
                            break;
                        else if (((bu1.Text == "X") || (bu1.Text == "O")) && ((bu2.Text == "X") || (bu2.Text == "O")) && ((bu3.Text == "X") || (bu3.Text == "O"))
                            && ((bu4.Text == "X") || (bu4.Text == "O")) && ((bu5.Text == "X") || (bu5.Text == "O")) && ((bu6.Text != First_player) || (bu6.Text == First_player))
                            && ((bu7.Text == "X") || (bu7.Text == "O")) && ((bu8.Text == "X") || (bu8.Text == "O")) && ((bu9.Text == "X") || (bu9.Text == "O")))
                            break;
                        else if (((bu1.Text == "X") || (bu1.Text == "O")) && ((bu2.Text == "X") || (bu2.Text == "O")) && ((bu3.Text == "X") || (bu3.Text == "O"))
                            && ((bu4.Text == "X") || (bu4.Text == "O")) && ((bu5.Text == "X") || (bu5.Text == "O")) && ((bu6.Text == "X") || (bu6.Text == "O"))
                            && ((bu7.Text != First_player) || (bu7.Text == First_player)) && ((bu8.Text == "X") || (bu8.Text == "O")) && ((bu9.Text == "X") || (bu9.Text == "O")))
                            break;
                        else if (((bu1.Text == "X") || (bu1.Text == "O")) && ((bu2.Text == "X") || (bu2.Text == "O")) && ((bu3.Text == "X") || (bu3.Text == "O"))
                            && ((bu4.Text == "X") || (bu4.Text == "O")) && ((bu5.Text == "X") || (bu5.Text == "O")) && ((bu6.Text == "X") || (bu6.Text == "O"))
                            && ((bu7.Text == "X") || (bu7.Text == "O")) && ((bu8.Text != First_player) || (bu8.Text == First_player)) && ((bu9.Text == "X") || (bu9.Text == "O")))
                            break;
                        else if (((bu1.Text == "X") || (bu1.Text == "O")) && ((bu2.Text == "X") || (bu2.Text == "O")) && ((bu3.Text == "X") || (bu3.Text == "O"))
                            && ((bu4.Text == "X") || (bu4.Text == "O")) && ((bu5.Text == "X") || (bu5.Text == "O")) && ((bu6.Text == "X") || (bu6.Text == "O"))
                            && ((bu7.Text == "X") || (bu7.Text == "O")) && ((bu8.Text == "X") || (bu8.Text == "O")) && ((bu9.Text != First_player) || (bu9.Text == First_player)))
                            break;
                        else
                            continue;
                    }
                }
            }
            return number_button;
        }
        int ss;
        public void Second_Player()
        {
            if (chose_boutton() == 1) bu1.Text = Second_player;
            else if (chose_boutton() == 2) bu2.Text = Second_player;
            else if (chose_boutton() == 3) bu3.Text = Second_player;
            else if (chose_boutton() == 4) bu4.Text = Second_player;
            else if (chose_boutton() == 5) bu5.Text = Second_player;
            else if (chose_boutton() == 6) bu6.Text = Second_player;
            else if (chose_boutton() == 7) bu7.Text = Second_player;
            else if (chose_boutton() == 8) bu8.Text = Second_player;
            else if (chose_boutton() == 9) bu9.Text = Second_player;
        }


       
        public string play = "O";

        public string player()
        {
            if (play == "O")
                play = "X";
            else
                play = "O";
            return play;
        }

        private void Bu1_Clicked(object sender, EventArgs e)
        {
            if (number_of_player == "1")
                playing(bu1);
            else
                start_play(bu1);
        }
 

        private void Bu2_Clicked(object sender, EventArgs e)
        {
            if (number_of_player == "1")
                playing(bu2);
            else
                start_play(bu2);
         }

        private void Bu3_Clicked(object sender, EventArgs e)
        {
            if (number_of_player == "1")
                playing(bu3);
            else
                start_play(bu3);
        }

        private void Bu4_Clicked(object sender, EventArgs e)
        {
            if (number_of_player == "1")
                playing(bu4);
            else
            start_play(bu4);
        }

        private void Bu5_Clicked(object sender, EventArgs e)
        {
            if (number_of_player == "1")
                playing(bu5);
            else
                start_play(bu5);
        }

        private void Bu6_Clicked(object sender, EventArgs e)
        {
            if (number_of_player == "1")
                playing(bu6);
            else
                start_play(bu6);
        }

        private void Bu7_Clicked(object sender, EventArgs e)
        {
            if (number_of_player == "1")
                playing(bu7);
            else
                start_play(bu7);
        }

        private void Bu8_Clicked(object sender, EventArgs e)
        {
            if (number_of_player == "1")
                playing(bu8);
            else
                start_play(bu8);
        }

        private void Bu9_Clicked(object sender, EventArgs e)
        {
            if (number_of_player == "1")
                playing(bu9);
            else
                start_play(bu9);
        }

        public async void playing(Button bu)
        {
            
            if (bu.Text == ""){ bu.Text = player(); }
               
            if (winer() != "")
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
                await Application.Current.MainPage.Navigation.PushModalAsync(new HomePage(winer()));
            }
        }

        string win = "";
        string RX = "the player winer X";
        string RO = "the player winer O";
        string RN ="no winer";
        public string winer()
        {
            if ((bu1.Text == "X") && (bu2.Text == "X") && (bu3.Text == "X")) win = RX;
            else if ((bu4.Text == "X") && (bu5.Text == "X") && (bu6.Text == "X")) win = RX;
            else if ((bu7.Text == "X") && (bu8.Text == "X") && (bu9.Text == "X")) win = RX;
            else if ((bu1.Text == "X") && (bu4.Text == "X") && (bu7.Text == "X")) win = RX;
            else if ((bu2.Text == "X") && (bu5.Text == "X") && (bu8.Text == "X")) win = RX;
            else if ((bu3.Text == "X") && (bu6.Text == "X") && (bu9.Text == "X")) win = RX;
            else if ((bu1.Text == "X") && (bu5.Text == "X") && (bu9.Text == "X")) win = RX;
            else if ((bu3.Text == "X") && (bu5.Text == "X") && (bu7.Text == "X")) win = RX;
                 if ((bu1.Text == "O") && (bu2.Text == "O") && (bu3.Text == "O")) win = RO;
            else if ((bu4.Text == "O") && (bu5.Text == "O") && (bu6.Text == "O")) win = RO;
            else if ((bu7.Text == "O") && (bu8.Text == "O") && (bu9.Text == "O")) win = RO;
            else if ((bu1.Text == "O") && (bu4.Text == "O") && (bu7.Text == "O")) win = RO;
            else if ((bu2.Text == "O") && (bu5.Text == "O") && (bu8.Text == "O")) win = RO;
            else if ((bu3.Text == "O") && (bu6.Text == "O") && (bu9.Text == "O")) win = RO;
            else if ((bu1.Text == "O") && (bu5.Text == "O") && (bu9.Text == "O")) win = RO;
            else if ((bu3.Text == "O") && (bu5.Text == "O") && (bu7.Text == "O")) win = RO;
                 if (((bu1.Text == "X") || (bu1.Text == "O")) && ((bu2.Text == "X") || (bu2.Text == "O")) && ((bu3.Text == "X") || (bu3.Text == "O"))
                && ((bu4.Text == "X") || (bu4.Text == "O")) && ((bu5.Text == "X") || (bu5.Text == "O")) && ((bu6.Text == "X") || (bu6.Text == "O"))
                && ((bu7.Text == "X") || (bu7.Text == "O")) && ((bu8.Text == "X") || (bu8.Text == "O")) && ((bu9.Text == "X") || (bu9.Text == "O")))
                win = RN;
            return win;
        }
    }
}
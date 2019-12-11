using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz : CarouselPage
    {
        
        public Quiz()
        {
            InitializeComponent();
        }
        

        void ButtonClicked(object sender, System.EventArgs e)
        {
            ImageButton c = (ImageButton)sender;
            string answer = c.ClassId;

            if (answer == "audi")
            {
                DisplayAlert("Correct Answer", "1", "Continue");
            }
            else
            {
                DisplayAlert("Wrong Answer", "You lose", "Game Over");
            }



        }
        void ButtonClicked2(object sender, System.EventArgs e)
        {
            ImageButton c = (ImageButton)sender;
            string answer = c.ClassId;

            if (answer == "ford")
            {
                DisplayAlert("Correct Answer", "2", "Continue");
            }
            else
            {
                DisplayAlert("Wrong Answer", "You lose", "Game Over");
            }

        }

        void ButtonClicked3(object sender, System.EventArgs e)
        {
            ImageButton c = (ImageButton)sender;
            string answer = c.ClassId;

            if (answer == "bmw")
            {
                DisplayAlert("Correct Answer", "3", "Continue");
            }
            else
            {
                DisplayAlert("Wrong Answer", "You lose", "Game Over");
            }

        }

        void ButtonClicked4(object sender, System.EventArgs e)
        {
            ImageButton c = (ImageButton)sender;
            string answer = c.ClassId;

            if (answer == "hyundai")
            {
                DisplayAlert("Correct Answer", "4", "Continue");
            }
            else
            {
                DisplayAlert("Wrong Answer", "You lose", "Game Over");
            }

        }

        void ButtonClicked5(object sender, System.EventArgs e)
        {
            ImageButton c = (ImageButton)sender;
            string answer = c.ClassId;

            if (answer == "jaguar")
            {
                DisplayAlert("Correct Answer", "5", "Continue");
            }
            else
            {
                DisplayAlert("Wrong Answer", "You lose", "Game Over");
            }

        }
    }
}
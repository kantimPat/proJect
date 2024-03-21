using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proJect
{
    public class Products
    {
        public string Chicago = "Nike dunk low Chicago Split ";
        public string Indigo = "Nike dunk low Indigo Haze ";
        public string Cacao = "Nike dunk low Sail Cacao Wow ";
        public string one_High = "Jordan 1 High Switch Light Smoke ";
        public string one_Retro = "Jordan 1 Retro High OG True Blue ";

        



        public Image[] imageProducts = new Image[]
        {
            Properties.Resources.สกรีนช็อต_2024_03_09_153018,
            Properties.Resources.สกรีนช็อต_2024_03_09_153730,
            Properties.Resources.สกรีนช็อต_2024_03_09_153842,
            Properties.Resources.สกรีนช็อต_2024_03_09_154613,
            Properties.Resources.สกรีนช็อต_2024_03_09_154402
        };

        //ราคาตามไซส์
        public int[] price = new int[]
        {
            5_785 , 5_781 , 3_849 , 3_849 , 3_787 , 3_989
        };

        
    }

}

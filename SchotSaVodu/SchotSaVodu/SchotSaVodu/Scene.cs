using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchotSaVodu
{
    class Scene
    {
       
        public string text;
        public string imageurl;
        public string knopka;
        public string knopka2 = "";
        public string knopka3 = "";
        public string knopka4 = "";
        public string next = "";
        public string next2 = "";
        public string next3 = "";
        public string next4 = "";
       


        public Scene
            (
             string text, string IMG, string knopka, string next, string knopka2 = "", string next2 = "", string knopka3 = "", string next3 = "", string knopka4 = "",string next4 = ""
            )


        {
            
            this.text = text;
            this.imageurl = IMG;
            this.knopka = knopka;
            this.knopka2 = knopka2;
            this.knopka3 = knopka3;
            this.knopka4 = knopka4;
            this.next = next;
            this.next2 = next2;
            this.next3 = next3;
            this.next4 = next4;



        }
    }
}

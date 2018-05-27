using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchotSaVodu
{
    class Scene
    {
        public string name;
        public string text;
        public string imageurl;
        public List<string> knopkas = new List<string>() { };
        public List<string> nexts = new List<string>() { };



        public Scene
            (
             string name, string text, string IMG, string knopka, string next, string knopka2 = "", string next2 = "", string knopka3 = "", string next3 = "", string knopka4 = "", string next4 = ""
            )


        {
            this.name = name;
            this.text = text;
            this.imageurl = IMG;

            knopkas.Add(knopka);
            knopkas.Add(knopka2);
            knopkas.Add(knopka3);
            knopkas.Add(knopka4);

            nexts.Add(next);
            nexts.Add(next2);
            nexts.Add(next3);
            nexts.Add(next4);


        }
    }
}

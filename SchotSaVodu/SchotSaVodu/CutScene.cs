using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchotSaVodu
{
    class CutScene
    {
        public Int32 mainbreaking;
        public string mainbefore;
        public List<Image> pics = new List<Image>();

        public CutScene(List<string> picpaths,Int32 breaking,string before)
        {
            foreach(var elem in picpaths)
            {
                pics.Add(Image.FromFile(elem));
            }
            mainbreaking = breaking;
            mainbefore = before;
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchotSaVodu
{
    public partial class Form1 : Form
    {
        Dictionary<string, Scene> scenes;
       
        Scene currentscene;
        
        

        public Form1()
        {
            

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             scenes = new Dictionary<string, Scene>
        {
            {"",new Scene("Сегодня я запилю новый видос.\nРиск был просчитан.\nСпасибо,Рахмет,за вкусный обед.",@"Materials\preview.jpg","Далее","badmaths")},
            {"badmaths",new Scene("Но я плох в математике...",@"Materials\schot.jpg","Далее","starting")},
            {"starting",new Scene("beginning",@"Materials\the-beginning.png","Начать","day1","Закончить","closing")},
            {"day1",new Scene("...",@"Materials\day1.jpg","Далее","closing")}





        };

           

            currentscene = scenes.ElementAt(0).Value;
            ShowScene(currentscene);
           
        }

        

        private void ShowScene(Scene scene)
        {
            pictureBox1.BackgroundImage = Image.FromFile(scene.imageurl);
            label1.Text = scene.text;
            button1.Text = scene.knopka;
            button2.Text = scene.knopka2;
            button3.Text = scene.knopka3;
            button4.Text = scene.knopka4;

            if (scene.knopka2 != "")
                {
                    
                    button2.Enabled = true;
                    button2.Visible = true;
                    
                }
                if (scene.knopka3 != "")
                {
                    
                    button3.Enabled = true;
                    button3.Visible = true;
                }
                if (scene.knopka4 != "")
                {
                    
                    button4.Enabled = true;
                    button4.Visible = true;

                }

            currentscene = scene;
           

        }
        private void ChangeScene()
        {
            button2.Enabled = false;
            button2.Visible = false;
            button3.Enabled = false;
            button3.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;



            if ("closing" == currentscene.next || "closing" == currentscene.next2 || "closing" == currentscene.next3 || "closing" == currentscene.next4)
            {

                Close();

            }

            //тут find сделать

          



        }
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            ChangeScene();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ChangeScene();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ChangeScene();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            ChangeScene();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}

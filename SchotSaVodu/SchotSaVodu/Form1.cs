using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchotSaVodu
{
    public partial class Form1 : Form
    {
        List<Scene> Spisok;
        List<CutScene> Listok;
        Scene currentscene;
        Int32 situationcounter;
        Int32 counting = 0;
        CutScene currentcutscene;
        
        public Form1()
        {
            Adding();
            Addition();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowScene(Spisok[0]);
        }

        private void Adding()
        {
            Spisok = new List<Scene>()
            {
                new Scene("beginning", "Сегодня я запилю новый видос.\nРиск был просчитан.\nСпасибо,Рахмет,за вкусный обед.", @"Materials\preview.jpg", "Далее", "schot"),
                new Scene("schot", "Но я плох в математике...", @"Materials\schot.jpg", "Далее", "starting"),
                new Scene("starting", "", @"Materials\the-beginning.png", "Далее", "day1"),
                new Scene("day1", "...", @"Materials\day1.jpg", "Далее", "startingday1"),
                new Scene("startingday1", "Я попал! Мне нужно срочно всё оплатить!", @"Materials\panic.jpg", "Свалить", "weeklater","Начать искать деньги","waystoget"),
                new Scene("weeklater", "...", @"Materials\aweeklater.jpg", "Далее", "badending1"),
                new Scene("badending1", "Гыг", @"Materials\jail.jpg", "Конец", "closing"),
                new Scene("waystoget", "Вот несколько вариантов", @"Materials\ways.jpg", "Это демо,так что\n\"Закрыть\"", "closing")
            };
            
        }

        private void Addition()
        {
            Listok = new List<CutScene>()
            {
                new CutScene(new List<string>() { @"Materials\logo0.jpg", @"Materials\logo1.jpg", @"Materials\logo2.png" },1500,"schot")
            };
            
        }


        private void ShowScene(Scene scene)
        {
            pictureBox1.BackgroundImage = Image.FromFile(scene.imageurl);
            label1.Text = scene.text;
            button1.Text = scene.knopkas[0];
            button2.Text = scene.knopkas[1];
            button3.Text = scene.knopkas[2];
            button4.Text = scene.knopkas[3];

            if (scene.knopkas[1] != "")
            {

                button2.Enabled = true;
                button2.Visible = true;

            }
            if (scene.knopkas[2] != "")
            {

                button3.Enabled = true;
                button3.Visible = true;
            }
            if (scene.knopkas[3] != "")
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


            if (currentscene.nexts[situationcounter - 1] == "closing")
            {

                Close();

            }
            else
            {
                if(Spisok.Find(x => x.name == currentscene.nexts[situationcounter - 1]) != null)
                {
                    ShowScene(Spisok.Find(x => x.name == currentscene.nexts[situationcounter - 1]));
                }
                
            }







        }

        private void StartCutScene()
        {
            
                button1.Enabled = false;
                button1.Visible = false;
                button2.Enabled = false;
                button2.Visible = false;
                button3.Enabled = false;
                button3.Visible = false;
                button4.Enabled = false;
                button4.Visible = false;                
                label1.Text = "";
            

            
                if (currentscene.nexts[situationcounter - 1] == "closing")
                {

                    Close();

                }
                else
                {
                if (Listok.Find(x => x.mainbefore == currentscene.nexts[situationcounter - 1]) != null)
                {
                    ShowCutScene(Listok.Find(x => x.mainbefore == currentscene.nexts[situationcounter - 1]));
                }
                else
                {
                    ChangeScene();
                    pictureBox1.Dock = DockStyle.Top;
                    button1.Enabled = true;
                    button1.Visible = true;
                }

                }


           



        }

        private void ShowCutScene(CutScene cutscene)
        {
            
            currentcutscene = cutscene;            
            timer1.Enabled = true;            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            situationcounter = 1;
            StartCutScene();
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            situationcounter = 2;
            StartCutScene();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            situationcounter = 3;
            StartCutScene();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            situationcounter = 4;
            StartCutScene();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Interval = currentcutscene.mainbreaking;
            pictureBox1.Dock = DockStyle.Fill;

            if (counting < currentcutscene.pics.Count)
            {
                pictureBox1.BackgroundImage = currentcutscene.pics[counting];
                counting++;
            }
            else
            {
                counting = 0;
                ChangeScene();
                pictureBox1.Dock = DockStyle.Top;
                button1.Enabled = true;
                button1.Visible = true;
                timer1.Enabled = false;

            }
        }
    }
}

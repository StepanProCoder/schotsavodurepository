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
        List<Scene> Spisok = new List<Scene>();
        Scene currentscene;
        Int32 situationcounter;
        public Form1()
        {
            Adding();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowScene(Spisok[0]);
        }

        private void Adding()
        {
            Spisok.Add(new Scene("beginning", "Сегодня я запилю новый видос.\nРиск был просчитан.\nСпасибо,Рахмет,за вкусный обед.", @"Materials\preview.jpg", "Далее", "schot"));
            Spisok.Add(new Scene("schot", "Но я плох в математике...", @"Materials\schot.jpg", "Далее", "starting"));
            Spisok.Add(new Scene("starting", "", @"Materials\the-beginning.png", "Далее", "day1"));
            Spisok.Add(new Scene("day1", "...", @"Materials\day1.jpg", "Далее", "startingday1"));
            Spisok.Add(new Scene("startingday1", "Я попал! Мне нужно срочно всё оплатить!", @"Materials\panic.jpg", "Свалить", "weeklater","Начать искать деньги","waystoget"));
            Spisok.Add(new Scene("weeklater", "...", @"Materials\aweeklater.jpg", "Далее", "badending1"));
            Spisok.Add(new Scene("badending1", "Гыг", @"Materials\jail.jpg", "Конец", "closing"));
            Spisok.Add(new Scene("waystoget", "Вот несколько вариантов", @"Materials\ways.jpg", "Это демо,так что\n\"Закрыть\"", "closing"));
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

        private void button1_Click(object sender, EventArgs e)
        {
            situationcounter = 1;
            ChangeScene();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            situationcounter = 2;
            ChangeScene();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            situationcounter = 3;
            ChangeScene();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            situationcounter = 4;
            ChangeScene();
        }
    }
}

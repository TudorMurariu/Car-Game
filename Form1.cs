using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Car_Game
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int x, y, END = 1;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            this.player.URL = "CARGAME.mp3";            
        }
        
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {           
            Moveline(5);
            if (a % 42 == 0)
            {
                this.player.controls.play();
            }
            enemyMove(4);
            a += 5;
            if (Car.Bounds.IntersectsWith(enemy1.Bounds) || Car.Bounds.IntersectsWith(enemy2.Bounds) || Car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                this.END = 0;
                this.label1.Text = (a / 30).ToString();
                timer1.Stop();
                GAMEOVER.Visible = true;
                this.button1.Visible = true;
                this.button2.Visible = true;
                this.label1.Visible = true;
                this.label2.Visible = true;
            }
        }
        void enemyMove(int speed)
        {
            if (enemy1.Top >= 449)
            {
                x = r.Next(14, 259);
                y = r.Next(-500, -30);
                enemy1.Location = new Point(x, y);
            }
            if (enemy2.Top >= 449)
            {
                x = r.Next(14, 259);
                y = r.Next(-500, -30);
                enemy2.Location = new Point(x, y);
            }
            if (enemy3.Top >= 449)
            {
                x = r.Next(14, 259);
                y = r.Next(-500, -30);
                enemy3.Location = new Point(x, y);
            }
            enemy1.Top += speed;
            enemy2.Top += speed;
            enemy3.Top += speed;
        }
        void Moveline(int speed)
        {
            if(this.pictureBox1.Top >= 449)
            { this.pictureBox1.Top = 0; }
            else
            {  this.pictureBox1.Top += speed; }
            if (pictureBox2.Top >= 449)
            { pictureBox2.Top = 0; }
            else
            { pictureBox2.Top += speed; }
            if (pictureBox3.Top >= 449)
            { pictureBox3.Top = 0; }
            else
            { pictureBox3.Top += speed; }
            if (pictureBox4.Top >= 449)
            { pictureBox4.Top = 0; }
            else
            { pictureBox4.Top += speed; }
            if (pictureBox5.Top >= 449)
            { pictureBox5.Top = 0; }
            else
            { pictureBox5.Top += speed; }          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left && this.END == 1)
            {
                if (e.Shift == true && Car.Left > 50)
                    Car.Left -= 25;
                else if(Car.Left > 20)
                    Car.Left -= 10;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right && this.END == 1)
            {
                if (e.Shift == true && Car.Left < 250)
                    Car.Left += 25;
                else if (Car.Left < 250)
                    Car.Left += 10;
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up && this.END == 1)
            {
                if (e.Shift == true && Car.Top > 21)
                    Car.Top -= 14;
                if (Car.Top > 14)
                    Car.Top -= 7;
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down && this.END == 1)
            {
                if (e.Shift == true && Car.Top < 581 )
                    Car.Top += 14;
                if (Car.Top < 588)
                    Car.Top += 7;
                
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            Form1 w = new Form1();
            this.Visible = false;
            w.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

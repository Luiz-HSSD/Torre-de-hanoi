using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace aula_2_torre_de_hanoi
{
    public partial class Form1 : Form
    {
        private Point FirstPoint1 = new Point(62,206);
        private Point FirstPoint2 = new Point(102, 149);
        private Point FirstPoint3 = new Point(112, 102);
        private Point MyFuckingPoint = new Point();
        private Point[] BackupPoint = new Point[] 
        {
            new Point(62, 206),
            new Point(102,149),
            new Point(112,102)
        };
        private int passos=new int();
        public Form1()
        {
            InitializeComponent();
            label4.Text = passos.ToString();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (label1.Location.X + 40 != label2.Location.X  && label1.Location.X + 50 != label3.Location.X )
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    FirstPoint1 = e.Location;
                }
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && label3.Location.X != label2.Location.X + 10)
            {
                FirstPoint2 = e.Location;
            }

        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                FirstPoint3 = e.Location;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && label1.Location.X + 40 != label2.Location.X && label1.Location.X + 50 != label3.Location.X)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    label1.Left = e.X + label1.Left - FirstPoint1.X;
                    label1.Top = e.Y + label1.Top - FirstPoint1.Y;
                }
            }
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && label3.Location.X != label2.Location.X + 10)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    label2.Left = e.X + label2.Left - FirstPoint2.X;
                    label2.Top = e.Y + label2.Top - FirstPoint2.Y;
                }
            }

        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                label3.Left = e.X + label3.Left - FirstPoint3.X;
                label3.Top = e.Y + label3.Top - FirstPoint3.Y;
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            passos = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            reiniciar();
            Thread.Sleep(2000);

            //levar final o menor
            MyFuckingPoint.X = 795;
            MyFuckingPoint.Y = 234;

            label3.Location = MyFuckingPoint;
            passos++;
            Thread.Sleep(3000);
            //levar  meio médio
            MyFuckingPoint.X = 421;
            MyFuckingPoint.Y = 213;
            label2.Location = MyFuckingPoint;
            

            Thread.Sleep(3000);
            //
            MyFuckingPoint.X = 445;
            MyFuckingPoint.Y = 166;
            label3.Location = MyFuckingPoint;
            

            Thread.Sleep(3000);
            //
            MyFuckingPoint.X = 745;
            MyFuckingPoint.Y = 214;
            label1.Location = MyFuckingPoint;
            
            Thread.Sleep(3000);
            //
            MyFuckingPoint.X = 112;
            MyFuckingPoint.Y = 223;
            label3.Location = MyFuckingPoint;
            Thread.Sleep(3000);
            //
            MyFuckingPoint.X = 785;
            MyFuckingPoint.Y = 158;
            label2.Location = MyFuckingPoint;
            Thread.Sleep(3000);
            //
            MyFuckingPoint.X = 795;
            MyFuckingPoint.Y = 111;
            label3.Location = MyFuckingPoint;
            button1.Enabled = true;
            button2.Enabled = true;

        }
        private void reiniciar()
        {
            passos = 0;
            MyFuckingPoint.X = 112;
            MyFuckingPoint.Y = 102;
            label3.Location = MyFuckingPoint;


            //levar  meio médio
            MyFuckingPoint.X = 102;
            MyFuckingPoint.Y = 149;
            label2.Location = MyFuckingPoint;

            //
            MyFuckingPoint.X = 62;
            MyFuckingPoint.Y = 206;
            label1.Location = MyFuckingPoint;
            label4.Text = passos.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reiniciar();
        }


        

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            MyFuckingPoint = FirstPoint3;
            if (label3.Location.X <= 260)
            {
                if (label2.Location.X <= 260)
                {
                    if (label1.Location.X <= 260)
                    {

                        //levar no alto
                        MyFuckingPoint.X = 112;
                        MyFuckingPoint.Y = 102;
                        label3.Location = MyFuckingPoint;
                        BackupPoint[2] = MyFuckingPoint;
                        passos++;
                        label4.Text = passos.ToString();
                        return;
                    }
                    MyFuckingPoint.X = 112;
                    MyFuckingPoint.Y = 149;
                    BackupPoint[2] = MyFuckingPoint;
                    passos++;
                    label4.Text = passos.ToString();
                    label3.Location = MyFuckingPoint;
                }
                
                else
                {
                    MyFuckingPoint.X = 112;
                    if (label1.Location.X <= 260)
                        MyFuckingPoint.Y = 149;
                    else
                        MyFuckingPoint.Y = 206;
                    BackupPoint[2] = MyFuckingPoint;
                    passos++;
                    label4.Text = passos.ToString();
                    label3.Location = MyFuckingPoint;
                }

            }
            else if (label3.Location.X > 260 && label3.Location.X < 590)
            {
                if (label2.Location.X > 260 && label2.Location.X < 590)
                {
                    if (label1.Location.X > 260 && label1.Location.X < 590)
                    {

                        //levar no alto
                        MyFuckingPoint.X = 431;
                        MyFuckingPoint.Y = 102;
                        label3.Location = MyFuckingPoint;
                        BackupPoint[2] = MyFuckingPoint;
                        passos++;
                        label4.Text = passos.ToString();
                        return;
                    }
                    MyFuckingPoint.X = 431;
                    MyFuckingPoint.Y = 149;
                    BackupPoint[2] = MyFuckingPoint;
                    passos++;
                    label4.Text = passos.ToString();
                    label3.Location = MyFuckingPoint;
                }

                else
                {
                    MyFuckingPoint.X = 431;
                    if (label1.Location.X > 260 && label1.Location.X < 590)
                        MyFuckingPoint.Y = 149;
                    else
                        MyFuckingPoint.Y = 206;
                    BackupPoint[2] = MyFuckingPoint;
                    passos++;
                    label4.Text = passos.ToString();
                    this.label3.Location = MyFuckingPoint;
                }

            }
            else
            {
                if (label2.Location.X >= 590)
                {
                    if (label1.Location.X >= 590)
                    {

                        //levar no alto
                        MyFuckingPoint.X = 795;
                        MyFuckingPoint.Y = 102;
                        label3.Location = MyFuckingPoint;
                        BackupPoint[2] = MyFuckingPoint;
                        passos++;
                        label4.Text = passos.ToString();
                        if (passos == 7)
                            MessageBox.Show("Parabéns você venceu com a soulução ótima!");
                        else
                            MessageBox.Show("Muito Bem você venceu!");
                        return;
                    }
                    MyFuckingPoint.X = 795;
                    MyFuckingPoint.Y = 149;
                    BackupPoint[2] = MyFuckingPoint;
                    label3.Location = MyFuckingPoint;
                    passos++;
                    label4.Text = passos.ToString();
                }

                else
                {
                    MyFuckingPoint.X = 795;
                    if (label1.Location.X >= 590)
                        MyFuckingPoint.Y = 149;
                    else
                        MyFuckingPoint.Y = 206; 
                    BackupPoint[2] = MyFuckingPoint;
                    this.label3.Location = MyFuckingPoint;
                    passos++;
                    label4.Text = passos.ToString();
                }
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (label1.Location.X + 40 != label2.Location.X && label1.Location.X + 50 != label3.Location.X)
            {
                if (label1.Location.X <= 260)
                {
                    if (label2.Location.X <= 260 || label3.Location.X <= 260)
                    {

                        //levar no alto
                        MyFuckingPoint = BackupPoint[0];
                        label1.Location = MyFuckingPoint;
                        return;

                    }
                    MyFuckingPoint.X = 62;
                    MyFuckingPoint.Y = 206;
                    BackupPoint[0] = MyFuckingPoint;
                    label1.Location = MyFuckingPoint;
                    passos++;
                    label4.Text = passos.ToString();
                }
                else if (label1.Location.X > 260 && label1.Location.X < 590)
                {
                    if (label2.Location.X > 260 && label2.Location.X < 590 || label3.Location.X > 260 && label3.Location.X < 590)
                    {

                        //levar no alto
                        MyFuckingPoint = BackupPoint[0];
                        label1.Location = MyFuckingPoint;
                        return;

                    }
                    MyFuckingPoint.X = 381;
                    MyFuckingPoint.Y = 206;
                    BackupPoint[0] = MyFuckingPoint;
                    label1.Location = MyFuckingPoint;
                    passos++;
                    label4.Text = passos.ToString();

                }
                else
                {
                    if (label2.Location.X >= 590 || label3.Location.X >= 590)
                    {

                        MyFuckingPoint = BackupPoint[0];
                        label1.Location = MyFuckingPoint;
                        return;

                    }
                    MyFuckingPoint.X = 745;
                    MyFuckingPoint.Y = 206;
                    BackupPoint[0] = MyFuckingPoint;
                    label1.Location = MyFuckingPoint;
                    passos++;
                    label4.Text = passos.ToString();
                }
            }
        }
        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            if (label3.Location.X+10 != label2.Location.X)
            {
                MyFuckingPoint = FirstPoint2;
                if (label2.Location.X <= 260)
                {
                    if (label3.Location.X <= 260)
                    {

                        //levar no alto
                        MyFuckingPoint = BackupPoint[1];
                        label2.Location = MyFuckingPoint;
                        return;

                    }
                    MyFuckingPoint.X = 102;
                    if (label1.Location.X <= 260)
                        MyFuckingPoint.Y = 149;
                    else
                        MyFuckingPoint.Y = 206;
                    BackupPoint[1] = MyFuckingPoint;
                    label2.Location = MyFuckingPoint;
                    passos++;
                    label4.Text = passos.ToString();
                }
                else if (label2.Location.X > 260 && label2.Location.X < 590)
                {
                    if (label3.Location.X > 260 && label3.Location.X < 590)
                    {

                        //levar no alto
                        MyFuckingPoint = BackupPoint[1];
                        label2.Location = MyFuckingPoint;
                        return;

                    }
                    MyFuckingPoint.X = 421;
                    if (label1.Location.X > 260 && label1.Location.X < 590)
                        MyFuckingPoint.Y = 149;
                    else
                        MyFuckingPoint.Y = 206;
                    BackupPoint[1] = MyFuckingPoint;
                    label2.Location = MyFuckingPoint;
                    passos++;
                    label4.Text = passos.ToString();

                }
                else
                {
                    if (label3.Location.X >= 590)
                    {

                        //levar no alto
                        MyFuckingPoint = BackupPoint[1];
                        label2.Location = MyFuckingPoint;
                        return;

                    }
                    MyFuckingPoint.X = 785;
                    if (label1.Location.X >= 590)
                        MyFuckingPoint.Y = 149;
                    else
                        MyFuckingPoint.Y = 206;
                    BackupPoint[1] = MyFuckingPoint;
                    label2.Location = MyFuckingPoint;
                    passos++;
                    label4.Text = passos.ToString();
                }
            }
        }

    }
    
}
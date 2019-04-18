using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceV2
{
    public partial class Simulation : Form
    {
        PictureBox pbE1 = null;
        PictureBox pbE2 = null;
        PictureBox pbE3 = null;
        PictureBox pbE4 = null;
        PictureBox pbE5 = null;
        PictureBox pbE6 = null;
        int selectNumber = 0;
        int top = 0;
        int left = 0;

        public Simulation()
        {
            InitializeComponent();
           
        }
        List<MapObjects> temp = null;
        private void Simulation_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            temp = Form1.container;
            Image enemyImage = null;
            int pictureBoxCount = 0;
            pbAeroplane.Image = Form1.img;
            foreach (EnemyBaseObjects item in Form1.enemyObjects)
            {
                pictureBoxCount++;
                if (pictureBoxCount==1)
                {
                    pb1.Image = item.Pictures;
                    pb1.Name = item.Name;
                }
                if (pictureBoxCount == 2)
                {
                    pb2.Image = item.Pictures;
                    pb2.Name = item.Name;
                }
                if (pictureBoxCount == 3)
                {
                    pb3.Image = item.Pictures;
                    pb3.Name = item.Name;
                }
                if (pictureBoxCount == 4)
                {
                    pb4.Image = item.Pictures;
                    pb4.Name = item.Name;
                }
                if (pictureBoxCount == 5)
                {
                    pb5.Image = item.Pictures;
                    pb5.Name = item.Name;
                }
                if (pictureBoxCount == 6)
                {
                    pb6.Image = item.Pictures;
                    pb6.Name = item.Name;
                }
            }
            foreach (MapObjects item in temp)
            {
                left = item.Coordinates.X;
                top = item.Coordinates.Y;
                enemyImage = item.Images;
                switch (selectNumber)
                {
                    case 0:
                        {
                            pbE1 = new PictureBox();
                            pbE1.BringToFront();
                            Controls.Add(pbE1);
                            pbE1.Location = new System.Drawing.Point(left, top);
                            pbE1.Name = "pbE1";
                            pbE1.Size = new System.Drawing.Size(50, 50);
                            pbE1.TabIndex = 0;
                            pbE1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pbE1.BackColor = Color.Transparent;
                            pbE1.Image = enemyImage;
                        }
                        break;
                    case 1:
                        {
                            pbE2 = new PictureBox();
                            pbE2.BringToFront();
                            Controls.Add(pbE2);
                            pbE2.Location = new System.Drawing.Point(left, top);
                            pbE2.Name = "pbE2";
                            pbE2.Size = new System.Drawing.Size(50, 50);
                            pbE2.TabIndex = 0;
                            pbE2.SizeMode = PictureBoxSizeMode.StretchImage;
                            pbE2.BackColor = Color.Transparent;
                            pbE2.Image = enemyImage;
                        }
                        break;
                    case 2:
                        {
                            pbE3 = new PictureBox();
                            pbE3.BringToFront();
                            Controls.Add(pbE3);
                            pbE3.Location = new System.Drawing.Point(left, top);
                            pbE3.Name = "pbE3";
                            pbE3.Size = new System.Drawing.Size(50, 50);
                            pbE3.TabIndex = 0;
                            pbE3.SizeMode = PictureBoxSizeMode.StretchImage;
                            pbE3.BackColor = Color.Transparent;
                            pbE3.Image = enemyImage;
                        }
                        break;
                    case 3:
                        {
                            pbE4 = new PictureBox();
                            pbE4.BringToFront();
                            Controls.Add(pbE4);
                            pbE4.Location = new System.Drawing.Point(left, top);
                            pbE4.Name = "pbE4";
                            pbE4.Size = new System.Drawing.Size(50, 50);
                            pbE4.TabIndex = 0;
                            pbE4.SizeMode = PictureBoxSizeMode.StretchImage;
                            pbE4.BackColor = Color.Transparent;
                            pbE4.Image = enemyImage;
                        }
                        break;
                    case 4:
                        {
                            pbE5 = new PictureBox();
                            pbE5.BringToFront();
                            Controls.Add(pbE5);
                            pbE5.Location = new System.Drawing.Point(left, top);
                            pbE5.Name = "pbE5";
                            pbE5.Size = new System.Drawing.Size(50, 50);
                            pbE5.TabIndex = 0;
                            pbE5.SizeMode = PictureBoxSizeMode.StretchImage;
                            pbE5.BackColor = Color.Transparent;
                            pbE5.Image = enemyImage;
                        }
                        break;
                    case 5:
                        {
                            pbE6 = new PictureBox();
                            pbE6.BringToFront();
                            Controls.Add(pbE6);
                            pbE6.Location = new System.Drawing.Point(left, top);
                            pbE6.Name = "pbE6";
                            pbE6.Size = new System.Drawing.Size(50, 50);
                            pbE6.TabIndex = 0;
                            pbE6.SizeMode = PictureBoxSizeMode.StretchImage;
                            pbE6.BackColor = Color.Transparent;
                            pbE6.Image = enemyImage;
                        }
                        break;
                    default:
                        {
                        }
                        break;

                }
                selectNumber++;
            }

            //circularProgressBar1.Value = 0;
            //circularProgressBar1.Minimum = 0;
            //circularProgressBar1.Maximum = 100;

            //for (int i = 0; i < 100; i++)
            //{
            //    System.Threading.Thread.Sleep(100);
            //    circularProgressBar1.Value = i;
            //    circularProgressBar1.Update();
            //}

        }
    }
}

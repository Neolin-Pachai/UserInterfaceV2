using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UserInterfaceV2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// To access the location, height and width of an enemy obstuction you can use 'Form1.container' to retrive a list of enemy obstuctions
        /// What still has to be done:
        /// - Connect the database
        ///     -pictures of enemy base buildings
        ///     -plane and jet information
        ///     -users in database
        /// - Generate report and link to database
        /// - Make database portable to the program
        /// - Fix Random Obstruction Generate Opverlap
        /// - Simulate Bombing and movement
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #region Global variables
        /// <summary>
        /// These are all the variables that are used in different methods throughout the form
        /// </summary>
        private bool isCollapsed;
        private bool isCollapsedTwo;
        public static Image img;
        public static List<MapObjects> container = new List<MapObjects>();
        public static List<EnemyBaseObjects> enemyObjects = new List<EnemyBaseObjects>();
        List<EnemyBaseObjects> enemyObjectsAll = new List<EnemyBaseObjects>();
        Point locationE1 = new Point();
        Point locationE2 = new Point();
        Point locationE3 = new Point();
        Point locationE4 = new Point();
        Point locationE5 = new Point();
        Point locationE6 = new Point();
        public int obstructionCount;
        private Point MouseDownLoaction;
        int maxLeft = 730;
        int minLeft = 150;
        int maxTop = 330;
        int top = 0;
        int left = 0;
        PictureBox pbE1 = null;
        PictureBox pbE2 = null;
        PictureBox pbE3 = null;
        PictureBox pbE4 = null;
        PictureBox pbE5 = null;
        PictureBox pbE6 = null;
        int selectNumber = 0;
        #endregion

        #region Boundry Creation
        /// <summary>
        /// When the form loads it will point to a method that will create the boundry
        /// that method uses multicast delegates refers to methods that will use threading to actively look if objects are going outside the boarder
        /// if objects do move outside the thread will invoke a method to push the object back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Boundry(); //reffering to method that create barrier for obstrcution objects
        }
        public void Boundry()
        {
            Checking a, b, c, d, e, f;
            a = new Checking(checkE1);
            b = new Checking(checkE2);
            c = new Checking(checkE3);
            d = new Checking(checkE4);
            e = new Checking(checkE5);
            f = new Checking(checkE6);
            Thread t1 = new Thread(() =>
            {
                bool repeat = true;
                while (repeat)
                {
                    if (pbE1 != null)
                    {
                        Invoke(a);
                    }
                    if (pbE2 != null)
                    {
                        Invoke(b);
                    }
                    if (pbE3 != null)
                    {
                        Invoke(c);
                    }
                    if (pbE4 != null)
                    {
                        Invoke(d);
                    }
                    if (pbE5 != null)
                    {
                        Invoke(e);
                    }
                    if (pbE6 != null)
                    {
                        Invoke(f);
                    }
                }
            });
            t1.Start();
        }

        public delegate void Checking();

        public void checkE1()
        {
            if (pbE1.Top <= 0)
            {
                pbE1.Top = 0;
            }
            else if (pbE1.Top >= maxTop)
            {
                pbE1.Top = maxTop;
            }
            else if (pbE1.Left < minLeft)
            {
                pbE1.Left = minLeft;
            }
            else if (pbE1.Left > maxLeft)
            {
                pbE1.Left = maxLeft;
            }

            locationE1.X = pbE1.Left;
            locationE1.Y = pbE1.Top;
            foreach (var item in container)
            {
                if (item.Name == "E1")
                {
                    item.Coordinates = locationE1;
                }
            }
        }
        public void checkE2()
        {
            if (pbE2.Top <= 0)
            {
                pbE2.Top = 0;
            }
            else if (pbE2.Top >= 330)
            {
                pbE2.Top = 330;
            }
            else if (pbE2.Left < minLeft)
            {
                pbE2.Left = minLeft;
            }
            else if (pbE2.Left > maxLeft)
            {
                pbE2.Left = maxLeft;
            }
            locationE2.X = pbE2.Left;
            locationE2.Y = pbE2.Top;
            foreach (var item in container)
            {
                if (item.Name == "E2")
                {
                    item.Coordinates = locationE2;
                }
            }
        }
        public void checkE3()
        {
            if (pbE3.Top <= 0)
            {
                pbE3.Top = 0;
            }
            else if (pbE3.Top >= 330)
            {
                pbE3.Top = 330;
            }
            else if (pbE3.Left < minLeft)
            {
                pbE3.Left = minLeft;
            }
            else if (pbE3.Left > maxLeft)
            {
                pbE3.Left = maxLeft;
            }
            locationE3.X = pbE3.Left;
            locationE3.Y = pbE3.Top;
            foreach (var item in container)
            {
                if (item.Name == "E3")
                {
                    item.Coordinates = locationE3;
                }
            }
        }
        public void checkE4()
        {
            if (pbE4.Top <= 0)
            {
                pbE4.Top = 0;
            }
            else if (pbE4.Top >= 330)
            {
                pbE4.Top = 330;
            }
            else if (pbE4.Left < minLeft)
            {
                pbE4.Left = minLeft;
            }
            else if (pbE4.Left > maxLeft)
            {
                pbE4.Left = maxLeft;
            }
            locationE4.X = pbE4.Left;
            locationE4.Y = pbE4.Top;
            foreach (var item in container)
            {
                if (item.Name == "E4")
                {
                    item.Coordinates = locationE4;
                }
            }
        }
        public void checkE5()
        {
            if (pbE5.Top <= 0)
            {
                pbE5.Top = 0;
            }
            else if (pbE5.Top >= 330)
            {
                pbE5.Top = 330;
            }
            else if (pbE5.Left < minLeft)
            {
                pbE5.Left = minLeft;
            }
            else if (pbE5.Left > maxLeft)
            {
                pbE5.Left = maxLeft;
            }
            locationE5.X = pbE5.Left;
            locationE5.Y = pbE5.Top;
            foreach (var item in container)
            {
                if (item.Name == "E5")
                {
                    item.Coordinates = locationE5;
                }
            }
        }
        public void checkE6()
        {
            if (pbE6.Top <= 0)
            {
                pbE6.Top = 0;
            }
            else if (pbE6.Top >= 330)
            {
                pbE6.Top = 330;
            }
            else if (pbE6.Left < minLeft)
            {
                pbE6.Left = minLeft;
            }
            else if (pbE6.Left > maxLeft)
            {
                pbE6.Left = maxLeft;
            }
            locationE6.X = pbE6.Left;
            locationE6.Y = pbE6.Top;
            foreach (var item in container)
            {
                if (item.Name == "E6")
                {
                    item.Coordinates = locationE6;
                }
            }
        }
#endregion

        #region Drop Down Selection Menu
        /// <summary>
        /// This is the code for the selection menu of aeroplanes and enemy obstructions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) // this method is used for the drop down selection menu for aeroplane
        {
            if (isCollapsed)
            {
                pnlAeroplanes.Height += 10;
                if (pnlAeroplanes.Size == pnlAeroplanes.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                pnlAeroplanes.Height -= 10;
                if (pnlAeroplanes.Size == pnlAeroplanes.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnAeroplane_Click(object sender, EventArgs e) // button that drops down aeroplane selection menu
        {
            timer1.Start();
            pnlAeroplanes.BringToFront();
        }

        private void timer2_Tick(object sender, EventArgs e) // this method is used for the drop down selection menu for Enemies
        {
            if (isCollapsedTwo)
            {
                pnlEnemies.Height += 10;
                if (pnlEnemies.Size == pnlEnemies.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsedTwo = false;
                }
            }
            else
            {
                pnlEnemies.Height -= 10;
                if (pnlEnemies.Size == pnlEnemies.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsedTwo = true;
                }
            }
        }

        private void btnEnemy_Click(object sender, EventArgs e) // button that drops down aeroplane selection menu
        {
            timer2.Start();
            pnlEnemies.BringToFront();
        }

        private void btnA1_Click(object sender, EventArgs e) // button that gives aeroplane image to aeroplane picture box
        {
            img = UserInterfaceV2.Resource1.P1;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbAeroplane.Image = img;


        }

        private void btnA2_Click(object sender, EventArgs e)// button that gives aeroplane image to aeroplane picture box
        {
            img = UserInterfaceV2.Resource1.P2;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbAeroplane.Image = img;

        }

        private void btnA3_Click(object sender, EventArgs e)// button that gives aeroplane image to aeroplane picture box
        {
            img = UserInterfaceV2.Resource1.P3;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbAeroplane.Image = img;
        }

        

        private void btnE1_Click(object sender, EventArgs e)//refers to a method that creates a enemy picture box with its appropriate fields
        {
            PbEnemyCreation(1);

        }
        private void btnE2_Click(object sender, EventArgs e)//refers to a method that creates a enemy picture box with its appropriate fields
        {
            PbEnemyCreation(2);
        }

        private void btnE3_Click(object sender, EventArgs e)//refers to a method that creates a enemy picture box with its appropriate fields
        {
            PbEnemyCreation(3);
        }
        #endregion

        #region Enemy Object Creation
        /// <summary>
        /// This creates the enemy objects using a random location (still fixing creation on top of one another)
        /// It gives the object an image*
        /// This Also subscribes the picture boxes to events that will allow it to move
        /// Then it creates the object onto the panel while also adding objects into a list
        /// *-suject to change
        /// </summary>
        /// <param name="imageID"></param>
        public void PbEnemyCreation(int imageID)
        {
            
            /*while (!identical)
            {
                identical = true;*/
                Random randomTop = new Random();
                top = randomTop.Next(0, maxTop);
                System.Threading.Thread.Sleep(30);
                Random randomLeft = new Random();
                left = randomLeft.Next(minLeft, maxLeft);
                /*foreach (MapObjects item in container)
                {
                    foreach (MapObjects itemName in container)
                    {
                        if (itemName.Coordinates.X <= item.Coordinates.X + 50 && itemName.Coordinates.X >= item.Coordinates.X && itemName.Coordinates.Y <= item.Coordinates.Y + 50 && itemName.Coordinates.Y >= item.Coordinates.Y)
                        {
                            identical = false;
                        }
                    }
                    
                }
            }
            identical = false;*/
            Image enemyImage = null;
            if (imageID == 1)
            {
                enemyImage = UserInterfaceV2.Resource1.rb_410___neon_rainbow_round_ball_;
            }
            else if (imageID == 2)
            {
                enemyImage = UserInterfaceV2.Resource1.red_ball_md;
            }
            else
            {
                enemyImage = UserInterfaceV2.Resource1.n9032921;
            }

            switch (selectNumber)
            {
                case 0:
                    {
                        pbE1 = new PictureBox();
                        pbE1.BringToFront();
                        this.panel1.Controls.Add(pbE1);
                        pbE1.Location = new System.Drawing.Point(left, top);
                        pbE1.Name = "pbE1";
                        pbE1.Size = new System.Drawing.Size(50, 50);
                        pbE1.TabIndex = 0;
                        pbE1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbE1.BackColor = Color.Transparent;
                        pbE1.Image = enemyImage;
                        pbE1.MouseDown += PbE_MouseDown;
                        pbE1.MouseMove += PbE1_MouseMove;
                        selectNumber++;
                        container.Add(new MapObjects("E1", locationE1, pbE1.Width, pbE1.Height,imageID.ToString(),enemyImage));
                    }
                    break;
                case 1:
                    {
                        pbE2 = new PictureBox();
                        pbE2.BringToFront();
                        this.panel1.Controls.Add(pbE2);
                        pbE2.Location = new System.Drawing.Point(left, top);
                        pbE2.Name = "pbE2";
                        pbE2.Size = new System.Drawing.Size(50, 50);
                        pbE2.TabIndex = 0;
                        pbE2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbE2.BackColor = Color.Transparent;
                        pbE2.Image = enemyImage;
                        pbE2.MouseDown += PbE_MouseDown;
                        pbE2.MouseMove += PbE2_MouseMove;
                        selectNumber++;
                        container.Add(new MapObjects("E2", locationE2, pbE2.Width, pbE2.Height, imageID.ToString(), enemyImage));
                    }
                    break;
                case 2:
                    {
                        pbE3 = new PictureBox();
                        pbE3.BringToFront();
                        this.panel1.Controls.Add(pbE3);
                        pbE3.Location = new System.Drawing.Point(left, top);
                        pbE3.Name = "pbE3";
                        pbE3.Size = new System.Drawing.Size(50, 50);
                        pbE3.TabIndex = 0;
                        pbE3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbE3.BackColor = Color.Transparent;
                        pbE3.Image = enemyImage;
                        pbE3.MouseDown += PbE_MouseDown;
                        pbE3.MouseMove += PbE3_MouseMove;
                        selectNumber++;
                        container.Add(new MapObjects("E3", locationE3, pbE3.Width, pbE3.Height, imageID.ToString(), enemyImage));
                    }
                    break;
                case 3:
                    {
                        pbE4 = new PictureBox();
                        pbE4.BringToFront();
                        this.panel1.Controls.Add(pbE4);
                        pbE4.Location = new System.Drawing.Point(left, top);
                        pbE4.Name = "pbE4";
                        pbE4.Size = new System.Drawing.Size(50, 50);
                        pbE4.TabIndex = 0;
                        pbE4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbE4.BackColor = Color.Transparent;
                        pbE4.Image = enemyImage;
                        pbE4.MouseDown += PbE_MouseDown;
                        pbE4.MouseMove += PbE4_MouseMove;
                        selectNumber++;
                        container.Add(new MapObjects("E4", locationE4, pbE4.Width, pbE4.Height, imageID.ToString(), enemyImage));

                    }
                    break;
                case 4:
                    {
                        pbE5 = new PictureBox();
                        pbE5.BringToFront();
                        this.panel1.Controls.Add(pbE5);
                        pbE5.Location = new System.Drawing.Point(left, top);
                        pbE5.Name = "pbE5";
                        pbE5.Size = new System.Drawing.Size(50, 50);
                        pbE5.TabIndex = 0;
                        pbE5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbE5.BackColor = Color.Transparent;
                        pbE5.Image = enemyImage;
                        pbE5.MouseDown += PbE_MouseDown;
                        pbE5.MouseMove += PbE5_MouseMove;
                        selectNumber++;
                        container.Add(new MapObjects("E5", locationE5, pbE5.Width, pbE5.Height, imageID.ToString(), enemyImage));

                    }
                    break;
                case 5:
                    {
                        pbE6 = new PictureBox();
                        pbE6.BringToFront();
                        this.panel1.Controls.Add(pbE6);
                        pbE6.Location = new System.Drawing.Point(left, top);
                        pbE6.Name = "pbE6";
                        pbE6.Size = new System.Drawing.Size(50, 50);
                        pbE6.TabIndex = 0;
                        pbE6.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbE6.BackColor = Color.Transparent;
                        pbE6.Image = enemyImage;
                        pbE6.MouseDown += PbE_MouseDown;
                        pbE6.MouseMove += PbE6_MouseMove;
                        selectNumber++;
                        container.Add(new MapObjects("E6", locationE6, pbE6.Width, pbE6.Height, imageID.ToString(), enemyImage));

                    }
                    break;
                default:
                    {
                        MessageBox.Show("Exceeded Item Limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

            }
            obstructionCount++;

        }
        #endregion

        #region Object Movement
        /// <summary>
        /// This has methods for events that fire when the user clicks and holds on an enemy obstruction
        /// these methods have code to determine where the object moves
        /// it also checks whether the object that is being moved will not overlap ontop of another enemy obstruction
        /// At the end the code will set the location values accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbE1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (pbE1.Left >= minLeft && pbE1.Top >= 0 && pbE1.Left <= maxLeft && pbE1.Top <= maxTop)
                {
                    pbE1.Left = e.X + pbE1.Left - MouseDownLoaction.X; ;
                    pbE1.Top = e.Y + pbE1.Top - MouseDownLoaction.Y; ;
                    label1.Text = pbE1.Location.ToString();
                    foreach (MapObjects item in container)
                    {
                        if (item.Name != "E1")
                        {
                            if ((pbE1.Left <= item.Coordinates.X + 50 && pbE1.Left >= item.Coordinates.X + 5 && pbE1.Top <= item.Coordinates.Y + 50 && pbE1.Top >= item.Coordinates.Y) || (pbE1.Left <= item.Coordinates.X + 50 && pbE1.Left >= item.Coordinates.X + 5 && pbE1.Top + 50 <= item.Coordinates.Y + 50 && pbE1.Top + 50 >= item.Coordinates.Y))
                            {
                                pbE1.Left = item.Coordinates.X + 52;
                            }
                            if ((pbE1.Left + 50 >= item.Coordinates.X && pbE1.Left + 5 <= item.Coordinates.X && pbE1.Top <= item.Coordinates.Y + 50 && pbE1.Top >= item.Coordinates.Y) || (pbE1.Left + 50 >= item.Coordinates.X && pbE1.Left + 5 <= item.Coordinates.X && pbE1.Top + 50 <= item.Coordinates.Y + 50 && pbE1.Top + 50 >= item.Coordinates.Y))
                            {
                                pbE1.Left = item.Coordinates.X -52;
                            }
                            if ((pbE1.Top <= item.Coordinates.Y + 50 && pbE1.Top >= item.Coordinates.Y + 5 && pbE1.Left <= item.Coordinates.X + 50 && pbE1.Left >= item.Coordinates.X) || (pbE1.Top <= item.Coordinates.Y + 50 && pbE1.Top >= item.Coordinates.Y + 5 && pbE1.Left + 50 <= item.Coordinates.X + 50 && pbE1.Left + 50 >= item.Coordinates.X))
                            {
                                pbE1.Top = item.Coordinates.Y + 52;
                            }
                            if ((pbE1.Top + 50 >= item.Coordinates.Y && pbE1.Top + 5 <= item.Coordinates.Y && pbE1.Left <= item.Coordinates.X + 50 && pbE1.Left >= item.Coordinates.X) || (pbE1.Top + 50 >= item.Coordinates.Y && pbE1.Top + 5 <= item.Coordinates.Y && pbE1.Left + 50 <= item.Coordinates.X + 50 && pbE1.Left + 50 >= item.Coordinates.X))
                            {
                                pbE1.Top = item.Coordinates.Y - 52;
                            }
                        }
                    }
                    locationE1.X = pbE1.Left;
                    locationE1.Y = pbE1.Top;
                    foreach (var item in container)
                    {
                        if (item.Name == "E1")
                        {
                            item.Coordinates = locationE1;
                        }
                    }
                }
            }
        }
        private void PbE2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (pbE2.Left >= minLeft && pbE2.Top >= 0 && pbE2.Left <= maxLeft && pbE2.Top <= maxTop)
                {
                    pbE2.Left = e.X + pbE2.Left - MouseDownLoaction.X; ;
                    pbE2.Top = e.Y + pbE2.Top - MouseDownLoaction.Y; ;
                    label1.Text = pbE2.Location.ToString();
                    foreach (MapObjects item in container)
                    {
                        if (item.Name != "E2")
                        {
                            if ((pbE2.Left <= item.Coordinates.X + 50 && pbE2.Left >= item.Coordinates.X + 5 && pbE2.Top <= item.Coordinates.Y + 50 && pbE2.Top >= item.Coordinates.Y) || (pbE2.Left <= item.Coordinates.X + 50 && pbE2.Left >= item.Coordinates.X + 5 && pbE2.Top + 50 <= item.Coordinates.Y + 50 && pbE2.Top + 50 >= item.Coordinates.Y))
                            {
                                pbE2.Left = item.Coordinates.X + 52;
                            }
                            if ((pbE2.Left + 50 >= item.Coordinates.X && pbE2.Left + 5 <= item.Coordinates.X && pbE2.Top <= item.Coordinates.Y + 50 && pbE2.Top >= item.Coordinates.Y) || (pbE2.Left + 50 >= item.Coordinates.X && pbE2.Left + 5 <= item.Coordinates.X && pbE2.Top + 50 <= item.Coordinates.Y + 50 && pbE2.Top + 50 >= item.Coordinates.Y))
                            {
                                pbE2.Left = item.Coordinates.X - 52;
                            }
                            if ((pbE2.Top <= item.Coordinates.Y + 50 && pbE2.Top >= item.Coordinates.Y + 5 && pbE2.Left <= item.Coordinates.X + 50 && pbE2.Left >= item.Coordinates.X) || (pbE2.Top <= item.Coordinates.Y + 50 && pbE2.Top >= item.Coordinates.Y + 5 && pbE2.Left + 50 <= item.Coordinates.X + 50 && pbE2.Left + 50 >= item.Coordinates.X))
                            {
                                pbE2.Top = item.Coordinates.Y + 52;
                            }
                            if ((pbE2.Top + 50 >= item.Coordinates.Y && pbE2.Top + 5 <= item.Coordinates.Y && pbE2.Left <= item.Coordinates.X + 50 && pbE2.Left >= item.Coordinates.X) || (pbE2.Top + 50 >= item.Coordinates.Y && pbE2.Top + 5 <= item.Coordinates.Y && pbE2.Left + 50 <= item.Coordinates.X + 50 && pbE2.Left + 50 >= item.Coordinates.X))
                            {
                                pbE2.Top = item.Coordinates.Y - 52;
                            }
                        }
                    }
                    locationE2.X = pbE2.Left;
                    locationE2.Y = pbE2.Top;
                    foreach (var item in container)
                    {
                        if (item.Name == "E2")
                        {
                            item.Coordinates = locationE2;
                        }
                    }
                }
            }
        }
        private void PbE3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (pbE3.Left >= minLeft && pbE3.Top >= 0 && pbE3.Left <= maxLeft && pbE3.Top <= maxTop)
                {
                    pbE3.Left = e.X + pbE3.Left - MouseDownLoaction.X; ;
                    pbE3.Top = e.Y + pbE3.Top - MouseDownLoaction.Y; ;
                    label1.Text = pbE3.Location.ToString();
                    locationE3.X = pbE3.Left;
                    locationE3.Y = pbE3.Top;
                    foreach (MapObjects item in container)
                    {
                        if (item.Name != "E3")
                        {
                            if ((pbE3.Left <= item.Coordinates.X + 50 && pbE3.Left >= item.Coordinates.X + 5 && pbE3.Top <= item.Coordinates.Y + 50 && pbE3.Top >= item.Coordinates.Y) || (pbE3.Left <= item.Coordinates.X + 50 && pbE3.Left >= item.Coordinates.X + 5 && pbE3.Top + 50 <= item.Coordinates.Y + 50 && pbE3.Top + 50 >= item.Coordinates.Y))
                            {
                                pbE3.Left = item.Coordinates.X + 52;
                            }
                            if ((pbE3.Left + 50 >= item.Coordinates.X && pbE3.Left + 5 <= item.Coordinates.X && pbE3.Top <= item.Coordinates.Y + 50 && pbE3.Top >= item.Coordinates.Y) || (pbE3.Left + 50 >= item.Coordinates.X && pbE3.Left + 5 <= item.Coordinates.X && pbE3.Top + 50 <= item.Coordinates.Y + 50 && pbE3.Top + 50 >= item.Coordinates.Y))
                            {
                                pbE3.Left = item.Coordinates.X - 52;
                            }
                            if ((pbE3.Top <= item.Coordinates.Y + 50 && pbE3.Top >= item.Coordinates.Y + 5 && pbE3.Left <= item.Coordinates.X + 50 && pbE3.Left >= item.Coordinates.X) || (pbE3.Top <= item.Coordinates.Y + 50 && pbE3.Top >= item.Coordinates.Y + 5 && pbE3.Left + 50 <= item.Coordinates.X + 50 && pbE3.Left + 50 >= item.Coordinates.X))
                            {
                                pbE3.Top = item.Coordinates.Y + 52;
                            }
                            if ((pbE3.Top + 50 >= item.Coordinates.Y && pbE3.Top + 5 <= item.Coordinates.Y && pbE3.Left <= item.Coordinates.X + 50 && pbE3.Left >= item.Coordinates.X) || (pbE3.Top + 50 >= item.Coordinates.Y && pbE3.Top + 5 <= item.Coordinates.Y && pbE3.Left + 50 <= item.Coordinates.X + 50 && pbE3.Left + 50 >= item.Coordinates.X))
                            {
                                pbE3.Top = item.Coordinates.Y - 52;
                            }
                        }
                    }
                    foreach (var item in container)
                    {
                        if (item.Name == "E3")
                        {
                            item.Coordinates = locationE3;
                        }
                    }
                }
            }
        }
        private void PbE4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (pbE4.Left >= minLeft && pbE4.Top >= 0 && pbE4.Left <= maxLeft && pbE4.Top <= maxTop)
                {
                    pbE4.Left = e.X + pbE4.Left - MouseDownLoaction.X; ;
                    pbE4.Top = e.Y + pbE4.Top - MouseDownLoaction.Y; ;
                    label1.Text = pbE4.Location.ToString();
                    locationE4.X = pbE4.Left;
                    locationE4.Y = pbE4.Top;
                    foreach (MapObjects item in container)
                    {
                        if (item.Name != "E4")
                        {
                            if ((pbE4.Left <= item.Coordinates.X + 50 && pbE4.Left >= item.Coordinates.X + 5 && pbE4.Top <= item.Coordinates.Y + 50 && pbE4.Top >= item.Coordinates.Y) || (pbE4.Left <= item.Coordinates.X + 50 && pbE4.Left >= item.Coordinates.X + 5 && pbE4.Top + 50 <= item.Coordinates.Y + 50 && pbE4.Top + 50 >= item.Coordinates.Y))
                            {
                                pbE4.Left = item.Coordinates.X + 52;
                            }
                            if ((pbE4.Left + 50 >= item.Coordinates.X && pbE4.Left + 5 <= item.Coordinates.X && pbE4.Top <= item.Coordinates.Y + 50 && pbE4.Top >= item.Coordinates.Y) || (pbE4.Left + 50 >= item.Coordinates.X && pbE4.Left + 5 <= item.Coordinates.X && pbE4.Top + 50 <= item.Coordinates.Y + 50 && pbE4.Top + 50 >= item.Coordinates.Y))
                            {
                                pbE4.Left = item.Coordinates.X - 52;
                            }
                            if ((pbE4.Top <= item.Coordinates.Y + 50 && pbE4.Top >= item.Coordinates.Y + 5 && pbE4.Left <= item.Coordinates.X + 50 && pbE4.Left >= item.Coordinates.X) || (pbE4.Top <= item.Coordinates.Y + 50 && pbE4.Top >= item.Coordinates.Y + 5 && pbE4.Left + 50 <= item.Coordinates.X + 50 && pbE4.Left + 50 >= item.Coordinates.X))
                            {
                                pbE4.Top = item.Coordinates.Y + 52;
                            }
                            if ((pbE4.Top + 50 >= item.Coordinates.Y && pbE4.Top + 5 <= item.Coordinates.Y && pbE4.Left <= item.Coordinates.X + 50 && pbE4.Left >= item.Coordinates.X) || (pbE4.Top + 50 >= item.Coordinates.Y && pbE4.Top + 5 <= item.Coordinates.Y && pbE4.Left + 50 <= item.Coordinates.X + 50 && pbE4.Left + 50 >= item.Coordinates.X))
                            {
                                pbE4.Top = item.Coordinates.Y - 52;
                            }
                        }
                    }
                    foreach (var item in container)
                    {
                        if (item.Name == "E4")
                        {
                            item.Coordinates = locationE4;
                        }
                    }
                }
            }
        }
        private void PbE5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (pbE5.Left >= minLeft && pbE5.Top >= 0 && pbE5.Left <= maxLeft && pbE5.Top <= maxTop)
                {
                    pbE5.Left = e.X + pbE5.Left - MouseDownLoaction.X; ;
                    pbE5.Top = e.Y + pbE5.Top - MouseDownLoaction.Y; ;
                    label1.Text = pbE5.Location.ToString();
                    locationE5.X = pbE5.Left;
                    locationE5.Y = pbE5.Top;
                    foreach (MapObjects item in container)
                    {
                        if (item.Name != "E5")
                        {
                            if ((pbE5.Left <= item.Coordinates.X + 50 && pbE5.Left >= item.Coordinates.X + 5 && pbE5.Top <= item.Coordinates.Y + 50 && pbE5.Top >= item.Coordinates.Y) || (pbE5.Left <= item.Coordinates.X + 50 && pbE5.Left >= item.Coordinates.X + 5 && pbE5.Top + 50 <= item.Coordinates.Y + 50 && pbE5.Top + 50 >= item.Coordinates.Y))
                            {
                                pbE5.Left = item.Coordinates.X + 52;
                            }
                            if ((pbE5.Left + 50 >= item.Coordinates.X && pbE5.Left + 5 <= item.Coordinates.X && pbE5.Top <= item.Coordinates.Y + 50 && pbE5.Top >= item.Coordinates.Y) || (pbE5.Left + 50 >= item.Coordinates.X && pbE5.Left + 5 <= item.Coordinates.X && pbE5.Top + 50 <= item.Coordinates.Y + 50 && pbE5.Top + 50 >= item.Coordinates.Y))
                            {
                                pbE5.Left = item.Coordinates.X - 52;
                            }
                            if ((pbE5.Top <= item.Coordinates.Y + 50 && pbE5.Top >= item.Coordinates.Y + 5 && pbE5.Left <= item.Coordinates.X + 50 && pbE5.Left >= item.Coordinates.X) || (pbE5.Top <= item.Coordinates.Y + 50 && pbE5.Top >= item.Coordinates.Y + 5 && pbE5.Left + 50 <= item.Coordinates.X + 50 && pbE5.Left + 50 >= item.Coordinates.X))
                            {
                                pbE5.Top = item.Coordinates.Y + 52;
                            }
                            if ((pbE5.Top + 50 >= item.Coordinates.Y && pbE5.Top + 5 <= item.Coordinates.Y && pbE5.Left <= item.Coordinates.X + 50 && pbE5.Left >= item.Coordinates.X) || (pbE5.Top + 50 >= item.Coordinates.Y && pbE5.Top + 5 <= item.Coordinates.Y && pbE5.Left + 50 <= item.Coordinates.X + 50 && pbE5.Left + 50 >= item.Coordinates.X))
                            {
                                pbE5.Top = item.Coordinates.Y - 52;
                            }
                        }
                    }
                    foreach (var item in container)
                    {
                        if (item.Name == "E5")
                        {
                            item.Coordinates = locationE5;
                        }
                    }
                }
            }
        }
        private void PbE6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (pbE6.Left >= minLeft && pbE6.Top >= 0 && pbE6.Left <= maxLeft && pbE6.Top <= maxTop)
                {
                    pbE6.Left = e.X + pbE6.Left - MouseDownLoaction.X; ;
                    pbE6.Top = e.Y + pbE6.Top - MouseDownLoaction.Y; ;
                    label1.Text = pbE6.Location.ToString();
                    locationE6.X = pbE6.Left;
                    locationE6.Y = pbE6.Top;
                    foreach (MapObjects item in container)
                    {
                        if (item.Name != "E6")
                        {
                            if ((pbE6.Left <= item.Coordinates.X + 50 && pbE6.Left >= item.Coordinates.X + 5 && pbE6.Top <= item.Coordinates.Y + 50 && pbE6.Top >= item.Coordinates.Y) || (pbE6.Left <= item.Coordinates.X + 50 && pbE6.Left >= item.Coordinates.X + 5 && pbE6.Top + 50 <= item.Coordinates.Y + 50 && pbE6.Top + 50 >= item.Coordinates.Y))
                            {
                                pbE6.Left = item.Coordinates.X + 52;
                            }
                            if ((pbE6.Left + 50 >= item.Coordinates.X && pbE6.Left + 5 <= item.Coordinates.X && pbE6.Top <= item.Coordinates.Y + 50 && pbE6.Top >= item.Coordinates.Y) || (pbE6.Left + 50 >= item.Coordinates.X && pbE6.Left + 5 <= item.Coordinates.X && pbE6.Top + 50 <= item.Coordinates.Y + 50 && pbE6.Top + 50 >= item.Coordinates.Y))
                            {
                                pbE1.Left = item.Coordinates.X - 52;
                            }
                            if ((pbE6.Top <= item.Coordinates.Y + 50 && pbE6.Top >= item.Coordinates.Y + 5 && pbE6.Left <= item.Coordinates.X + 50 && pbE6.Left >= item.Coordinates.X) || (pbE6.Top <= item.Coordinates.Y + 50 && pbE6.Top >= item.Coordinates.Y + 5 && pbE6.Left + 50 <= item.Coordinates.X + 50 && pbE6.Left + 50 >= item.Coordinates.X))
                            {
                                pbE6.Top = item.Coordinates.Y + 52;
                            }
                            if ((pbE6.Top + 50 >= item.Coordinates.Y && pbE6.Top + 5 <= item.Coordinates.Y && pbE6.Left <= item.Coordinates.X + 50 && pbE6.Left >= item.Coordinates.X) || (pbE6.Top + 50 >= item.Coordinates.Y && pbE6.Top + 5 <= item.Coordinates.Y && pbE6.Left + 50 <= item.Coordinates.X + 50 && pbE6.Left + 50 >= item.Coordinates.X))
                            {
                                pbE6.Top = item.Coordinates.Y - 52;
                            }
                        }
                    }
                    foreach (var item in container)
                    {
                        if (item.Name == "E6")
                        {
                            item.Coordinates = locationE6;
                        }
                    }
                }
            }
        }

        private void PbE_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLoaction = e.Location;
            }
        }
        #endregion

        #region Other Buttons
        /// <summary>
        /// There are two other buttons with minimal code here
        /// The undo button will remove the most recently added enemy obstruction from the map and list
        /// Start simulation button shows the simulation form as well as randomly generating what is inside the enemy base and storing it in a list from a list populated by the database 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndo_Click(object sender, EventArgs e)
        {

            switch (selectNumber)
            {
                case 1:
                    {
                        this.panel1.Controls.Remove(pbE1);
                        selectNumber--;
                        container.RemoveAt(0);
                    }
                    break;
                case 2:
                    {
                        this.panel1.Controls.Remove(pbE2);
                        selectNumber--;
                        container.RemoveAt(1);
                    }
                    break;
                case 3:
                    {
                        this.panel1.Controls.Remove(pbE3);
                        selectNumber--;
                        container.RemoveAt(2);
                    }
                    break;
                case 4:
                    {
                        this.panel1.Controls.Remove(pbE4);
                        selectNumber--;
                        container.RemoveAt(3);
                    }
                    break;
                case 5:
                    {
                        this.panel1.Controls.Remove(pbE5);
                        selectNumber--;
                        container.RemoveAt(4);
                    }
                    break;
                case 6:
                    {
                        this.panel1.Controls.Remove(pbE6);
                        selectNumber--;
                        container.RemoveAt(5);
                    }
                    break;
                default:
                    {
                        MessageBox.Show("No More Items Left To Undo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simulation sim = new Simulation();
            sim.Show();
            this.Hide();
            Random randomObject = new Random();
            for (int i = 0; i < 6; i++)
            {
                
                int enemyID = randomObject.Next(1,10);
                foreach (EnemyBaseObjects item in enemyObjectsAll)
                {
                    if (item.ID==enemyID)
                    {
                        enemyObjects.Add(item);
                    }
                }
            }
            

            
            foreach (var item in container)
            {
                if (item.Name == "E1")
                {
                    label1.Text = item.Coordinates.ToString();
                }
            }

        }
#endregion
    }
}

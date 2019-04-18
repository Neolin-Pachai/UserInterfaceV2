namespace UserInterfaceV2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlEnemies = new System.Windows.Forms.Panel();
            this.btnE3 = new System.Windows.Forms.Button();
            this.btnE2 = new System.Windows.Forms.Button();
            this.btnE1 = new System.Windows.Forms.Button();
            this.btnEnemy = new System.Windows.Forms.Button();
            this.pnlAeroplanes = new System.Windows.Forms.Panel();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnAeroplane = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAeroplane = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlEnemies.SuspendLayout();
            this.pnlAeroplanes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAeroplane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlEnemies
            // 
            this.pnlEnemies.Controls.Add(this.btnE3);
            this.pnlEnemies.Controls.Add(this.btnE2);
            this.pnlEnemies.Controls.Add(this.btnE1);
            this.pnlEnemies.Controls.Add(this.btnEnemy);
            this.pnlEnemies.Location = new System.Drawing.Point(1024, 22);
            this.pnlEnemies.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEnemies.MaximumSize = new System.Drawing.Size(460, 384);
            this.pnlEnemies.MinimumSize = new System.Drawing.Size(460, 100);
            this.pnlEnemies.Name = "pnlEnemies";
            this.pnlEnemies.Size = new System.Drawing.Size(460, 100);
            this.pnlEnemies.TabIndex = 4;
            // 
            // btnE3
            // 
            this.btnE3.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnE3.FlatAppearance.BorderSize = 0;
            this.btnE3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE3.Location = new System.Drawing.Point(2, 290);
            this.btnE3.Margin = new System.Windows.Forms.Padding(2);
            this.btnE3.Name = "btnE3";
            this.btnE3.Size = new System.Drawing.Size(455, 96);
            this.btnE3.TabIndex = 7;
            this.btnE3.Text = "E3";
            this.btnE3.UseVisualStyleBackColor = false;
            this.btnE3.Click += new System.EventHandler(this.btnE3_Click);
            // 
            // btnE2
            // 
            this.btnE2.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnE2.FlatAppearance.BorderSize = 0;
            this.btnE2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE2.Location = new System.Drawing.Point(2, 194);
            this.btnE2.Margin = new System.Windows.Forms.Padding(2);
            this.btnE2.Name = "btnE2";
            this.btnE2.Size = new System.Drawing.Size(455, 96);
            this.btnE2.TabIndex = 6;
            this.btnE2.Text = "E2";
            this.btnE2.UseVisualStyleBackColor = false;
            this.btnE2.Click += new System.EventHandler(this.btnE2_Click);
            // 
            // btnE1
            // 
            this.btnE1.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnE1.FlatAppearance.BorderSize = 0;
            this.btnE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE1.Location = new System.Drawing.Point(2, 98);
            this.btnE1.Margin = new System.Windows.Forms.Padding(2);
            this.btnE1.Name = "btnE1";
            this.btnE1.Size = new System.Drawing.Size(455, 96);
            this.btnE1.TabIndex = 5;
            this.btnE1.Text = "E1";
            this.btnE1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnE1.UseVisualStyleBackColor = false;
            this.btnE1.Click += new System.EventHandler(this.btnE1_Click);
            // 
            // btnEnemy
            // 
            this.btnEnemy.BackColor = System.Drawing.Color.LightBlue;
            this.btnEnemy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnemy.Font = new System.Drawing.Font("Microsoft YaHei", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnemy.Location = new System.Drawing.Point(2, 2);
            this.btnEnemy.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnemy.Name = "btnEnemy";
            this.btnEnemy.Size = new System.Drawing.Size(455, 96);
            this.btnEnemy.TabIndex = 2;
            this.btnEnemy.Text = "Enemies";
            this.btnEnemy.UseVisualStyleBackColor = false;
            this.btnEnemy.Click += new System.EventHandler(this.btnEnemy_Click);
            // 
            // pnlAeroplanes
            // 
            this.pnlAeroplanes.Controls.Add(this.btnA3);
            this.pnlAeroplanes.Controls.Add(this.btnA2);
            this.pnlAeroplanes.Controls.Add(this.btnA1);
            this.pnlAeroplanes.Controls.Add(this.btnAeroplane);
            this.pnlAeroplanes.Location = new System.Drawing.Point(537, 25);
            this.pnlAeroplanes.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAeroplanes.MaximumSize = new System.Drawing.Size(460, 373);
            this.pnlAeroplanes.MinimumSize = new System.Drawing.Size(460, 100);
            this.pnlAeroplanes.Name = "pnlAeroplanes";
            this.pnlAeroplanes.Size = new System.Drawing.Size(460, 100);
            this.pnlAeroplanes.TabIndex = 3;
            // 
            // btnA3
            // 
            this.btnA3.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnA3.FlatAppearance.BorderSize = 0;
            this.btnA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA3.Image = global::UserInterfaceV2.Resource1.P3;
            this.btnA3.Location = new System.Drawing.Point(2, 288);
            this.btnA3.Margin = new System.Windows.Forms.Padding(2);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(455, 83);
            this.btnA3.TabIndex = 4;
            this.btnA3.Text = "A3";
            this.btnA3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnA3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnA3.UseVisualStyleBackColor = false;
            this.btnA3.Click += new System.EventHandler(this.btnA3_Click);
            // 
            // btnA2
            // 
            this.btnA2.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnA2.FlatAppearance.BorderSize = 0;
            this.btnA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA2.Image = global::UserInterfaceV2.Resource1.P2;
            this.btnA2.Location = new System.Drawing.Point(2, 192);
            this.btnA2.Margin = new System.Windows.Forms.Padding(2);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(455, 96);
            this.btnA2.TabIndex = 3;
            this.btnA2.Text = "A2";
            this.btnA2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnA2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnA2.UseVisualStyleBackColor = false;
            this.btnA2.Click += new System.EventHandler(this.btnA2_Click);
            // 
            // btnA1
            // 
            this.btnA1.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnA1.FlatAppearance.BorderSize = 0;
            this.btnA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA1.Image = global::UserInterfaceV2.Resource1.P1;
            this.btnA1.Location = new System.Drawing.Point(2, 98);
            this.btnA1.Margin = new System.Windows.Forms.Padding(2);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(455, 96);
            this.btnA1.TabIndex = 2;
            this.btnA1.Text = "A1";
            this.btnA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnA1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnA1.UseVisualStyleBackColor = false;
            this.btnA1.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnAeroplane
            // 
            this.btnAeroplane.BackColor = System.Drawing.Color.LightBlue;
            this.btnAeroplane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAeroplane.Font = new System.Drawing.Font("Microsoft YaHei", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAeroplane.Location = new System.Drawing.Point(2, 0);
            this.btnAeroplane.Margin = new System.Windows.Forms.Padding(2);
            this.btnAeroplane.Name = "btnAeroplane";
            this.btnAeroplane.Size = new System.Drawing.Size(455, 96);
            this.btnAeroplane.TabIndex = 1;
            this.btnAeroplane.Text = "Aeroplanes";
            this.btnAeroplane.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAeroplane.UseVisualStyleBackColor = false;
            this.btnAeroplane.Click += new System.EventHandler(this.btnAeroplane_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1565, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(1804, 62);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(143, 52);
            this.btnUndo.TabIndex = 7;
            this.btnUndo.Text = "UNDO";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UserInterfaceV2.Resource1.h_36_034_4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pbAeroplane);
            this.panel1.Location = new System.Drawing.Point(5, 210);
            this.panel1.Margin = new System.Windows.Forms.Padding(7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2077, 866);
            this.panel1.TabIndex = 5;
            // 
            // pbAeroplane
            // 
            this.pbAeroplane.BackColor = System.Drawing.Color.Transparent;
            this.pbAeroplane.Location = new System.Drawing.Point(1932, 395);
            this.pbAeroplane.Margin = new System.Windows.Forms.Padding(7);
            this.pbAeroplane.Name = "pbAeroplane";
            this.pbAeroplane.Size = new System.Drawing.Size(70, 67);
            this.pbAeroplane.TabIndex = 0;
            this.pbAeroplane.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 81);
            this.button1.TabIndex = 8;
            this.button1.Text = "START SIMULATION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 402);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2093, 1102);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAeroplanes);
            this.Controls.Add(this.pnlEnemies);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1262, 748);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlEnemies.ResumeLayout(false);
            this.pnlAeroplanes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAeroplane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlEnemies;
        private System.Windows.Forms.Button btnE3;
        private System.Windows.Forms.Button btnE2;
        private System.Windows.Forms.Button btnE1;
        private System.Windows.Forms.Panel pnlAeroplanes;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnAeroplane;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnEnemy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAeroplane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


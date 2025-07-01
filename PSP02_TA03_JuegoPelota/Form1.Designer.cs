namespace PSP02_JuegoPelota
{
    partial class JuegoPelota
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoPelota));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picturepelomano = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picturepelotapie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturepelomano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturepelotapie)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 639);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(540, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 639);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // picturepelomano
            // 
            this.picturepelomano.Image = ((System.Drawing.Image)(resources.GetObject("picturepelomano.Image")));
            this.picturepelomano.Location = new System.Drawing.Point(257, 171);
            this.picturepelomano.Name = "picturepelomano";
            this.picturepelomano.Size = new System.Drawing.Size(100, 89);
            this.picturepelomano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturepelomano.TabIndex = 2;
            this.picturepelomano.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Empezar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picturepelotapie
            // 
            this.picturepelotapie.Image = ((System.Drawing.Image)(resources.GetObject("picturepelotapie.Image")));
            this.picturepelotapie.Location = new System.Drawing.Point(434, 582);
            this.picturepelotapie.Name = "picturepelotapie";
            this.picturepelotapie.Size = new System.Drawing.Size(100, 89);
            this.picturepelotapie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturepelotapie.TabIndex = 4;
            this.picturepelotapie.TabStop = false;
            // 
            // JuegoPelota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 766);
            this.Controls.Add(this.picturepelotapie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picturepelomano);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "JuegoPelota";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.JuegoPelota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturepelomano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturepelotapie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            t1 = new Thread(this.PasePelota);
            t2 = new Thread(this.DevolverPelota);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox picturepelomano;
        private Button button1;
        private PictureBox picturepelotapie;
        private Thread t1;
        private Thread t2;
    }
}
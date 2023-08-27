namespace TaTeTiFIN
{
    partial class Tablero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablero));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TABLERO";
            // 
            // button1
            // 
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 129);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(184, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 129);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(362, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 129);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(6, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 129);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(184, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 129);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(362, 154);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 129);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(6, 289);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 129);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(184, 289);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(172, 129);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.ImageList = this.imageList1;
            this.button9.Location = new System.Drawing.Point(362, 289);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(172, 129);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(610, 211);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(75, 39);
            this.btnFin.TabIndex = 1;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "X.png");
            this.imageList1.Images.SetKeyName(1, "O.png");
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tablero";
            this.Text = "Tablero";
            this.Load += new System.EventHandler(this.Tablero_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFin;
        public System.Windows.Forms.ImageList imageList1;
    }
}
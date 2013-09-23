namespace Paint
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
            this.Pencil_Btn = new System.Windows.Forms.Button();
            this.Brush_Btn = new System.Windows.Forms.Button();
            this.Eraser_Btn = new System.Windows.Forms.Button();
            this.LineLv2_Btn = new System.Windows.Forms.Button();
            this.LineLv3_Btn = new System.Windows.Forms.Button();
            this.LineLv4_Btn = new System.Windows.Forms.Button();
            this.Rectangle_Btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorDialog_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pencil_Btn
            // 
            this.Pencil_Btn.Location = new System.Drawing.Point(12, 12);
            this.Pencil_Btn.Name = "Pencil_Btn";
            this.Pencil_Btn.Size = new System.Drawing.Size(75, 23);
            this.Pencil_Btn.TabIndex = 0;
            this.Pencil_Btn.Text = "Pencil";
            this.Pencil_Btn.UseVisualStyleBackColor = true;
            this.Pencil_Btn.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // Brush_Btn
            // 
            this.Brush_Btn.Location = new System.Drawing.Point(12, 41);
            this.Brush_Btn.Name = "Brush_Btn";
            this.Brush_Btn.Size = new System.Drawing.Size(75, 23);
            this.Brush_Btn.TabIndex = 1;
            this.Brush_Btn.Text = "Brush";
            this.Brush_Btn.UseVisualStyleBackColor = true;
            this.Brush_Btn.Click += new System.EventHandler(this.Brush_Btn_Click);
            // 
            // Eraser_Btn
            // 
            this.Eraser_Btn.Location = new System.Drawing.Point(13, 71);
            this.Eraser_Btn.Name = "Eraser_Btn";
            this.Eraser_Btn.Size = new System.Drawing.Size(75, 23);
            this.Eraser_Btn.TabIndex = 2;
            this.Eraser_Btn.Text = "Eraser";
            this.Eraser_Btn.UseVisualStyleBackColor = true;
            this.Eraser_Btn.Click += new System.EventHandler(this.Eraser_Btn_Click);
            // 
            // LineLv2_Btn
            // 
            this.LineLv2_Btn.Location = new System.Drawing.Point(13, 101);
            this.LineLv2_Btn.Name = "LineLv2_Btn";
            this.LineLv2_Btn.Size = new System.Drawing.Size(75, 23);
            this.LineLv2_Btn.TabIndex = 3;
            this.LineLv2_Btn.Text = "LineLv2";
            this.LineLv2_Btn.UseVisualStyleBackColor = true;
            this.LineLv2_Btn.Click += new System.EventHandler(this.LineLv2_Btn_Click);
            // 
            // LineLv3_Btn
            // 
            this.LineLv3_Btn.Location = new System.Drawing.Point(12, 131);
            this.LineLv3_Btn.Name = "LineLv3_Btn";
            this.LineLv3_Btn.Size = new System.Drawing.Size(75, 23);
            this.LineLv3_Btn.TabIndex = 4;
            this.LineLv3_Btn.Text = "LineLv3";
            this.LineLv3_Btn.UseVisualStyleBackColor = true;
            this.LineLv3_Btn.Click += new System.EventHandler(this.LineLv3_Btn_Click);
            // 
            // LineLv4_Btn
            // 
            this.LineLv4_Btn.Location = new System.Drawing.Point(12, 161);
            this.LineLv4_Btn.Name = "LineLv4_Btn";
            this.LineLv4_Btn.Size = new System.Drawing.Size(75, 23);
            this.LineLv4_Btn.TabIndex = 5;
            this.LineLv4_Btn.Text = "LineLv4";
            this.LineLv4_Btn.UseVisualStyleBackColor = true;
            this.LineLv4_Btn.Click += new System.EventHandler(this.LineLv4_Btn_Click);
            // 
            // Rectangle_Btn
            // 
            this.Rectangle_Btn.Location = new System.Drawing.Point(12, 191);
            this.Rectangle_Btn.Name = "Rectangle_Btn";
            this.Rectangle_Btn.Size = new System.Drawing.Size(75, 23);
            this.Rectangle_Btn.TabIndex = 6;
            this.Rectangle_Btn.Text = "Rectangle";
            this.Rectangle_Btn.UseVisualStyleBackColor = true;
            this.Rectangle_Btn.Click += new System.EventHandler(this.Rectangle_Btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ColorDialog_Btn
            // 
            this.ColorDialog_Btn.Location = new System.Drawing.Point(12, 221);
            this.ColorDialog_Btn.Name = "ColorDialog_Btn";
            this.ColorDialog_Btn.Size = new System.Drawing.Size(75, 23);
            this.ColorDialog_Btn.TabIndex = 7;
            this.ColorDialog_Btn.Text = "ColorDialog";
            this.ColorDialog_Btn.UseVisualStyleBackColor = true;
            this.ColorDialog_Btn.Click += new System.EventHandler(this.ColorDialog_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 499);
            this.Controls.Add(this.ColorDialog_Btn);
            this.Controls.Add(this.Rectangle_Btn);
            this.Controls.Add(this.LineLv4_Btn);
            this.Controls.Add(this.LineLv3_Btn);
            this.Controls.Add(this.LineLv2_Btn);
            this.Controls.Add(this.Eraser_Btn);
            this.Controls.Add(this.Brush_Btn);
            this.Controls.Add(this.Pencil_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Pencil_Btn;
        private System.Windows.Forms.Button Brush_Btn;
        private System.Windows.Forms.Button Eraser_Btn;
        private System.Windows.Forms.Button LineLv2_Btn;
        private System.Windows.Forms.Button LineLv3_Btn;
        private System.Windows.Forms.Button LineLv4_Btn;
        private System.Windows.Forms.Button Rectangle_Btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ColorDialog_Btn;


    }
}


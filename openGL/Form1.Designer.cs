namespace openGL
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.anT = new Tao.Platform.Windows.SimpleOpenGlControl();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// anT
			// 
			this.anT.AccumBits = ((byte)(0));
			this.anT.AutoCheckErrors = false;
			this.anT.AutoFinish = false;
			this.anT.AutoMakeCurrent = true;
			this.anT.AutoSwapBuffers = true;
			this.anT.BackColor = System.Drawing.Color.Black;
			this.anT.ColorBits = ((byte)(32));
			this.anT.DepthBits = ((byte)(16));
			this.anT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.anT.Location = new System.Drawing.Point(0, 0);
			this.anT.Name = "anT";
			this.anT.Size = new System.Drawing.Size(541, 450);
			this.anT.StencilBits = ((byte)(0));
			this.anT.TabIndex = 0;
			this.anT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anT_KeyPress);
			this.anT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anT_KeyUp);
			this.anT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.anT_MouseUp);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 450);
			this.Controls.Add(this.anT);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl anT;
        private System.Windows.Forms.Timer timer1;
    }
}


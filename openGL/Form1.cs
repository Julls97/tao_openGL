using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Tao.OpenGl; 
using Tao.FreeGlut; 
using Tao.Platform.Windows;

namespace openGL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            anT.InitializeContexts();
            InitGL();
            ResizeGLScene();
            DrawGLScene();
        }

        private void InitGL()
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
        }

        /*
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //// инициализация Glut 
        //Glut.glutInit();
        //Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
        //// отчитка окна 
        //Gl.glClearColor(255, 255, 255, 1);
        //// установка порта вывода в соответствии с размерами элемента anT 
        //Gl.glViewport(0, 0, anT.Width, anT.Height);
        //// настройка проекции 
        //Gl.glMatrixMode(Gl.GL_PROJECTION);
        //Gl.glLoadIdentity();
        //Glu.gluPerspective(45, (float)anT.Width / (float)anT.Height, 0.1, 200);
        //Gl.glMatrixMode(Gl.GL_MODELVIEW);
        //Gl.glLoadIdentity();
        //// настройка параметров OpenGL для визуализации 
        //Gl.glEnable(Gl.GL_DEPTH_TEST);
        // }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
        //    Gl.glLoadIdentity();
        //    Gl.glColor3f(1.0f, 0, 0);
        //    Gl.glPushMatrix();
        //    Gl.glTranslated(0, 0, -6);
        //    Gl.glRotated(45, 1, 1, 0);

        //    // рисуем сферу с помощью библиотеки FreeGLUT 
        //    Glut.glutWireSphere(2, 32, 32);
        //    Gl.glPopMatrix();
        //    Gl.glFlush();
        //    simpleOpenGlControl1.Invalidate();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        //{
        //устанвливем в черный цвет 

        //Tao.OpenGl.Gl.glClearColor(0, 0, 0, 0);

        //сообщаем что нужно очистить два буфера 

        //Tao.OpenGl.Gl.glClear(

        //Tao.OpenGl.Gl.GL_COLOR_BUFFER_BIT | //очистка буфера цвета

        //Tao.OpenGl.Gl.GL_DEPTH_BUFFER_BIT //очистка буфера глубины

        //);

        //перерисовываем окно

        //anT.Invalidate();
        // }
        */

        private void ResizeGLScene()
        {
            if (anT.Height == 0)
            {
                anT.Height = 1;
            }

            Gl.glViewport(0, 0, anT.Width, anT.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45.0f, (float)anT.Width / (float)anT.Height, 0.1f, 200.0f);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        private void DrawGLScene()
        {
            Gl.glClearColor(1, 1, 1, 1.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();

            //Gl.glColor3f(0.5f, 0, 1);
            Gl.glColor3f(0.6549f, 0.3765f, 0.4196f);
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -6);

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glVertex3f(1.0f, 1.0f, 0.0f);
            Gl.glVertex3f(-1.0f, 1.0f, 0.0f);
            Gl.glVertex3f(-1.0f, -1.0f, 0.0f);
            Gl.glVertex3f(1.0f, -1.0f, 0.0f);
            Gl.glEnd();

            Gl.glPopMatrix();
            Gl.glFlush();
            anT.Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeGLScene();
            DrawGLScene();
        }

        private void anT_KeyUp(object sender, KeyEventArgs e)
        {
            // Нажата клавиша ЕSCAPE; 
            if (e.KeyCode == Keys.Escape) {
                // Завершим приложение; 
                this.Close();
            }
            
        }
    }
}

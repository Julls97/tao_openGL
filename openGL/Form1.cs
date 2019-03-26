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

namespace openGL {
	public partial class Form1 : Form {
		static float rotZ = 0.0f;
		static float X = 0.0f;       
		static float Y = 0.0f;       

		public Form1() {
			InitializeComponent();
			anT.InitializeContexts();
			InitGL();
			ResizeGLScene();
			DrawGLScene();
		}

		private void InitGL() {
			Glut.glutInit();
			Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
		}

		private void ResizeGLScene() {
			if (anT.Height == 0) {
				anT.Height = 1;
			}

			Gl.glViewport(0, 0, anT.Width, anT.Height);
			Gl.glMatrixMode(Gl.GL_PROJECTION);
			Gl.glLoadIdentity();
			Glu.gluPerspective(45.0f, (float)anT.Width / (float)anT.Height, 0.1f, 200.0f);
			Gl.glMatrixMode(Gl.GL_MODELVIEW);
		}

		private void DrawGLScene() {
			Gl.glClearColor(1, 1, 1, 1.0f);
			Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
			Gl.glLoadIdentity();

			Gl.glPushMatrix();
			Gl.glTranslated(0, 0, -4);

			Gl.glColor3f(0.25f, 0.87f, 0.81f);
			Gl.glBegin(Gl.GL_QUADS);
			Gl.glVertex2f(X + 1.6f, Y + 1.6f);
			Gl.glVertex2f(X + 1.1f, Y + 1.6f);
			Gl.glVertex2f(X + 1.1f, Y + 1.1f);
			Gl.glVertex2f(X + 1.6f, Y + 1.1f);
			Gl.glEnd();

			Gl.glColor3f(0.6549f, 0.3765f, 0.4196f);
			Gl.glRotatef(rotZ, 0.0f, 0.0f, 1.0f);
			Gl.glBegin(Gl.GL_QUADS);
			Gl.glVertex2f(1.0f, 1.0f);
			Gl.glVertex2f(-1.0f, 1.0f);
			Gl.glVertex2f(-1.0f, -1.0f);
			Gl.glVertex2f(1.0f, -1.0f);
			Gl.glEnd();

			Gl.glPopMatrix();
			Gl.glFlush();
			anT.Invalidate();
		}

		private void Form1_Resize(object sender, EventArgs e) {
			ResizeGLScene();
			DrawGLScene();
		}

		private void anT_KeyUp(object sender, KeyEventArgs e) {
			
			// Нажата клавиша ЕSCAPE; 
			if (e.KeyCode == Keys.Escape) {
				// Завершим приложение; 
				this.Close();
			}

			// Нажата клавиша right квадрат вращается; 
			if (e.KeyCode == Keys.Right) {
				timer1.Start();
			}

			// Нажата клавиша left вращение прекращается;
			if (e.KeyCode == Keys.Left) {
				timer1.Stop();
			}
		}

		private void timer1_Tick(object sender, EventArgs e) {
			rotZ -= 1.0f;
			DrawGLScene();
		}

		private void anT_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == 'A' || e.KeyChar == 'a') {
				X -= 0.1f;
			}

			if (e.KeyChar == 'D' || e.KeyChar == 'd') {
				X += 0.1f;
			}

			if (e.KeyChar == 'S' || e.KeyChar == 's') {
				Y -= 0.1f;
			}

			if (e.KeyChar == 'W' || e.KeyChar == 'w') {
				Y += 0.1f;
			}

			DrawGLScene();
		}
	}
}

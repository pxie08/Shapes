/****************************
** q506.cs
** Pretty Pretty Shapes
** Patrick Xie, 5/06/2011
****************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShapeClasses
{
    public partial class q506 : Form
    {
        private Bitmap myCanvas;
        private Color currentColor = Color.Red;
        private ShapeList currentShapeList = new ShapeList();
        private bool isCreating = false;
        private bool isMoving = false;
        private bool isDeleting = false;
        private bool isSendingBack = false;
        private bool isBringingFront = false;
        private Point lastLocation;
        int currentShapeIndex = -1;

        public q506()
        {
            InitializeComponent();
            ColorPanel.BackColor = currentColor;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
                ColorPanel.BackColor = currentColor;
            }
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "Draw a rectangle.";
            currentShapeList.AddShape(new Rectangle10C(currentColor));
            isCreating = true;
            isMoving = false;
            currentShapeIndex = currentShapeList.Size() - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myCanvas = new Bitmap(DrawingPanel.Width, DrawingPanel.Height, 
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(myCanvas);
            g.Clear(Color.White);
            g.Dispose();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            currentShapeList.DrawAll(Graphics.FromImage(myCanvas));
            Graphics g = e.Graphics;
            g.DrawImage(myCanvas, 0, 0, myCanvas.Width, myCanvas.Height);
            g.Dispose();
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (isCreating)
                currentShapeList.GetShapeAt(currentShapeIndex).MouseDownCreating(e.Location, DrawingPanel.CreateGraphics());
            else if (isDeleting)
            {
                currentShapeList.DeleteShape(e.Location);
                isDeleting = false;
                MessageLabel.Text = "Shape deleted.";
            }
            else if (isSendingBack)
            {
                currentShapeList.SendToBack(e.Location);
                isSendingBack = false;
                MessageLabel.Text = "Sent to back.";
            }
            else if (isBringingFront)
            {
                currentShapeList.BringToFront(e.Location);
                isBringingFront = false;
                MessageLabel.Text = "Brought to front.";
            }
            else if (currentShapeList.AnyShapeClicked(e.Location))
            {
                currentShapeIndex = currentShapeList.GetShapeIndex(e.Location);
                lastLocation = e.Location;
                isMoving = true;
            }
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isCreating)
            {
                currentShapeList.GetShapeAt(currentShapeIndex).MouseMoveCreating(e.Location, DrawingPanel.CreateGraphics());
                DrawingPanel.Refresh();
            }
            else if (isMoving)
            {
                int dx = e.Location.X - lastLocation.X;
                int dy = e.Location.Y - lastLocation.Y;
                currentShapeList.GetShapeAt(currentShapeIndex).Move(dx, dy);
                lastLocation = e.Location;
                DrawingPanel.Refresh();
            }
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (isCreating)
            {
                isCreating = false;
                MessageLabel.Text = "Shape creation complete.";
                currentShapeIndex = -1;
            }
            if (isMoving)
            {
                isMoving = false;
                MessageLabel.Text = "Shape movement complete.";
                currentShapeIndex = -1;
            }
            DrawingPanel.Refresh();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            isDeleting = true;
            MessageLabel.Text = "Select shape to delete.";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            isSendingBack = true;

        }

        private void FrontButton_Click(object sender, EventArgs e)
        {
            isBringingFront = true;
        }

        private void AddLineButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "Draw a line.";
            currentShapeList.AddShape(new Line10C(currentColor));
            isCreating = true;
            isMoving = false;
            currentShapeIndex = currentShapeList.Size() - 1;
        }

        private void AddEllipseButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "Draw an ellipse.";
            currentShapeList.AddShape(new Ellipse10C(currentColor));
            isCreating = true;
            isMoving = false;
            currentShapeIndex = currentShapeList.Size() - 1;
        }

    }
}
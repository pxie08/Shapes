/****************************
** Shape.cs
** Pretty Pretty Shapes
** Patrick Xie, 5/06/2011
****************************/
using System;
using System.Collections.Generic;
using System.Text;
//Extra libraries I added.
using System.Drawing;
using System.Drawing.Drawing2D;


namespace ShapeClasses
{
    /******************************************************/
    /* Shape10C -- General base class for PIC 10C shapes. */
    public abstract class Shape10C
    {
        protected Color shapeColor;
        public bool isVisible = false;  //Sometimes we want to hide shapes.
        
        public abstract void Move(int dx, int dy);
        public abstract void Draw(Graphics g);
        public abstract bool IsPointInside(Point p);
        public abstract void MouseDownCreating(Point p, Graphics g);
        public abstract void MouseMoveCreating(Point p, Graphics g);
        
        public Color Get_color()
        {
            return shapeColor;
        }

        public void Set_color(Color c)
        {
            shapeColor = c;
        }
    }  //end Shape10C class

    /*******************************************/
    /* Rectangle10C -- PIC 10C Rectangle class */
    public class Rectangle10C : Shape10C
    {
        protected Point upperLeftCorner;
        protected int width;
        protected int height;

        public Rectangle10C()
        {
            isVisible = false;
            shapeColor = Color.White;
            upperLeftCorner = new Point(0, 0);
            width = 0;
            height = 0;
        }

        public Rectangle10C(Color c)
        {
            isVisible = false;
            shapeColor = c;
            upperLeftCorner = new Point(0, 0);
            width = 0;
            height = 0;
        }

        public Rectangle10C(Color c, Point p, int w, int h)
        {
            isVisible = true;
            shapeColor = c;
            upperLeftCorner = p;
            width = w;
            height = h;
        }

        public override void Move(int dx, int dy) {
            upperLeftCorner.X += dx;
            upperLeftCorner.Y += dy;
        }

        public override void Draw(Graphics g)
        {
            SolidBrush myBrush = new SolidBrush(shapeColor);
            g.FillRectangle(myBrush, upperLeftCorner.X, upperLeftCorner.Y, width, height);
        }

        public override bool IsPointInside(Point p)
        {
            return (p.X >= upperLeftCorner.X && p.Y >= upperLeftCorner.Y
                && p.X <= upperLeftCorner.X + width && p.Y <= upperLeftCorner.Y + height);
        }

        public override void MouseDownCreating(Point p, Graphics g)
        {
            isVisible = true;
            upperLeftCorner = p;
        }

        public override void MouseMoveCreating(Point p, Graphics g)
        {
            width = p.X - upperLeftCorner.X;
            height = p.Y - upperLeftCorner.Y;
        }
    } //end Rectangle10C class


    /*******************************************/
    /* Line10C -- PIC 10C Line class */
    public class Line10C : Shape10C
    {
        //initial point of the line
        protected Point firstPoint;
        //final point of the line coord's
        protected int xPoint;
        protected int yPoint;

        public Line10C()
        {
            isVisible = false;
            shapeColor = Color.White;
            firstPoint = new Point(0, 0);
            xPoint = 0;
            yPoint = 0;
        }

        public Line10C(Color c)
        {
            isVisible = false;
            shapeColor = c;
            firstPoint = new Point(0, 0);
            xPoint = 0;
            yPoint = 0;
        }

        public Line10C(Color c, Point p, int xP, int yP)
        {
            isVisible = true;
            shapeColor = c;
            firstPoint = p;
            xPoint = xP;
            yPoint = yP;
        }

        public override void Move(int dx, int dy)
        {
            firstPoint.X += dx;
            firstPoint.Y += dy;
            xPoint += dx;
            yPoint += dy;
        }

        public override void Draw(Graphics g)
        {
            Pen myPen = new Pen(shapeColor, 10);
            g.DrawLine(myPen, firstPoint.X, firstPoint.Y, xPoint, yPoint);
        }

        public override bool IsPointInside(Point p)
        {
            double t;
            double dis = 0;
            t = ((p.X - firstPoint.X)*(xPoint-firstPoint.X) + (p.Y - firstPoint.Y)*(yPoint-firstPoint.Y)) / 
                (Math.Pow(xPoint-firstPoint.X, 2) + Math.Pow(yPoint - firstPoint.Y, 2));
            if(t <= 0)
            {
                dis = Math.Sqrt(Math.Pow(p.X - firstPoint.X, 2) + Math.Pow(p.Y - firstPoint.Y, 2));
            }
            if(t > 0 && t < 1)
            {
                dis = Math.Sqrt(Math.Pow(p.X - firstPoint.X - t*xPoint + t*firstPoint.X, 2) + 
                    Math.Pow(p.Y - firstPoint.Y - t*yPoint + t*firstPoint.Y, 2));
            }
            if ( t >= 1)
            {
                dis = Math.Sqrt(Math.Pow(p.X - xPoint, 2) + Math.Pow(p.Y - yPoint, 2));
            }
            return (t > 0 && t < 1 && dis < 5);
        }

        public override void MouseDownCreating(Point p, Graphics g)
        {
            isVisible = true;
            firstPoint = p;
        }

        public override void MouseMoveCreating(Point p, Graphics g)
        {
            xPoint = p.X;
            yPoint = p.Y;
        }
    } //end Line10C class

    /*******************************************/
    /* Ellipse10C -- PIC 10C Ellipse class */
    public class Ellipse10C : Shape10C
    {
        protected Point upperLeftCorner;
        protected int width;
        protected int height;

        public Ellipse10C()
        {
            isVisible = false;
            shapeColor = Color.White;
            upperLeftCorner = new Point(0, 0);
            width = 0;
            height = 0;
        }

        public Ellipse10C(Color c)
        {
            isVisible = false;
            shapeColor = c;
            upperLeftCorner = new Point(0, 0);
            width = 0;
            height = 0;
        }

        public Ellipse10C(Color c, Point p, int w, int h)
        {
            isVisible = true;
            shapeColor = c;
            upperLeftCorner = p;
            width = w;
            height = h;
        }

        public override void Move(int dx, int dy)
        {
            upperLeftCorner.X += dx;
            upperLeftCorner.Y += dy;
        }

        public override void Draw(Graphics g)
        {
            SolidBrush myBrush = new SolidBrush(shapeColor);
            g.FillEllipse(myBrush, upperLeftCorner.X, upperLeftCorner.Y, width, height);
        }

        public override bool IsPointInside(Point p)
        {
            //half the width and heights are a,b
            double a = width / 2;
            double b = height / 2;
            //general equation of ellipse to see if point is inside
            return (((Math.Pow(p.X - (upperLeftCorner.X + a), 2) / Math.Pow(a, 2)) + (Math.Pow(p.Y - (upperLeftCorner.Y + b), 2) / Math.Pow(b, 2))) < 1);
        }

        public override void MouseDownCreating(Point p, Graphics g)
        {
            isVisible = true;
            upperLeftCorner = p;
        }

        public override void MouseMoveCreating(Point p, Graphics g)
        {
            width = p.X - upperLeftCorner.X;
            height = p.Y - upperLeftCorner.Y;
        }
    } //end Ellipse10C class
}

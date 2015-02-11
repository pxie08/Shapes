using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapeClasses
{
    public class ShapeList
    {
        //Shapes are stored in List called myList.
        //myList[0] is drawn first, then myList[1], and so on.
        //So we expect the last Shape in myList to be drawn on top.
        private List<Shape10C> myList;
        public Color BackColor = Color.White;

        public ShapeList()
        {
            myList = new List<Shape10C>();
        }

        public void DrawAll(Graphics g)
        {
            g.Clear(BackColor);
            foreach (Shape10C s in myList)
                if (s.isVisible)
                    s.Draw(g);
        }

        public int GetShapeIndex(Point p)
        {
            //Locate which Shape contains the point.
            //We search the shapes on top first, so we move backwards through list.
            for (int i = myList.Count - 1; i >= 0; i--)
                if (myList[i].isVisible && myList[i].IsPointInside(p))
                    return i;
            return -1;  //Return -1 if shape not found.
        }

        public bool AnyShapeClicked(Point p)
        {
            if (GetShapeIndex(p) >= 0)
                return true;
            return false;
        }

        public void DeleteShape(Point p)
        {
            if (AnyShapeClicked(p))
                myList.RemoveAt(GetShapeIndex(p));
        }

        public void AddShape(Shape10C s)
        {
            myList.Add(s);
        }

        public void SendToBack(Point p)
        {
            int shapeIndex = GetShapeIndex(p);
            if (shapeIndex >= 0 && myList.Count > 1)
            {
                Shape10C temp = myList[shapeIndex];
                for (int i = shapeIndex; i >= 1; i--)
                    myList[i] = myList[i - 1];
                myList[0] = temp;
            }
        }

        public void BringToFront(Point p)
        {
            int shapeIndex = GetShapeIndex(p);
            if (shapeIndex >= 0 && myList.Count > 1)
            {
                myList.Add(myList[shapeIndex]);
                myList.RemoveAt(shapeIndex);
            }
        }

        public int Size()
        {
            return myList.Count;
        }

        public Shape10C GetShapeAt(int i)
        {
            return myList[i];
        }
    }  //end ShapeList class
}

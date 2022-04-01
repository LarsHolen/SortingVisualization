using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SortingVisualization
{
    /// <summary>
    /// This class takes a picturebox and an int array as parameters
    /// And draws a bitmap into the picturebox.  White background and
    /// black pixels at x(int array position), y(int array value at 
    /// position).  
    /// </summary>
    public class DrawIntArray
    {
        private int[] intArray;
        private PictureBox pictureBox;
        private Bitmap bitmap;
        private Graphics gfxObj;

        private Pen blackPen = new Pen(Color.Black, 1);

        public bool DrawLine { get; set; }

        /// <summary>
        /// Constructor
        /// Takes a picturebox and the int array
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="iA"></param>
        public DrawIntArray(PictureBox pb, int[] iA )
        {
            DrawLine = true;
            intArray = iA;
            pictureBox = pb;
            if (intArray.Length > pictureBox.Width) pictureBox.Width = intArray.Length;
            if (GetMaxValue() > pictureBox.Height) pictureBox.Height = GetMaxValue();

            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        }

        /// <summary>
        /// Redraw the image from the int[] param
        /// </summary>
        /// <param name="iA"></param>
        public void Draw(int[] iA)
        {
            // Testing if the array have the same length, if not throw exception.
            if (iA.Length != intArray.Length) throw new ArgumentOutOfRangeException(nameof(iA), "Array must be of the same length");

            //  Set the new array and clear the bitmap to a blank/white
            intArray = iA;
            gfxObj = Graphics.FromImage(bitmap);
            gfxObj.Clear(Color.White);

            // draw black points where i=x and y=intArray[i]
            for (int i = 0; i < pictureBox.Width; i++)
            {
                // Check that the values are within the pictureBox, if out of image skip them
                if (intArray[i] < 0) continue;
                if (intArray[i] > pictureBox.Height) continue;
                //Debug.WriteLine(Math.Abs(intArray[i] - pictureBox.Height));
                int y = Math.Abs(intArray[i] - pictureBox.Height) ;
                if(!DrawLine) bitmap.SetPixel(i, y-1, Color.Black);
                if(DrawLine) gfxObj.DrawLine(blackPen, new Point(i, pictureBox.Height), new Point(i, y - 1));
                
            }

            // Add the new image to the pictureBox
            pictureBox.Image = bitmap;
        }

        /// <summary>
        /// Returns the highest value of the intArray.
        /// </summary>
        /// <returns></returns>
        private int GetMaxValue()
        {
            int maxVal = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal) maxVal = intArray[i];
            }
            return maxVal;
        }
    }
}

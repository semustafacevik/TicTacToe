using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Drawing
    {
        Graphics graphic;

        public Drawing(Graphics graphic)
        {
            this.graphic = graphic;
            createCanvas();
        }

        public void createCanvas()
        {
            Pen pen = new Pen(Color.Black, 5);

            graphic.DrawLine(pen, new Point(100, 0), new Point(100, 300));
            graphic.DrawLine(pen, new Point(200, 0), new Point(200, 300));
        
            graphic.DrawLine(pen, new Point(0, 100), new Point(300, 100));
            graphic.DrawLine(pen, new Point(0, 200), new Point(300, 200));
        }
    }
}

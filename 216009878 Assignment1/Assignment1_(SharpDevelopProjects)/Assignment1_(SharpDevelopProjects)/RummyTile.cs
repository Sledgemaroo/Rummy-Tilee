													//216001213 MUDAU R.A
													//212013629 JONKER WD

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment1__SharpDevelopProjects_
{
	/// <summary>
	/// Description of RummyTile.
	/// </summary>
	public class RummyTile
	{
		int _n;
		Color _clr;
		
	    public RummyTile(int number, string colour)
	    {
	        _n = number;
	        _clr = Color.FromName(colour);
	    }
	
	    public RummyTile(RummyTile RT)
	    {
	        _n = RT._n;
	        _clr = RT._clr;
	    }
	
	    public Bitmap DrawFace(int sizeX, int sizeY)
	    {
	        Bitmap tileFace = new Bitmap(sizeX, sizeY);
	
	        using (Graphics gr = Graphics.FromImage(tileFace))
	        {
	            using (Brush faceBrush = new SolidBrush(Color.LightGray))
	            {
	                Rectangle rect = new Rectangle(0, 0, sizeX, sizeY);
	
	                gr.FillRectangle(faceBrush, rect);
	                gr.DrawRectangle(new Pen(_clr, 3), 0, 0, sizeX - 1, sizeY - 1);
	
	                System.Drawing.Font _numberFont = new Font("Arial", sizeY / 3);
	
	                StringFormat sf = new StringFormat();
	                sf.LineAlignment = StringAlignment.Center;
	                sf.Alignment = StringAlignment.Center;
	
	                gr.DrawString(_n.ToString(), _numberFont, new SolidBrush(_clr), rect, sf);
	            }
	        } return tileFace;
	    }
	
	    public Bitmap DrawBack(int sizeX, int sizeY)
	    {
	        Bitmap tileBack = new Bitmap(sizeX, sizeY);
	
	        using (Graphics gr = Graphics.FromImage(tileBack))
	        {
	            using (Brush backBrush = new SolidBrush(Color.DarkGoldenrod))
	            {
	                Rectangle rect = new Rectangle(0, 0, sizeX, sizeY);
	
	                gr.FillRectangle(backBrush, rect);
	                gr.DrawRectangle(new Pen(_clr, 3), 0, 0, sizeX - 1, sizeY - 1);
	            }
	        } return tileBack;
	    }
	
	    public int Number
	    {
	        set
	        {
	            _n = value;
	        }
	    }
	
	    public Color Colour
	    {
	        set
	        {
	            _clr = value;
	        }
	    }
	}
}

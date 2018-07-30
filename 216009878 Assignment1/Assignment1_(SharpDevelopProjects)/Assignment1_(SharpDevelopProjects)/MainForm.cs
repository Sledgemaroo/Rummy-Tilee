													//216001213 MUDAU R.A
													//212013629 JONKER WD
		
		
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment1__SharpDevelopProjects_
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
			static PoolOfTiles pOt;
		
		public MainForm()
		{
			InitializeComponent();
			pOt = new PoolOfTiles();
            pOt.GeneratePool();
        }
		
		void BtnGenPoolClick(object sender, EventArgs e)
		{	
			Bitmap bmp = new Bitmap(1020, 670);
			
               using (Graphics gr = Graphics.FromImage(bmp))
               {
               		int g = 1;
                   for (int i = 0; i < 13; i++)
                   {
                       for (int j = 0; j < 11; j++)
                       {
                    		gr.DrawImage(pOt.DrawTiles(g).DrawFace(30, 30), j * 50, i * 50);
                    		if(g > 0 && g < 128)
                    		{g++;}	
                       }                        
                   }  
               }
               pictureBox1.Image = bmp;
		}
		
		void BtnDrawTileClick(object sender, EventArgs e)
		{
			try
            {
                Bitmap bmp = new Bitmap(1020, 670);

                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    gr.DrawImage(pOt.DrawTile().DrawFace(70, 100), 80, 20);
                }
                pictureBox2.Image = bmp;
            }

            catch (Exception)
            {
                MessageBox.Show("The pool is empty");
            } 
		}
	}
}

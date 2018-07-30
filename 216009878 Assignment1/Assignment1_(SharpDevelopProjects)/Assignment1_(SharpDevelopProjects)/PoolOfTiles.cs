													//216001213 MUDAU R.A
													//212013629 JONKER WD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1__SharpDevelopProjects_
{
	/// <summary>
	/// Description of PoolOfTiles.
	/// </summary>
	public class PoolOfTiles
	{
		List<RummyTile> poolGen;

		public PoolOfTiles()
		{
			poolGen = new List<RummyTile>();
		}
		
		public void GeneratePool()
		{
		 	for (int i = 0; i < 2; i++)
            {
                for (int a = 1; a < 14; a++)
                {
                    poolGen.Add(new RummyTile(a, "RED"));
                   	poolGen.Add(new RummyTile(a, "GREEN"));
                    poolGen.Add(new RummyTile(a, "BLUE"));
                    poolGen.Add(new RummyTile(a, "BLACK"));
                    poolGen.Add(new RummyTile(a, "YELLOW"));
                }
		 	}
		}
		
		public RummyTile DrawTiles(int y)
        {
            try
            {
            	
            	//Random randDraw1 = new Random();
				
                //int num1 = randDraw1.Next(poolGen.Count);
              
                //RummyTile myTiles = poolGen[num1];
                return poolGen[y];
            }
            catch
            {
                throw new Exception("pool is empty");
            }
        }
		
		public RummyTile DrawTile()
        {
            try
            {
                Random randDraw = new Random();

                int num = randDraw.Next(poolGen.Count);
                RummyTile myTile = poolGen[num];
                poolGen.RemoveAt(num);
                return myTile;
            }
            catch
            {
                throw new Exception("pool empty");
            }
        }
		
		public void Randomize()
        {
            try
            {
                int n = poolGen.Count;
                Random rnd = new Random();
                while (n > 1)
                {
                    int k = (rnd.Next(0, n) % n);
                    n--;
                    RummyTile value = poolGen[k];
                    poolGen[k] = poolGen[n];
                    poolGen[n] = value;
                }
            }
            catch (Exception)
            {
                throw new Exception("The pool is empyt");
            }
        }
		
		public void Status()
        {
            bool isEmpty = !poolGen.Any();
            if (isEmpty)
            {
                // error message
                throw new Exception("Pool is Empty!");
            }
            else
            {}
        }
	}
}

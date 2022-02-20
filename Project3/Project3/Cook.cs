using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
	public class Cook()
	{
		public void Process(TableRequest table)
		{
			foreach (Chicken chicken in table)
			{
				chicken.Obtain();	
				chicken.CutUp();
				chicken.Cook();
			}

			foreach (Egg egg in table)
			{
				egg.Obtain();

				try
				{
				egg.Crack();
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
				egg.CutUp();
				egg.Cook();
				}
			}
	}
}

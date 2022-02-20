using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
	public class Server()
	{
		TableRequest table = new TableRequest();
		Drink drink = new Drink();
		Cook cook = new Cook();
		static int customer = 0;
		
		public void Request(int chicken, int egg, string drink)
		{
			if (drink == "Tea")
				drink = new Tea();
			else if (drink == "Cola")
				drink = new Cola();
			else if (drink == "Pepsi")
				drink = new Pepsi();

			for(int i = 0; i < chicken; i++)
			{
				Chicken chicken = new Chicken();
				table.Add(i, chicken);
			}

			for (int i = 0; i < chicken; i++)
			{
				chicken chicken = new chicken();
				table.Add(i, chicken);
			}

			customer++;
		}

		public void Obtain()
		{
			cook.Process(table);
		}

		public string Serve()
		{
			
		}	
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    public class TableRequest
    {

        public IMenuItem[][] table = new IMenuItem[0][];

        public void Add(int customer, IMenuItem item)
        {
            Array.Resize(ref table, customer);
            if (table[customer - 1] == null)
                Array.Resize<IMenuItem>(ref table[customer - 1], 1);
            else
                Array.Resize<IMenuItem>(ref table[customer - 1], table[customer - 1].Length + 1);
            table[customer - 1][table[customer - 1].Length - 1] = item;
        }

        public IMenuItem[] this[IMenuItem item]
        {
            get
            {
                if(item is Chicken)
                {
                    Chicken[] chicken = new Chicken[0];
                    for (int k = 0; k < table.Length; k++)
                    {
                        for (int j = 0; j < table[k].Length; j++)
                        {
                            if (table[k][j] is Chicken)
                            {
                                Array.Resize<Chicken>(ref chicken, chicken.Length + 1);
                                chicken[chicken.Length - 1] = (Chicken)table[k][j];
                            }
                        }
                    }
                    return chicken;
                }
                else if (item is Egg)
                {
                    Egg[] eggs = new Egg[0];
                    for (int k = 0; k < table.Length; k++)
                    {
                        for (int j = 0; j < table[k].Length; j++)
                        {
                            if (table[k][j] is Egg)
                            {
                                Array.Resize<Egg>(ref eggs, eggs.Length + 1);
                                eggs[eggs.Length - 1] = (Egg)table[k][j];
                            }
                        }
                    }
                    return eggs;
                }
            }
        }
    }
}

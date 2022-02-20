using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    public sealed class Egg : CookedFood, IMenuItem, IDisposable
    {
        bool disposed = false;
        public int quality;
        Random rand = new Random();
        quality = rand.Next(101);

        public override void Cook()
        {
        }

        public override void Obtain()
        {
        }

        public override void Serve()
        {
        }

        public void Crack()
        {
            if(quality < 25)
                throw new Exception("Egg is rotten");
        }

        public void DiscardShell()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

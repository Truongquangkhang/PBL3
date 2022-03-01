using System;

namespace laptrinh_net
{
    class Program{
        
        static void Main(string [] args){
            Clock c = new Clock();
            AnalogClock ac = new AnalogClock();
            DigitalClock dc = new DigitalClock();
            c.ownSecondChange += new Clock.SecondHandler(ac.AC);
            c.ownSecondChange += new Clock.SecondHandler(dc.DC);
            c.Run();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Television
    {
        public int Volume = 0;
        public int Channel = 0;
        public bool IsOn = false;

        public void TurnOn()
        {
            IsOn = true;
            // do the code to turn the tv on
        }
        public void TurnOff()
        {
            IsOn = false;
            // do the code to turn the tv off
        }

        public int CurrentVolume()
        {
            return Volume;
        }
        public void IncreaseVolume()
        {
            if (Volume < 100)
            {
                Volume = Volume + 1;
                // do the code to increase the volume
            }
        }
        public void DecreaseVolume()
        {
            if (Volume > 0)
            {
                Volume = Volume - 1;
                // do the code to decrease the volume
            }
        }

        public int CurrentChannel()
        {
            return Channel;
        }
        public void ChangeChannel(int channel)
        {
            if (Channel > 0 && Channel < 50)
            {
                Channel = channel;
                // do the code to change the
                // channel on the tv
            }
        }
    }

    class TestTV
    {
        static void Main()
        {
            Television tv = new Television();

            if (!tv.IsOn)
            {
                tv.IsOn = true;
            }

            tv.Channel = 3;

            tv.Volume++;
            tv.Volume++;
            tv.Volume++;
            tv.Volume++;

            tv.IsOn = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Angle
{
    public class Clock
    {
        public double CalculateClockAngle(int hours, int minutes)
        {
            // Calculate the angle of the hour hand with respect to 12 o'clock
            double hourAngle = (hours % 12) * 30 + (minutes / 60.0) * 30;

            // Calculate the angle of the minute hand with respect to 12 o'clock
            double minuteAngle = (minutes / 60.0) * 360;

            // Calculate the absolute difference between the hour and minute angles
            double angle = Math.Abs(hourAngle - minuteAngle);

            // Take the lesser angle between the two possible angles (360 - angle)
            if (angle > 180)
            {
                angle = 360 - angle;
            }

            return angle;
        }
    }
}

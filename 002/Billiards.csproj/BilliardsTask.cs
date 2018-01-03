using System;

namespace Billiards
{
	public static class BilliardsTask
	{
		public static double BounceWall(double directionRadians, double wallInclinationRadians)
		{
            // Перевод радиан в градусы
            var perevod = 180 / System.Math.PI;
            var diry = directionRadians * perevod;
            var wally = wallInclinationRadians * perevod;
            double wally1, wally2;
            double angle;

            // Рассчет угла падения и углов стены
            if (diry < 0)
            {
                if (diry < -180)
                {
                    diry = System.Math.Abs(diry) - 180;
                }
                else if (diry == -180)  
                {
                    diry = System.Math.Abs(diry);
                }
                else
                {
                    diry = diry + 360;
                }
                
            }

            if (wally < 0)
            {
                wally1 = wally + 360;
                wally2 = wally1 - 180;
            }
            else if (wally > 0)
            {
                wally1 = wally;
                wally2 = wally1 + 180;
            }
            else
            {
                wally1 = 0;
                wally2 = 180;
            }

            // Рассчет угла отражения
            if (diry > wally1 && diry > wally2)
            {
                if (diry - wally1 < diry - wally2)
                {
                    angle = wally2 - diry - wally1;
                }
                else
                {
                    angle = wally1 - diry - wally2;
                }
            }
            else if (diry < wally1 && diry < wally2)
            {
                if (wally1 - diry < wally2 - diry)
                {
                    angle = wally2 - diry - wally1;
                }
                else
                {
                    angle = wally1 - diry - wally2;
                }
            }

            ///////////////////
            if (wally > 180)
            {
                wally = wally - 180;
            }

            if (diry > wally)
            {

            }

			return angle;
		}
	}
}
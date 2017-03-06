using UnityEngine;
using System.Collections;

namespace Assets.VRBike
{
    public class AchievementManager
    {
        public static bool achievement25Miles;
        public static bool achievement5fuelcells;
        public static bool achievement9fuelcells;
        public static bool achievement20rZone;
        public static bool collected3fuelcells;
        public static int fuelCollected = 0;
        public static bool hitMaximumResistance;
        public static bool tookNoDamage = true;
        public static bool achievementfreefall;
		public static bool gotonecell;
		public static bool gottwocell;

        public static void collectedFuelCell()
        {
            fuelCollected++;

			if (fuelCollected >= 1) gotonecell = true;
			if (fuelCollected >= 2) gottwocell = true;
            if (fuelCollected >= 3) collected3fuelcells = true;
            if (fuelCollected >= 5) achievement5fuelcells = true;
            if (fuelCollected >= 9) achievement9fuelcells = true;


        }

    }
}
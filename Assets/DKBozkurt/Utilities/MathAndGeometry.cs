// Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using UnityEngine;

namespace DKBozkurt.Utilities
{
    public static partial class DKBozkurtUtilities
    {
        /// <summary>
        /// To get a random position between two circles difference on XY plane.
        /// </summary>
        /// <param name="smallerRadius"> Radius of smaller circle.</param>
        /// <param name="greaterRadius"> Radius of greater circle.</param>
        /// <returns></returns>
        public static Vector3 GetRandomSpawnPositionFromTwoCirclesDifferenceOnXY
            (float smallerRadius, float greaterRadius)
        {
            float angle = Random.Range(0f, Mathf.PI * 2f);
            float radius = Random.Range(smallerRadius, greaterRadius);

            float x = radius * Mathf.Cos(angle);
            float y = radius * Mathf.Sin(angle);
            float z = 0f;

            return new Vector3(x, y, z);
        }
        
        /// <summary>
        /// To get a random position between two circles difference on XZ plane.
        /// </summary>
        /// <param name="smallerRadius"> Radius of smaller circle.</param>
        /// <param name="greaterRadius"> Radius of greater circle.</param>
        /// <returns></returns>
        public static Vector3 GetRandomSpawnPositionFromTwoCirclesDifferenceOnXZ
            (float smallerRadius, float greaterRadius)
        {
            float angle = Random.Range(0f, Mathf.PI * 2f);
            float radius = Random.Range(smallerRadius, greaterRadius);

            float x = radius * Mathf.Cos(angle);
            float y = 0f;
            float z = radius * Mathf.Sin(angle);

            return new Vector3(x, y, z);
        }

        /// <summary>
        /// Returns largest of two or more values.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static int AtLeast(this int v, int min) => Mathf.Max(v, min);

        
        /// <summary>
        /// Returns largest of two or more values.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static float AtLeast(this float v, float min)
        {
            return Mathf.Max(v, min);
        }

    }
}

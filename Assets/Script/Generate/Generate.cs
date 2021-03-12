using UnityEngine;

namespace Generate
{
    public abstract class GenerateBase : CoordinateCalculation
    {
        public static void Generate(GameObject prefab,Vector3 transform, Quaternion rotation)
        {
            GameObject spawnPrefab = Instantiate(prefab, transform, rotation);
        }
    }
}
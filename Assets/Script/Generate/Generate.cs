using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generate
{
    public abstract class GenerateBase : MonoBehaviour
    {
        protected void Generate(int numberToGenerate,GameObject prefab,Vector3 transform, Quaternion rotation)
        {
            for(int i = numberToGenerate;i > 0; i--)
            {
                Spawn(prefab, transform, rotation);
            }
        }
        protected GameObject Spawn(GameObject spawnObject, Vector3 spawnPoint, Quaternion rotation)
        {
            GameObject spawnPrefab = Instantiate(spawnObject, spawnPoint, rotation);
            return spawnPrefab;
        }
    }
}
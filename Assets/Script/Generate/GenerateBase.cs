//敵や弾の生成（基底クラス）
using UnityEngine;

namespace Generate
{
    public abstract class GenerateBase : MonoBehaviour
    {
        private GameObject spawnPrefab;
        public GameObject Generate(GameObject prefab,Vector3 transform, Quaternion rotation)
        {
            spawnPrefab = Instantiate(prefab, transform, rotation);
            return spawnPrefab;
        }
    }
}
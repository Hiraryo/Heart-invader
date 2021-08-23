//敵を生成（基底クラス）
using UnityEngine;

namespace Generate
{
    public class GenerateBase : MonoBehaviour
    {
        private GameObject spawnPrefab;
        public GameObject Generate(GameObject prefab, Vector3 transform, Quaternion rotation)
        {
            return Instantiate(prefab, transform, rotation);
        }
    }
}
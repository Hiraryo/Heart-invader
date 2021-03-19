using UnityEngine;

namespace Generate
{
    public abstract class GenerateBase : MonoBehaviour
    {
        const int DAMAGE_NUM = 10;
        private int _hp = 100;
        private GameObject spawnPrefab;
        public GameObject Generate(GameObject prefab,Vector3 transform, Quaternion rotation)
        {
            spawnPrefab = Instantiate(prefab, transform, rotation);
            return spawnPrefab;
        }
        private void Damage()
        {
            _hp -= DAMAGE_NUM;
        }
        private void MyDestroy()
        {
            Destroy(spawnPrefab);
        }
    }
}
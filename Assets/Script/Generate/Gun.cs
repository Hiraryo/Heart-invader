using UnityEngine;

namespace Generate
{
    [RequireComponent(typeof(GenerateBase))]
    public class Gun : GenerateBase
    {
        public Transform Nose;
        public GameObject Bullet;
        [SerializeField] private int _numberToGenerate;
        [SerializeField] private float _shotSpeed;
        private void Update()
        {
            Spawn(Bullet);
        }
        private void Spawn(GameObject spawnPrefab)
        {
            Generate(_numberToGenerate, Bullet, Nose.position, Nose.rotation);
            GameObject bullet = spawnPrefab;
        }
    }
}
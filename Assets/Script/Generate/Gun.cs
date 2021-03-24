using UnityEngine;

namespace Generate
{
    public class Gun : GenerateBase
    {
        public Transform Nose;
        public GameObject Bullet;
        [SerializeField] private int _numberToGenerate;
        [SerializeField] private float _shotSpeed;
        private void Shoot()
        {
            if (_numberToGenerate < 1)
                return;
            Generate(Bullet, Nose.position, Nose.rotation);
            _numberToGenerate--;
        }
    }
}
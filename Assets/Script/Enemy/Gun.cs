using UnityEngine;

namespace Enemy
{
    public class Gun : MonoBehaviour
    {
        public Transform Nose;
        public GameObject Bullet;
        [SerializeField] private int _numberToGenerate;
        [SerializeField] private float _shotSpeed;
        private void Update()
        {
            if (_numberToGenerate < 1)
                return;
            Spawn();
            _numberToGenerate--;
        }
        private void Spawn()
        {
            GameObject bullet = Instantiate(Bullet, Nose.position, Nose.rotation);
            Bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * _shotSpeed);
        }
    }
}
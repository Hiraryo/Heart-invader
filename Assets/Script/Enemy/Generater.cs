using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class Generater : MonoBehaviour
    {
        public GameObject EnemyPrefab;
        [SerializeField] private int NumberToGenerate;
        [SerializeField] [Range(10f, 5f)] private float _positionX;
        [SerializeField] [Range(10f, 5f)] private float _positionZ;

        private void Update()
        {
            if (NumberToGenerate < 1)
                return;
            Vector3 _generatePositon = transform.localPosition;
            _generatePositon.x = Random.Range(_positionX, -_positionX);
            _generatePositon.z = Random.Range(_positionZ, -_positionZ);
            transform.localPosition = _generatePositon;

            Spawn();
            NumberToGenerate--;
        }

        private void Spawn()
        {
            GameObject enemy = Instantiate(EnemyPrefab, transform.TransformPoint(transform.localPosition), Quaternion.identity);
        }
    }
}

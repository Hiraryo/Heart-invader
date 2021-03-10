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
            Vector3 _generatePosition = transform.localPosition;
            _generatePosition.x = Random.Range(_positionX, -_positionX);
            _generatePosition.z = Random.Range(_positionZ, -_positionZ);
            transform.localPosition = _generatePosition;

            Spawn();
            NumberToGenerate--;
        }

        private void Spawn()
        {
            GameObject enemy = Instantiate(EnemyPrefab, transform.TransformPoint(transform.localPosition), Quaternion.identity);
        }
    }
}

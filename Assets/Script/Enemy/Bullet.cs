using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _shootSpeed;
        // Update is called once per frame
        void Update()
        {
            this.transform.Translate(Vector3.up * Time.deltaTime * _shootSpeed);
        }

        //Collisionだと弾がヒロインやプレイヤーに当たった時、反動で微かに移動してしまうのでTriggerにしました。
        private void OnTriggerEnter(Collider other)
        {
            //応急処置
            if(other.gameObject.tag == "Heroine" || other.gameObject.tag == "Player")
            {
                Destroy(gameObject);
            }
        }
    }
}

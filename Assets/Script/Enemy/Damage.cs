using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private void OnCollisionStay(Collision other)
    {
        // playerGunというタグが付いたオブジェクトに当たった時、
        if(other.gameObject.tag == "playerGun")
        {
            Destroy(gameObject);
        }
    }
}

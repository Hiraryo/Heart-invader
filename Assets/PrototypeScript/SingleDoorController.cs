using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SingleDoorController : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    [SerializeField] private float DoorX;
    Vector3 DoorPos;
    // Start is called before the first frame update
    void Start()
    {
        DoorPos = transform.position;
        DoorPos.y = Door.transform.localPosition.y;
        DoorPos.z = Door.transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider player)
    {
        Door.transform.DOLocalMove(new Vector3(DoorX,DoorPos.y,DoorPos.z),3f);
    }
}

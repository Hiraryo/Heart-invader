using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorController : MonoBehaviour
{
    [SerializeField] private GameObject RightDoor;
    [SerializeField] private GameObject LeftDoor;
    [SerializeField] private float DoorX;
    Vector3 RightDoorPos,LeftDoorPos;
    // Start is called before the first frame update
    void Start()
    {
        RightDoorPos = transform.position;
        LeftDoorPos = transform.position;
        RightDoorPos.y = RightDoor.transform.localPosition.y;
        RightDoorPos.z = RightDoor.transform.localPosition.z;
        LeftDoorPos.y = LeftDoor.transform.localPosition.y;
        LeftDoorPos.z = LeftDoor.transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider player)
    {
        RightDoor.transform.DOLocalMove(new Vector3(DoorX,RightDoorPos.y,RightDoorPos.z),3f);
        LeftDoor.transform.DOLocalMove(new Vector3(-DoorX,LeftDoorPos.y,LeftDoorPos.z),3f);
    }
}

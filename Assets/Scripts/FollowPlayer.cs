using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    Vector3 offset = new Vector3(0, 5, -8.5f);
    Vector3 driverSeatOffset = new Vector3(0, 1.7f, 1.1f);
    bool switchCameraView = false;

    void LateUpdate()
    {
     
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Switch camera view
            switchCameraView = !switchCameraView;
        }
        if(!switchCameraView)
            //Camera follow vehicle position
            transform.position = player.transform.position + offset;
        else
            transform.position = player.transform.position + driverSeatOffset;
    }
}

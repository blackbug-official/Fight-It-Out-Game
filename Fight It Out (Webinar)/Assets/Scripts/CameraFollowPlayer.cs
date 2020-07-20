using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 offSet;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + offSet;
        transform.rotation = Player.rotation;
    }
}

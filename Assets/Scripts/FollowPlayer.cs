using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0,0.25F,-10);
        //transform.position = offset;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position.x = player.transform.position;
        //transform.
    }
}

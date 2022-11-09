using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float dir = 2.5F;
    private MovePlayer movePlayer;
    // Start is called before the first frame update
    void Start()
    {
        movePlayer = GameObject.Find("Player").GetComponent<MovePlayer>();
        dir *= movePlayer.dir;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBullet();
    }

    private void SpawnBullet(){
        transform.Translate(Vector2.right * Time.deltaTime * dir,0);
        if(transform.position.x > 17.057f || transform.position.x < -17.92){
            Destroy(gameObject);
        }
    }
}

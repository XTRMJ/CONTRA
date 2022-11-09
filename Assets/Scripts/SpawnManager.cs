using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space )){
            Instantiate(bullet,bullet.transform.position,bullet.transform.rotation);
            transform.position = new Vector2(0.2f * Time.deltaTime,0);
        }
        if(transform.position.x > 17.057f){
            Destroy(gameObject);
        }
    }
}

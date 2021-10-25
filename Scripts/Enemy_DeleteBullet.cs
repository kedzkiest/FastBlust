using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_DeleteBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible(){
        GameObject.Destroy(this.gameObject);
    }

    void OnCollisionEnter(Collision collision){
        GameObject a = collision.gameObject;
        if(a.tag == "wall" || a.tag == "Player" || a.tag == "bullet" ||
        a.tag == "enemy"){
            GameObject.Destroy(this.gameObject);
        }
    }
}

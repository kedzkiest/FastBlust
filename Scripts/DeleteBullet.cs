using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBullet : MonoBehaviour
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
        GameObject.Destroy(this.gameObject);
    }
}

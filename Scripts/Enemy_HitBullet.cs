using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_HitBullet : MonoBehaviour
{
    public int hp;
    int max_hp;

    public AudioClip damageSound;
    private AudioSource audioSource;
    public AudioClip killedSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        max_hp = hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "bullet"){
            hp--;
            audioSource.PlayOneShot(damageSound);
            //AudioSource.PlayClipAtPoint(killedSound, transform.position);

            if(hp <= 0){
            
                GameObject.Destroy(gameObject, 0.3f);
            }
        }
    }

    public int getHP(){
        return hp;
    }

    public int getMaxHP(){
        return max_hp;
    }
}

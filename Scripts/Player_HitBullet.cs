using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HitBullet : MonoBehaviour
{
    public int hp;

    public AudioClip damageSound;
    private AudioSource audioSource;
    public AudioClip killedSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "enemy_bullet" || collision.gameObject.tag == "enemy"){
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

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shoot : MonoBehaviour
{
    //bullet prefab
    public GameObject enemy_bullet;
    
    //bullet start position
    public Transform enemy_muzzle;

    //bullet speed
    public float speed = 1000;

    public AudioClip shootLaser;
    private AudioSource audioSource;
    int cnt = 0;

    public Enemy_move enemy;
    int pattern;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        cnt++;
        pattern = enemy.getPattern();

        if(cnt % 30 == 0 && pattern == 1){
            audioSource.PlayOneShot(shootLaser);

            GameObject bullets = Instantiate(enemy_bullet) as GameObject;

            Vector3 force;

            force = this.gameObject.transform.forward * -speed;

            bullets.GetComponent<Rigidbody>().AddForce(force);

            bullets.transform.position = enemy_muzzle.position;
        }

        if(cnt % 10 == 0 && pattern == 2){
            audioSource.PlayOneShot(shootLaser);

            GameObject bullets = Instantiate(enemy_bullet) as GameObject;

            Vector3 force;

            force = new Vector3(Random.Range(-0.3f, 0.3f), 0.0f, -Mathf.Abs(1)) * speed/3;

            bullets.GetComponent<Rigidbody>().AddForce(force);

            bullets.transform.position = enemy_muzzle.position;
        }

        if(cnt % 3 == 0 && pattern == 3){
            audioSource.PlayOneShot(shootLaser);

            GameObject bullets = Instantiate(enemy_bullet) as GameObject;

            Vector3 force;

            force = new Vector3(Mathf.Cos(cnt), 0.0f, Mathf.Sin(cnt)) * speed*2;

            bullets.GetComponent<Rigidbody>().AddForce(force);

            bullets.transform.position = enemy_muzzle.position;
        }
    }
}

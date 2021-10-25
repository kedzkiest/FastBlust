using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_move : MonoBehaviour
{
    public int pattern;
    public Enemy_HitBullet enemy;

    float i = 0;
    float move = 0.2f;
    int cycle = 0;
    int hp;
    bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        hp = enemy.getHP();
    }

    // Update is called once per frame
    void Update()
    {
        hp = enemy.getHP();

        if(hp >= 40 && hp <= 50){
            pattern = 1;
        }
        else if(hp >= 15 && hp <= 39){
            if(flag == false){
                changePattern();
                i = 0;
            }
            else{
                pattern = 2;
            }
        }
        else if(hp < 60){
            if(flag == false){
                i = 0;
                changePattern();
            }
            else{
                pattern = 3;
            }
        }

        // set pattern 0 to stay still

        if(pattern == 1){
            if(cycle == 0){
                i += 0.1f;
                this.transform.Translate(move, 0.0f, 0.0f);
                if(i >= 12.0f){
                    cycle = 1;
                }
            }
            else if(cycle == 1){
                i -= 0.1f;
                this.transform.Translate(-move, 0.0f, 0,0f);
                if(i <= -12.0f){
                    cycle = 0;
                }
            }
        }

        if(pattern == 2){
            i += 0.1f;
            this.transform.Translate(Mathf.Cos(i)/2, 0.0f, Mathf.Sin(i)/2);
        }

        if(pattern == 3){
            i += 0.1f;
            this.transform.Translate(Mathf.Sin(i), 0.0f, 0.0f);
        }

        void changePattern(){
            i = 0;
            Transform t = this.transform;
            Vector3 worldP = t.position;
            worldP.x = 0.0f;
            worldP.y = 1.0f;
            worldP.z = 6.0f;
            t.position = worldP;
            flag = true;
        }

    }

    public int getPattern(){
            return pattern;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIN_Canvas : MonoBehaviour
{
    public Canvas canvas;
    public Enemy_HitBullet enemy;
    public Player_HitBullet player;
    int enemy_hp;
    int player_hp;

    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        enemy_hp = enemy.getHP();
        player_hp = player.getHP();

        if(enemy_hp <= 0){
            canvas.enabled = true;
        }

        if(enemy_hp <= 0 && player_hp <= 0){
            canvas.enabled = false;
        }
    }
}

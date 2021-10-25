using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOSE_Canvas : MonoBehaviour
{
    public Canvas canvas;
    public Player_HitBullet player;
    int player_hp;

    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        player_hp = player.getHP();
        if(player_hp <= 0){
            canvas.enabled = true;
        }
    }
}

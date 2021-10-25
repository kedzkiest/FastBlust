using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_status : MonoBehaviour
{
    public Text enemy_HP;
    public Enemy_HitBullet enemy;

    public Text player_HP;
    public Player_HitBullet player;

    public Text player_win;
    public Text player_lose;

    private int enemy_hp, enemy_max_hp;
    private int player_hp;

    private int pattern;

    //int[] a = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        enemy_hp = enemy.getHP();
        enemy_max_hp = enemy.getMaxHP();
        enemy_HP.text = "enemy : " + enemy_hp + "/" + enemy_max_hp;

        player_hp = player.getHP();
        player_HP.text = "Life : " + player_hp;


        if(enemy_hp <= 0){
            enemy_HP.text = "";
            player_HP.text = "";
            player_win.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }

        if(player_hp <= 0){
            enemy_HP.text = "";
            player_HP.text = "";
            player_lose.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }
}

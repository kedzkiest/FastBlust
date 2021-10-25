using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = this.transform;

        // reset position
        if(Input.GetKey(KeyCode.R)){
            Vector3 worldP = t.position;
            worldP.x = 0.0f;
            worldP.y = 1.0f;
            worldP.z = -15.0f;
            t.position = worldP;
        }

        // move player
        if(Input.GetKey(KeyCode.LeftArrow)){
            this.transform.Translate(-0.2f, 0.0f, 0.0f);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            this.transform.Translate(0.2f, 0.0f, 0.0f);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            this.transform.Translate(0.0f, 0.0f, 0.2f);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            this.transform.Translate(0.0f, 0.0f, -0.2f);
        }


        //move player faster
        if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.LeftShift)){
            this.transform.Translate(-0.3f, 0.0f, 0.0f);
        }
        if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftShift)){
            this.transform.Translate(0.3f, 0.0f, 0.0f);
        }
        if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift)){
            this.transform.Translate(0.0f, 0.0f, 0.3f);
        }
        if(Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftShift)){
            this.transform.Translate(0.0f, 0.0f, -0.3f);
        }

    }
}

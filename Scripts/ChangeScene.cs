using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class ChangeScene: MonoBehaviour {
 
    // Use this for initialization
    void Start () {

    }
    
    // Update is called once per frame
    void Update () {
        
    }
 
    public void change_2_main(){
        SceneManager.LoadScene("main");
    }

    public void change_2_title(){
        SceneManager.LoadScene("title");
    }
}
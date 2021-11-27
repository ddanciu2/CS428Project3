using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackwardsButton : MonoBehaviour
{
    public GameObject World;
    public GameObject Timer;

    public float smooth = 1f;
    private Quaternion targetRotation;

    void Start(){

    }

    void OnEnable(){
            Debug.Log("ENABLED");
            targetRotation = World.transform.rotation;
            targetRotation *=  Quaternion.AngleAxis(90f, Vector3.right);
    }

    void OnDisable(){
            Timer.SetActive(false);
    }
    
    void Update () {
            World.transform.rotation= Quaternion.Lerp (World.transform.rotation, targetRotation , 10 * smooth * (Time.deltaTime/9)); 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLampLight : MonoBehaviour
{

    public Light lampLight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleLight(){
        //         //getting the reference to the light Object (it must be taged)
        // var myLight = GameObject.FindWithTag( "light" );
        // //disabling the Light
        // myLight.light.enabled = false;
        if(lampLight.enabled == false){
            lampLight.enabled = true;
        }
        else{
            lampLight.enabled = false;
        }

    }
}

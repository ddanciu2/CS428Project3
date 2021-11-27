using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Head;
    public bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        Menu = GameObject.Find("Menu");
        Head = GameObject.Find("HeadsetAlias");

        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire3")){
            if (flag == false) { 
                Menu.transform.position = Head.transform.position + Head.transform.forward * 3;
                Menu.transform.rotation = Head.transform.rotation;
                Menu.SetActive(true);
                flag = true;
            }
            else {
                Menu.SetActive(false);
                flag = false;
            }
        }
    }
}

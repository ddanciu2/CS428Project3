using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRotationMenu : MonoBehaviour
{
    public GameObject RotationMenu;
    public GameObject Head;

    // Start is called before the first frame update
    void Start()
    {
        RotationMenu = GameObject.Find("Rotation Menu");
        Head = GameObject.Find("HeadsetAlias");

        RotationMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            if (!RotationMenu.activeSelf) { 
                RotationMenu.transform.position = Head.transform.position + Head.transform.forward * 3;
                RotationMenu.transform.rotation = Head.transform.rotation;
                RotationMenu.SetActive(true);
            }
            else {
                RotationMenu.SetActive(false);
            }
        }
    }
}

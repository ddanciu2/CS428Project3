using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{

    public GameObject Object;
    public GameObject Menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnable() {
        Object.SetActive(true);
    }

    void OnDisable() {
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public GameObject Object;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnable() {
        StartCoroutine("Stop");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Stop() 
    {
        yield return new WaitForSeconds(6f);
        Debug.Log("DELAYED");
        Object.SetActive(false);
    }
}

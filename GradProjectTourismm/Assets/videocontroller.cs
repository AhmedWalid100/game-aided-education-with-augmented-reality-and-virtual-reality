using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videocontroller : MonoBehaviour
{
    public GameObject videoplay;
    public GameObject canvasvideo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(VideoControl());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator VideoControl()
    {
        yield return new WaitForSeconds(11.0f);
        videoplay.SetActive(false);
        canvasvideo.SetActive(false);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mummy : MonoBehaviour
{
    public GameObject Ghost;
    public AudioSource RotatedSong;
    public AudioSource RotatingSong;
    public bool isLooking = false;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        RotatedSong.Play();
        Ghost.SetActive(true);
        StartCoroutine(Looking());
    }
    IEnumerator Looking()
    {
        yield return new WaitForSeconds(Random.Range(4.5f, 12.0f));
        RotatedSong.Stop();
        RotatingSong.Play();
        Ghost.transform.Rotate(0.0f, 180.0f, 0.0f);
        yield return new WaitForSeconds(1.5f);
        isLooking = true;
        StartCoroutine(NotLooking());
    }
    IEnumerator NotLooking()
    {
        yield return new WaitForSeconds(Random.Range(4.5f, 12.0f));
        isLooking = false;
        RotatingSong.Play();
        Ghost.transform.Rotate(0.0f, 180.0f, 0.0f);
        yield return new WaitForSeconds(0.5f);
        RotatedSong.Play();
        StartCoroutine(Looking());
    }
}

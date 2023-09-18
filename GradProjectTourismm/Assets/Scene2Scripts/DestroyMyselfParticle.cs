using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMyselfParticle : MonoBehaviour
{
    public float lifetime;
    // Start is called before the first frame update
    void Start()
    {
        lifetime = 0.5f;   
    }

    // Update is called once per frame
    void Update()
    {
        lifetime = lifetime - 1 * Time.deltaTime;
        if (lifetime < 0)
        {
            Destroy(gameObject);
        }
    }
}

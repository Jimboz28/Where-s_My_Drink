using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_sprayer : MonoBehaviour
{
    public ParticleSystem sprayEffect;
    public float timeBetweenSpray = 2.0f;
    float sprayCountdown;

    // Start is called before the first frame update
    void Start()
    {
        sprayCountdown = timeBetweenSpray;
        sprayEffect.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (sprayCountdown <= 0)
        {
            sprayEffect.Play();
            sprayCountdown = timeBetweenSpray;
        }
        else
        {
            sprayCountdown -= Time.deltaTime;
            sprayEffect.Stop();
        }
    }
}

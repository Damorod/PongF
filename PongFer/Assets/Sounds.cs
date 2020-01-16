using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    public static AudioClip paleta;
    public static AudioClip pared;
    public static AudioClip punto;

    public static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        paleta = Resources.Load<AudioClip>("GOLPE_PALETA");
        pared = Resources.Load<AudioClip>("GOLPE_PARED");
        punto = Resources.Load<AudioClip>("PUNTO");

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Play(string sound)
    {
        switch (sound)
        {
            case "GOLPE_PALETA":
                audioSrc.PlayOneShot(paleta);
                break;
            case "GOLPE_PARED":
                audioSrc.PlayOneShot(pared);
                break;
            case "PUNTO":
                audioSrc.PlayOneShot(punto);
                break;
        }
    }
}

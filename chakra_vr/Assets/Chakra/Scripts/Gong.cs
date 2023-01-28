using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gong : MonoBehaviour
{

    public List<AudioClip> gongSounds;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.name)
        {
            case "Stick":

                this.GetComponent<AudioSource>().clip = gongSounds[0];
                break;
            case "Stick1":

                this.GetComponent<AudioSource>().clip = gongSounds[1];
                break;
            default:
                this.GetComponent<AudioSource>().clip = gongSounds[2];
                break;



        }
        this.GetComponent<AudioSource>().Play();
    }
}





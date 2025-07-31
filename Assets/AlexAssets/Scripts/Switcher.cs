using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Switcher : MonoBehaviour, IInteractable
{

    public List<Light> lights;

    public AudioSource audioSource;

    public AudioClip switchSound;


    


    public bool isOn;



    void Start()
    {

        foreach (Light l in lights)
        {

            if (l != null)
            {

                l.enabled = isOn;

            }


        }
            




    }

    

    public void Interact()
    {


        isOn = !isOn;



        foreach (Light l in lights)
        {

            if (l != null)
            {

                l.enabled = isOn;

            }

        }


        if (audioSource != null && switchSound != null)
        {

            audioSource.PlayOneShot(switchSound);


        }


    }



}

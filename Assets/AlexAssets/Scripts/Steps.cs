using UnityEngine;

public class Steps : MonoBehaviour
{

    public AudioSource audioSource;

    public AudioClip footstepSound;


    void Update()
    {


        bool isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);


        if (isMoving)
        {

            if (!audioSource.isPlaying)
            {

                audioSource.clip = footstepSound;

                audioSource.loop = true;

                audioSource.Play();

            }

        }
        else
        {

            if (audioSource.isPlaying)
            {

                audioSource.Stop();

            }

        }


    }
        















}

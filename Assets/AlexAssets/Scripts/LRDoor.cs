using UnityEngine;

public class LRDoor : MonoBehaviour, IInteractable
{

    public Animator m_Animator;

    public bool isOpen;

    public AudioSource audioSource;

    public AudioClip openSound;

    public AudioClip closeSound;

    void Start()
    {
        
        if(isOpen)
        {
            m_Animator.SetBool("isOpen", true);


        }

    }

    //public string GetDescription()
    //{

    //    if (isOpen)
    //    {
    //        m_Animator.SetBool("isOpen", true);


    //    }

    //}
 

    public void Interact()
    {
        isOpen = !isOpen;

        if (isOpen)
        {
            m_Animator.SetBool("isOpen", true);


        }
        else
        {
            m_Animator.SetBool("isOpen", false);


        }

        if (audioSource != null)
        {

            audioSource.clip = isOpen ? openSound : closeSound;

            audioSource.Play();

        }
            




    }



}

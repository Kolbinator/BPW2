using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VFXfade : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    public GameObject audio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("PlayFade", true);

            audio.gameObject.SetActive(true);
            
        }

    }
    
}

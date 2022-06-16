using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaStraal : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("PlayStraal", true);
        }

    }

}

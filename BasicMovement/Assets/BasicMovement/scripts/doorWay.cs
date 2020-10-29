using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorWay : MonoBehaviour {

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        anim.SetBool("isOpen", true);
    }
    void OnTriggerExit(Collider other)
    {
        anim.SetBool("isOpen", false);
    }
}

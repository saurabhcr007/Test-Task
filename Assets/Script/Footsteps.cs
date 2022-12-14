using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{

    public AudioSource footstepsSound;
    private void Start() {
        // footstepsSound = GetComponent<AudioSource>();
    }
    void Update() {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A)){
            footstepsSound.enabled = true;
        }
        else{
            footstepsSound.enabled = false;
        }    
    }
}

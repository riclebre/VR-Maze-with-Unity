using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked()
	public bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
	public bool opening = false;
	public AudioClip doorLocked;
	public Animator doorsOpen;
	public BoxCollider gate; // this BoxCollider was added so I can go thru the temple doors once it is open

    void Update() {
		// "If the door is open and it is not fully raised / Animate the door raising up"
		if (opening == true) {
			doorsOpen.SetBool ("clickToOpen", true);
			gate.enabled = false; 
			// Once the animation of the doors play, the BoxCollider of the door gets disabled 
				//to make possible to go inside the temple
		}
	}
    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
		if (locked == false) {
			opening = true;
			}
		// (optionally) Else
		// Play a sound to indicate the door is locked
		else {
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			Debug.Log("Door is locked, please find the key to unlock it first!");
    		}

	}

    public void Unlock() {
		// You'll need to set "locked" to false here
		locked = false;
	}
}
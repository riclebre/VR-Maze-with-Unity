using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked()
	bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
	bool opening = false;

    void Update() {
        // If the door is open and it is not fully raised / Animate the door raising up
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
		if (opening == true) {
			
		}
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;
    }
}

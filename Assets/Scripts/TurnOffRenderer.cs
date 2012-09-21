using UnityEngine;
using System.Collections;

public class TurnOffRenderer : MonoBehaviour {
	
	public string toggleKey = "t";
	
	// Update is called once per frame
	void OnGUI () {
		if (Event.current.Equals(Event.KeyboardEvent(toggleKey))) {
			renderer.enabled = !renderer.enabled;
		}
	}
}

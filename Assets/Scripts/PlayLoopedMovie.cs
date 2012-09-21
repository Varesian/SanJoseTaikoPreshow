using UnityEngine;
using System.Collections;

public class PlayLoopedMovie : MonoBehaviour {

	public MovieTexture movieTexture;
	public Resizer resizer;
	
	// Use this for initialization
	void Start () {
		renderer.material.mainTexture = movieTexture;
		//movieTexture.Play();
		//movieTexture.loop = true;
		movieTexture.Stop ();
		movieTexture.loop = false;
	}
	
	void Update() {
		if (!movieTexture.isPlaying) {
			movieTexture.Stop ();
			movieTexture.Play ();
			resizer.Reset();
		}
		
	}
}

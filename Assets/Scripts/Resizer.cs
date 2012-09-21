using UnityEngine;
using System.Collections;

public class Resizer : MonoBehaviour {

	public float[] scaleFactors = new float[3];
	//the lengths of times until the matching scaleFactor is changed
	public float[] secsUntilRescales = new float[3];
	public Vector3[] centers = new Vector3[3];
	
	//should be private
	private Vector3 initialScale;
	private float timer = 0;
	private int rescaleIndex = 0;
	
	// Use this for initialization
	void Start() {
		initialScale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > secsUntilRescales[rescaleIndex]) {
			Debug.Log ("Resize!");
			rescaleIndex++;
			transform.localScale = initialScale * scaleFactors[rescaleIndex];
			transform.localPosition = centers[rescaleIndex];
		}
	}
	
	public void Reset() {
		Debug.Log ("RESETTING!!!");
		rescaleIndex = 0;
		timer = 0;
		transform.localScale = initialScale * scaleFactors[0];
		transform.localPosition = centers[rescaleIndex];
	}
}

using UnityEngine;
using System.Collections;

public class MyScript : MonoBehaviour {

	public float speed  = 10;
	public float angle = 0;
//	private Vector3 localPosition;
	// Use this for initialization
	/**
			Awake() ==> Start() ===> Update
					
	**/
	void Awake(){
		Debug.Log ("Object's Speed = " + speed);
	}


	void Start () {	
//		localPosition = transform.localPosition;
		var script = gameObject.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.localPosition += new Vector3 (speed, 0, 0) * Time.deltaTime;
		gameObject.transform.localEulerAngles += new Vector3 (0, angle, 0) * Time.deltaTime;
	}

	void FixUpdate(){
		}

}

using UnityEngine;
using System.Collections;

public class ParentScript : MonoBehaviour {
	public GameObject object1;
	public GameObject object2;
	// Use this for initialization
	void Start () {
		Random.seed = 42;
		object2.GetComponent<MyScript>().speed = Random.Range(0,10);
		object1.GetComponent<MyScript>().speed = Random.Range(-10,0);
		object2.GetComponent<MyScript>().angle = Random.Range(0,360);
		object1.GetComponent<MyScript>().angle = Random.Range(-360 , 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

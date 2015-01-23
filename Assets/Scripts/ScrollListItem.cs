using UnityEngine;
using System.Collections;

public class ScrollListItem : MonoBehaviour {

	// Use this for initialization
	public GameObject itemPrefaq;
	public GameObject parent;
	public int yDeskOffSet = 50;
	public int numberItem  = 10;
	void Start(){
		for(int i = 0 ; i < numberItem ; i ++){
			GameObject go = (GameObject)Instantiate(itemPrefaq, Vector3.zero, Quaternion.identity);
			go.transform.parent = parent.transform;
			var itemObject = go.GetComponent<ItemObject>();
			if(i % 2 == 0)
				itemObject.background.spriteName = "";
			go.transform.localScale = new Vector3(1f,1f,1f);
			go.transform.localPosition = new Vector3(0, -i * yDeskOffSet, 0);
			
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

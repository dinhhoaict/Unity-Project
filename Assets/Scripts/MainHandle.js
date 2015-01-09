#pragma strict

function Start () {

}

function Update () {
	if(Input.GetKeyDown(KeyCode.Escape)){
		Application.Quit();
		Debug.Log("Quit Game");
	}
}
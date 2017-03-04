#pragma strict

var labelStyle : GUIStyle;
labelStyle.fontSize = 30;
function Start () {

}

function Update () {
	    if (Input.GetButton("Jump")) {
        Application.LoadLevel("game");
    }

}

function OnGUI() {
    var sw : int = Screen.width;
    var sh : int = Screen.height;
    GUI.Label(Rect(0, sh/4, sw, sh/4), "S K I J U M P G A M E", labelStyle);
    GUI.Label(Rect(0, sh / 2, sw, sh / 2), "Space to Start", labelStyle);
}
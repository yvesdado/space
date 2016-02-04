#pragma strict


var speed = 20;
function OnMouseDrag () {
transform.position += Vector3.right * Time.deltaTime*Input.GetAxis ("Mouse X") * speed;
transform.position += Vector3.forward * Time.deltaTime*Input.GetAxis ("Mouse Y")* speed;
}



function Start () {

}

function Update () {

}
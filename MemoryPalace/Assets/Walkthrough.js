

function DoRotateAroundAnimation (aPoint, aAxis, aAngle, aDuration) {
 
    // Determine the number of for loop steps needed (assume 30 fps for our loop)
    var tSteps = Mathf.Ceil(aDuration * 30.0);
 
    // Determine the angle delta per step
    var tAngle = aAngle / tSteps;
 
    // Do a for loop
    for (var i = 1; i <= tSteps; i++) {
 
        // Do the rotate around step
        transform.RotateAround (aPoint, aAxis, tAngle);
   
        // Yield for just a moment (assume 30 fps)
        yield WaitForSeconds(0.03333);
 
    }
 
}
 
 
    function Start () {
 
        // Trigger the rotate around animation
        DoRotateAroundAnimation(Vector3.zero, Vector3.up, 90.0, 1.0);
 
    }




function Update () {
    // Get the camera's current position
    var tCameraPosn = transform.localPosition;
   
       
        // Move the camera forward
        transform.Translate((Vector3.forward * (Time.deltaTime * -5.0)));
 
    }

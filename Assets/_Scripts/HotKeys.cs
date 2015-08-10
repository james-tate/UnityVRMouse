using UnityEngine;
using System.Collections;

public class HotKeys : MonoBehaviour {

    /*------------------------------------
    A place to keep track of all the hotkeys
     * A move left
     * B
     * C ResetCrosshair
     * D move right
     * E ratchet right
     * F 
     * G
     * H 
     * I 
     * J
     * K
     * L
     * M mirrorMode "this creates a mirror to show in second oculus"
     * N
     * O
     * P 
     * Q
     * R reset camera
     * S move back / down
     * T
     * U
     * V
     * W move forward / up
     * X
     * Y
     * Z 
     * F1
     * F2 visionmode?
     * F3
     * F4
     * F5
     * F6
     * F7
     * F8
     * F9
     * F10
     * F11 fullscreen?
     * F12
     * Enter = Enter
     * Shift + R = Rename
     * Shift + C = Comment
    -------------------------------------*/

    public bool moveForward = false; // W / Arrow up
    public bool moveLeft = false; // A / Arrow left
    public bool moveRight = false; // D / Arrow right
    public bool moveBack = false; // S / Arrow back
    public bool moveY = false; // right mouse click
    public bool run = false; // shift or left mouse down
    public bool ratchetLeft = false; // Q
    public bool ratchetRight = false; // E
    public bool mirrorMode = false; // M
    public bool fullScreen = false; // F11
    public bool visionMode = false; // vision mode
    public bool recenterPose = false; // recenter the camera
    public bool enter = false;

	void Update () {

        if (Input.GetKeyDown(KeyCode.Return))
            enter = true;
        else
            enter = false;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            moveLeft = true;
        else
            moveLeft = false;

        if (Input.GetKeyDown(KeyCode.B)){

        }
        if (Input.GetKeyDown(KeyCode.C)){
            
        }

            
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                moveRight = true;
        else
                moveRight = false;

        if (Input.GetKeyDown(KeyCode.E))
            ratchetRight = true;
        else
            ratchetRight = false;

        if (Input.GetKeyDown(KeyCode.F)){

        }

        if (Input.GetKeyDown(KeyCode.G))
        {

        }

        if (Input.GetKeyDown(KeyCode.H)){

        }

        if (Input.GetKeyDown(KeyCode.I))
        {

        }

        if (Input.GetKeyDown(KeyCode.J)){

        }
        if (Input.GetKeyDown(KeyCode.K)){

        }
        if (Input.GetKeyDown(KeyCode.L)){

        }
        if (Input.GetKeyDown(KeyCode.M))
            mirrorMode = true;
        else
            mirrorMode = false;

        if (Input.GetKeyDown(KeyCode.N)){

        }
        if (Input.GetKeyDown(KeyCode.O)){

        }

        if (Input.GetKey(KeyCode.P))
        {

        }

        if (Input.GetKeyDown(KeyCode.Q))
            ratchetLeft = true;
        else
            ratchetLeft = false;

        if (Input.GetKeyDown(KeyCode.R))
            recenterPose = true;
        else
            recenterPose = false;

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            moveBack = true;
        else
            moveBack = false;

        if (Input.GetKeyDown(KeyCode.T)){

        }
        if (Input.GetKeyDown(KeyCode.U)){

        }
        if (Input.GetKeyDown(KeyCode.V)){

        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            moveForward = true;
        else
            moveForward = false;

        if (Input.GetKeyDown(KeyCode.X)){

        }
        if (Input.GetKeyDown(KeyCode.Y)){

        }
        if (Input.GetKeyDown(KeyCode.Z)){

        }

        if (Input.GetMouseButton(1))
            moveY = true;
        else
            moveY = false;

        if (Input.GetMouseButton(0))
        {

        }

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.Mouse0))
            run = true;
        else
            run = false;

        if (Input.GetKeyDown(KeyCode.F1))
        {

        }

        if (Input.GetKeyDown(KeyCode.F2))
            visionMode = true;
        else
            visionMode = false;

        if (Input.GetKeyDown(KeyCode.F3))
        {

        }

        if (Input.GetKeyDown(KeyCode.F4))
        {

        }

        if (Input.GetKeyDown(KeyCode.F5))
        {

        }

        if (Input.GetKeyDown(KeyCode.F6))
        {

        }

        if (Input.GetKeyDown(KeyCode.F7))
        {

        }

        if (Input.GetKeyDown(KeyCode.F8))
        {

        }

        if (Input.GetKeyDown(KeyCode.F9))
        {

        }

        if (Input.GetKeyDown(KeyCode.F10))
        {

        }

        if (Input.GetKeyDown(KeyCode.F11))
            fullScreen = true;
        else
            fullScreen = false;

        if (Input.GetKeyDown(KeyCode.F12))
        {

        }



	}
}

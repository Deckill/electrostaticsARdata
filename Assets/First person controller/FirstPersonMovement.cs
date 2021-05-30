using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;

    public float moveSpeed = 0.5f;

    public float translateYspeed = 10;

    public float joystick_turn_sensitivity = 1f;

    Vector2 velocity;


    void FixedUpdate()
    {
        velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(velocity.x, 0, velocity.y);


        if (Input.GetKey("space"))
        {
            //print("space key was pressed");
            this.transform.Translate(Vector3.up * Time.deltaTime * translateYspeed, Space.World);
            
        }


        if (Input.GetKey("left shift"))
        {
            //print("left shift key was pressed");
            this.transform.Translate(Vector3.down * Time.deltaTime * translateYspeed, Space.World);
        }

        if (Mathf.Abs(Input.GetAxis("LeftJoystickVertical")) > .2f)
                transform.Translate(-Vector3.forward * moveSpeed * Input.GetAxis("LeftJoystickVertical"));

        if (Mathf.Abs(Input.GetAxis("RightJoystickVertical")) > .2f)
            transform.Translate(Vector3.up * moveSpeed * Input.GetAxis("RightJoystickVertical"));

        if (Mathf.Abs(Input.GetAxis("LeftJoystickHorizontal")) > .2f)
            transform.rotation = Quaternion.Euler(0, Input.GetAxis("LeftJoystickHorizontal") * joystick_turn_sensitivity + transform.rotation.eulerAngles.y, 0);

        if (Mathf.Abs(Input.GetAxis("RightJoystickHorizontal")) > .2f)
            transform.rotation = Quaternion.Euler(0, Input.GetAxis("RightJoystickHorizontal") * joystick_turn_sensitivity + transform.rotation.eulerAngles.y, 0);

        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();

        if (Input.GetButton("AButton"))
            transform.Translate(Vector3.left * moveSpeed);

        if (Input.GetButton("BButton"))
            transform.Translate(Vector3.right * moveSpeed);


    }


}

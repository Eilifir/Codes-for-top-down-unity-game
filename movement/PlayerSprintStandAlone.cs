using UnityEngine;

public class PlayerSprintStandAlone : MonoBehaviour
{
    /*--------------------------------------------*/
    /* Hello internauts! Eilifir here, if you're  */
    /* gonna use this script, don't use the       */
    /* "PlayerMovement.cs" since it will mess up  */
    /* how everything works. use one or the other */
    /*--------------------------------------------*/

    //-----------------References-----------------
    private Rigidbody2D rb;
    //---------------walk variables---------------
    public float walkSpeed = 3f;
    private Vector2 moveInput;
    //---------------Run variables----------------
    public float sprintSpeed = 6f;
    public KeyCode sprintKey = KeyCode.LeftShift;
    private bool isSprinting;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");  
        float y = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(x, y).normalized; //normalize the new (x,y) vector so you move at the same speed in every direction.
        isSprinting = Input.GetKey(sprintKey);
    }

    void FixedUpdate()
    {
        float currentSpeed;
        
        if(isSprinting)
		      currentSpeed = sprintSpeed;
	      else
		      currentSpeed = walkSpeed;

        rb.linearVelocity = moveInput * currentSpeed;
    }
}

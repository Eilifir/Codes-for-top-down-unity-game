using UnityEngine;

public class SprintPlayerModular : MonoBehaviour
{
    /*-------------------------------------------------------*/
    /* Hello there! i'm elifir the person who made this      */ 
    /* script, if you're gonna use this you'll need to       */
    /* also have the PlayerMovement.cs in the player object  */
    /* and on top of that you'll have to change "moveSpeed"  */
    /* from [SerializedField] to public. I insist that you   */
    /* should use the StandAlone version. thanks for reading */
    /*-------------------------------------------------------*/

    //---------------------References-------------------------
    PlayerMovement movementScript;
    //---------------------Variables--------------------------
    [SerializedField] walkSpeed;
    [SerializedField] runSpeed;
    KeyCode sprintKey = KeyCode.LeftShift;
    KeyCode sprintKey = KeyCode.RightShift;
    bool isSprinting;

    void Start()
    {
        movementScript = GetComponent<PlayerMovement>();
        walkSpeed = movementScript.moveSpeed;
		runSpeed = walkSpeed * 2f;
    }

    void Update()
    {
        isSprinting = Input.GetKey(sprintKey);
    }
    private void FixedUpdate()
    {
        if(isSprinting)
       	   movementScript.moveSpeed = runSpeed;
        else
           movementScript.moveSpeed = walkSpeed;
    }
}

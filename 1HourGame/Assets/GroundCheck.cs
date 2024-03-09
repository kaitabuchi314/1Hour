
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool grounded = true;
    void OnTriggerStay2D(Collider2D collision)
    {
        grounded = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }
}

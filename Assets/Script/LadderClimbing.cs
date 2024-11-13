using UnityEngine;

public class LadderClimbing : MonoBehaviour
{
    public float climbSpeed = 3f;
    private bool isClimbing = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isClimbing = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isClimbing)
        {
            float verticalInput = Input.GetAxis("Vertical");
            Vector2 climbDirection = new Vector2(0f, verticalInput) * climbSpeed;
            transform.Translate(climbDirection * Time.deltaTime);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isClimbing = false;
        }
    }
}

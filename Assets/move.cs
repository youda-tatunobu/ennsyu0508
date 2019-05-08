using UnityEngine;

public class player : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 mpos = Input.mousePosition;
        Vector3 wpos = Camera.main.ScreenToWorldPoint(mpos);
        Vector3 move = wpos - transform.position;
        rb.velocity = move.normalized * speed;
    }
}





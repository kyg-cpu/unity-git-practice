using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerController : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool a = true;
        //bool b = false;
        //gameObject.SetActive(a || b);
        //Vector2 newPos = transform.position;
        //newPos.x = newPos.x + 5;
        //transform.position = newPos;

        transform.position = Vector3.one; // (1, 1, 1)

        //Debug.Log(newPos.x);
        //Debug.Log(newPos.y);
    }

    // Update is called once per frame
    public float speed = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}

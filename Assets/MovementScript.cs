using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript : MonoBehaviour
{
    public float speed = 5f;

    private Keyboard keyboard;

    void OnEnable()
    {
        keyboard = Keyboard.current;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keyboard.dKey.IsPressed())
        {                       // (1, 0, 0)
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (keyboard.aKey.IsPressed())
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}

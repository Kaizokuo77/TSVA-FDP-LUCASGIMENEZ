using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    [SerializeField] float speed;
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        { 
            controller.Move(transform.forward * speed * Time.deltaTime);
        animator.SetBool("WalkForward",true);
        }
        if (Input.GetKeyUp(KeyCode.W))
            animator.SetBool("WalkForward", false);
        if (Input.GetKey(KeyCode.A))
        {
            controller.Move(-transform.right * speed * Time.deltaTime);
        
        }
        if (Input.GetKey(KeyCode.S))
        {
            controller.Move(-transform.forward * speed * Time.deltaTime);
        
        }
        if (Input.GetKey(KeyCode.D))
        {
            controller.Move(transform.right * speed * Time.deltaTime);
        
        }

    }
}

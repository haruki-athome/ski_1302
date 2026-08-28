using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float forcePower;

    [SerializeField]
    private Rigidbody rb;


    private InputAction moveAction;
    private Vector2 moveValue;

    [SerializeField]
    private int point;
    public int Point{ get { return point; } set { point = value; } }

    [SerializeField]
    private int hp;
    public int HP { get { return hp; } set { hp = value; } }
	private Quaternion initialRotation;

	void Start()
	{
		moveAction = InputSystem.actions.FindAction("Move");
		rb = GetComponent<Rigidbody>();
		initialRotation = transform.rotation; // remember the correct starting orientation
	}

	// Update is called once per frame
	void Update()
    {
		MoveLeftorRight();
	}

    private void MoveLeftorRight ()
	{
		moveValue = moveAction.ReadValue<Vector2>();
		rb.AddForce(moveValue.x*Vector3.right * forcePower);
	}
	public void ResetPositionX()
	{
		Vector3 pos = transform.position;
		pos.x = 0f;
		transform.position = pos;

		rb.rotation = initialRotation; // snap back to correct orientation
		rb.linearVelocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
	}
}

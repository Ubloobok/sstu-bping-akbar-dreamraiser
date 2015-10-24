using UnityEngine;
using System.Collections;

public class Ken_figth_kontroller : MonoBehaviour {


	
	public float maxSpeed = 10f;
	bool FacingRight = true;
	public Rigidbody2D rb;
	
	Animator anim;
	
	bool grounded = false;
	public Transform GroundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatisGround;
	public float jumpForce = 700f;
	
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	
	void FixedUpdate()
	{
		float move = Input.GetAxis ("Horizontal");
		
		
		grounded = Physics2D.OverlapCircle (GroundCheck.position, groundRadius, whatisGround);
		anim.SetBool ("Ground", grounded);
		

	

		
		
		}
	
	void Update()
	{
		if (grounded && Input.GetKeyDown (KeyCode.Space)) 
		{
			anim.SetBool("Ground", false);
			rb.AddForce(new Vector2(0, jumpForce));
		}
		
		
	}
	

	
	
	
	
	
	
	

	



}

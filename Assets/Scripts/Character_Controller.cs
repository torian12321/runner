using UnityEngine;
using System.Collections;

public class Character_Controller : MonoBehaviour {
	public float fuerzaSalto = 15f;

	private bool onGround = true;
	public Transform GroundVerifier;
	float radiousVerifier = 0.05f;
	private bool multiJump = false;
	public LayerMask groundMasc;

	private Animator animator;
	private bool running = false;
	public float velocity = 1f;

	void Awake(){
		animator = GetComponent<Animator>();
	}

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate(){
		if(running){
			rigidbody2D.velocity = new Vector2(velocity, rigidbody2D.velocity.y);
		}
		onGround = Physics2D.OverlapCircle(GroundVerifier.position, radiousVerifier, groundMasc);
		animator.SetFloat("Vel_X", rigidbody2D.velocity.x);
		animator.SetBool("isGrounded", onGround);
		if(onGround){
			multiJump=false;
		}
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			if(running){
				//hacemos que salte si puede saltar
				if((onGround || !multiJump)){
					audio.Play();
					rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, fuerzaSalto);
					//rigidbody2D.AddForce(new Vector2(0,fuerzaSalto));
					if(!multiJump && !onGround){
						multiJump = true;
					}
				}
			}else{
				running = true;
				NotificationCenter.DefaultCenter().PostNotification(this, "startToRun");
			}
		}
		/*if((onGround || !multiJump) && Input.GetMouseButtonDown(0)){
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, fuerzaSalto);
			//rigidbody2D.AddForce(new Vector2(0,fuerzaSalto));
			if(!multiJump && !onGround){
				multiJump = true;
			}
		}*/
	}
}

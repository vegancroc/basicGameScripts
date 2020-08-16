using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class character : MonoBehaviour
    {
        #region Field Region
        public SpriteRenderer sr;
        private AudioSource audiosource;
        Rigidbody2D rb;
        public Animator animator;
        private bool isMoving;
        [SerializeField] private float speed;
        private float verticalMove;
        private float horizontalMove;
        #endregion

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            audiosource = GetComponent<AudioSource>();
        }

        void Update()
        {
            walkSoundEffect();
            AnimationController();
            Move();
        }

        void FixedUpdate()
        {
            movingControl();
            Flip();
        }
        #region Functions
        void Move()
        {
        
        horizontalMove = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime * helper.helperNumber;
        verticalMove = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime * helper.helperNumber;
            Vector2 force = new Vector2(horizontalMove, verticalMove);
            rb.velocity = force;
        }

        void AnimationController()
        {
            animator.SetBool("moving", isMoving);
        }

        void Flip()
        {
            if (horizontalMove < 0)
            {
                sr.flipX = false;
            }
            else if (horizontalMove > 0)
            {
                sr.flipX = true;
            }
        }

        void walkSoundEffect()
        {
            if (!audiosource.isPlaying)
            {
                if (Mathf.Abs(rb.velocity.x) > 0)
                {
                    audiosource.Play();
                }
                else if (Mathf.Abs(rb.velocity.y) > 0)
                {
                    audiosource.Play();
                }
            }

        }

        void movingControl()
        {
            if (Mathf.Abs(horizontalMove) > 0)
            {
                isMoving = true;
            }
            else if (Mathf.Abs(verticalMove) > 0)
            {
                isMoving = true;
            }
            else
            {
                isMoving = false;
            }
        }

        #endregion

    }


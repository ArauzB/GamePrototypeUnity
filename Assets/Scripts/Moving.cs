using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Moving : MonoBehaviour {


    public float speed = 10f;
    private Animator anim;
    public float x, y;
    public float rotateSpeed = 200f;
    public Rigidbody rb;
    public float fSalto = 10f;
    public bool salto;

    public Joystick joystickMove;
    bool isJump = false;
    bool esc = false;

    public GameObject Panel;
    bool gamePaused;




    void Start() {


        anim = GetComponent<Animator>();
        salto = false;
        Cursor.lockState = CursorLockMode.Locked;
        if (rb.position.y == -20){



        }

    }



    void FixedUpdate(){

            transform.Rotate(0, x * -rotateSpeed * Time.deltaTime, 0);
            transform.Translate(0, 0, y * speed * Time.deltaTime);

    }



        void Update()
        {


            x = Input.GetAxis("Horizontal") + joystickMove.Horizontal;
            y = Input.GetAxis("Vertical") + joystickMove.Vertical;

            anim.SetFloat("VelX", x);
            anim.SetFloat("VelY", y);

            if (salto == true) {

                if (Input.GetKeyDown(KeyCode.Space) /*|| isJump == true*/) {
                    isJump = false;
                    anim.SetBool("Salte", true);
                    rb.AddForce(new Vector3(0, fSalto, 0), ForceMode.Impulse);

                }

                anim.SetBool("ToqueSuelo", true);

            } else
            {
                EstoyCayendo();
            }


            if (Input.GetKeyDown(KeyCode.Escape)/* || esc ==true*/)
            {
                esc = false;
                gamePaused = !gamePaused;

            }


            if (gamePaused)
            {
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.None;
                Panel.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1;
                Cursor.lockState = CursorLockMode.Locked;
                Panel.SetActive(false);
                Cursor.visible = false;
            }


        }

        /*public void ClickJump()
        {

            isJump = true;
        }

        public void ClickEsc(){

            esc = true;
        }*/

        public void EstoyCayendo()
        {

            anim.SetBool("ToqueSuelo", false);
            anim.SetBool("Salte", false);

        }


    }

    



  


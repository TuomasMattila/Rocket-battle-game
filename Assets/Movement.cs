using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement : MonoBehaviour{

    Rigidbody2D rb;
    public KeyCode up;    //Nämä mahdollistavat sen, että Unityssä on helppo laittaa pelaajille omat näppäimet.
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){

        //Raketin kiihdytys ja kääntäminen
        
        if(Input.GetKey(up)){
            rb.AddForce(transform.up * 300 * Time.deltaTime);
        }

        if(Input.GetKey(down)){
            rb.AddForce(transform.up * -200 * Time.deltaTime);
        }

        if(Input.GetKey(left)){
            rb.AddTorque(200 * Time.deltaTime);
        }

        if(Input.GetKey(right)){
            rb.AddTorque(-200 * Time.deltaTime);
        }

        //Seuraavat käskyt asettavat pelialueen rajat

        if(transform.position.x > 12){
            transform.position -= new Vector3(23, 0, 0);
        }
        if(transform.position.x < -12){
            transform.position += new Vector3(23, 0, 0);
        }
        if(transform.position.y > 7){
            transform.position -= new Vector3(0, 13, 0);
        }
        if(transform.position.y < -7){
            transform.position += new Vector3(0, 13, 0);
        }

        //Pelin uudelleen käynnistys

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}

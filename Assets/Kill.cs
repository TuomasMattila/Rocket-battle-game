using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour{

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player")   //Raketit on merkitty Tagilla Player ja laaserit ei, joten tällä estetään se ettei laasereita voi tuhota laasereilla.
        Destroy(other.gameObject);
    }

}

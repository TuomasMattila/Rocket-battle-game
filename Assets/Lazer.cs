using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour{

    public GameObject laser;
    public KeyCode laukaus;  //Tämä mahdollistaa sen, että Unityssä pystyy helposti säätämään eri pelaajille eri ampumisnäppäimen.
    double cooldown = 0;

    // Start is called before the first frame update
    void Start(){
        cooldown = 1.05;
    }

    // Update is called once per frame
    void Update(){
        
        if(Input.GetKey(laukaus) && cooldown < 0.5){ //Laaseri näkyy jos painaa space -näppäintä. Mitä isompi ehdossa oleva luku on sitä tiheämpään laaseria voi ampua.
            laser.SetActive(true);
            cooldown = 1.05;
        }else if(cooldown < 1){
            laser.SetActive(false);
        }

        cooldown -= Time.deltaTime; //Time.deltaTime on ajan määrä sekunneissa viimeisestä kerrasta kun update ajettiin.
    }
}

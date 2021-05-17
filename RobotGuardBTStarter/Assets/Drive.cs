using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour {

    //acerta a velociadde
	float speed = 20.0F;

    //Acerta a rotaçao
    float rotationSpeed = 120.0F;

    //Pega o objeto bala
    public GameObject bulletPrefab;

    //Cria o objeto bala
    public Transform bulletSpawn;

    void Update() {

        //
        float translation = Input.GetAxis("Vertical") * speed;

        //
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        //Pression para atirar
        if(Input.GetKeyDown("space"))
        {
            GameObject bullet = GameObject.Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward*2000);
        }
    }
}

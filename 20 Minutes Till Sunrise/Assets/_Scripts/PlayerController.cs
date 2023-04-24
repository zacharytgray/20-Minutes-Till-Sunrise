using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed;
    public GameObject camera;
    public GameObject bullet;

    public GameObject playerObject;

    public GameObject bulletSpawnPoint;

    public int playerHealth = 3;
    public bool isAlive = true;

    public bool isInvincible = false;

    public float yValue;
    void Start() {
        PlayerPrefs.SetFloat("Lives", 3);
        isInvincible = false;
    }

    void Update() {
        if (this.transform.position.y > 0.01 || this.transform.position.y < -0.01)
        {
            Vector3 pos = this.transform.position;
           pos.y = 0;
           this.transform.position = pos;
        }
        yValue = this.transform.position.y;
        if (isAlive && this.gameObject != null) {
            Plane playerPlane = new Plane(Vector3.up, transform.position);
            Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
            float hitDist = 0.0f;

            if (playerPlane.Raycast(ray, out hitDist)) {
                Vector3 targetPoint = ray.GetPoint(hitDist);
                Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
                targetRotation.x = 0;
                targetRotation.z = 0;
                playerObject.transform.rotation = Quaternion.Slerp(playerObject.transform.rotation, targetRotation, 7f * Time.deltaTime);
            }

            // Movement
            if (Input.GetKey(KeyCode.W)) {
                transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A)) {
                transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S)) {
                transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D)) {
                transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
            }
            // Shooting
            if (Input.GetMouseButtonDown(0)) {
                Shoot();
            }
        }

        // bool getIsAlive() {
        //     return isAlive;
        // }


        if (playerHealth <= 0) {
            TMTS.playerDead();
            Destroy(this.gameObject);

        }
        PlayerPrefs.SetInt("Lives",  playerHealth);



    }

    void Shoot() {
        // Instantiate(bullet.transform, bulletSpawnPoint.transform.position, Quaternion.identity);
        Instantiate(bullet.transform, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Zombie" || col.gameObject.name == "Zombie(Clone)") {
            if (!isInvincible)
            {
                playerHit();
                playerHealth--;

            }
        }
    }

    void playerHit()
    {
        isInvincible = true;
        Invoke("endIFrames", 1);
    }

    void endIFrames()
    {
        isInvincible = false;
    }
    
}

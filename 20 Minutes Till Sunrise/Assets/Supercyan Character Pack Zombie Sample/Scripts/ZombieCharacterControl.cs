using UnityEngine;

public class ZombieCharacterControl : MonoBehaviour
{
 
    [SerializeField] private float m_moveSpeed = 2;
    [SerializeField] private float m_turnSpeed = 200;

    [SerializeField] private Animator m_animator = null;
    [SerializeField] private Rigidbody m_rigidBody = null;
    public int health = 3;
    public GameObject zombie;
    public GameObject bulletPrefab;


    public Transform player; // Reference to the player's transform

    private void Awake()
    {
        if (!m_animator) { gameObject.GetComponent<Animator>(); }
        if (!m_rigidBody) { gameObject.GetComponent<Animator>(); }
    }

    private void FixedUpdate()
    {
            
    
        // Calculate the direction from the zombie to the player
        Vector3 direction = transform.position;
        if (player != null) {
            direction = player.position - transform.position;
            direction.y = 0; // Ignore the height difference

            // Rotate the zombie to face the player
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), m_turnSpeed);

            // Move the zombie towards the player
            transform.position += transform.forward * m_moveSpeed * Time.deltaTime;
        }

        if (health <= 0) {
            Destroy(this.gameObject);
        }
        
    }

    void OnTriggerEnter(Collider other) {
        Transform rootT = other.gameObject.transform.root;
        GameObject go = rootT.gameObject;


        Bullet enemy = go.GetComponent<Bullet>();
        if (enemy != null) {
            Destroy(go);
            health--;
        }

    }



}
 
    

    
    


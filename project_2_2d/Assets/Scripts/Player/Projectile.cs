using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    private float direction;
    private bool hit;
    private float lifetime; // avoid bullets flying forever

    private Animator anim;
    private BoxCollider2D boxCollider;


    private void Awake() 
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update() 
    {
        if (hit) return;
        float movementSpeed = speed * Time.deltaTime * direction ;
        transform.Translate(movementSpeed, 0, 0);

        //bellets life time
        lifetime += Time.deltaTime;
        if (lifetime > 5) gameObject.SetActive(false); // recycle bullets once it's been flying 
                                                       //and not hitting anything for 5 seconds
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        hit = true;
        boxCollider.enabled = false; 
        anim.SetTrigger("explode");

    }

    public void SetDirection(float _direction)
    {
        lifetime = 0; //reset it to zero 
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;
        boxCollider.enabled = true;

        //make sure bellet facing the right way
        float localScaleX = transform.localScale.x;
        if(Mathf.Sign(localScaleX) != _direction)
            localScaleX = -localScaleX;

        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);


    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}

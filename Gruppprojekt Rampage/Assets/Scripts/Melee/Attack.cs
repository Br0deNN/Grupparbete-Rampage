using System.Collections;
using UnityEditor.Rendering.Analytics;
using UnityEngine;

public class Attack : MonoBehaviour
{

    [SerializeField] float attackForce = 10f;
    Sprite idle;
    public Sprite sprite;
    public int damage = 10;
    private BoxCollider2D attackCollider;

    private void Start()
    {
        idle = GetComponentInParent<SpriteRenderer>().sprite;
        attackCollider = GetComponent<BoxCollider2D>();

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            GetComponentInParent<SpriteRenderer>().sprite = sprite;
            EnableCollider();
            
            StartCoroutine("GoBack");
        }   
    }

    public IEnumerator GoBack()
    {
        yield return new WaitForSeconds(1);
        GetComponentInParent<SpriteRenderer>().sprite = idle;
        DisableCollider();
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {      
        if (collision.gameObject.tag == "Building" && tag =="Attack")
        {   
            var health = collision.GetComponent<BuildingHeatlth>();
            Debug.Log(health);
            health.TakeDamage(damage);
        }
    }

    private void EnableCollider()
    {
        if (attackCollider != null)
        {
            attackCollider.enabled = true;
        }
    }

    private void DisableCollider()
    {
        if (attackCollider != null)
        {
            attackCollider.enabled = false;
        }
    }
}

using UnityEngine;

public class BuildingHeatlth : MonoBehaviour
{
    public int health;
    public int maxHealth;

    void Start()
    {
        health = maxHealth;
    }
    // Update is called once per frame
    public  void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

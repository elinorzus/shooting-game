using TMPro;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public TextMeshProUGUI Text;

    void Start()
    {
        Text.text = "Dummy's health: " + health;
    }


    public void TakeDamage(float amount)
    {
        health -= amount;
        Text.text = "Dummy's health: " + health;

        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Text.enabled = false;
        transform.GetComponent<Renderer>().enabled = false;
    }
}

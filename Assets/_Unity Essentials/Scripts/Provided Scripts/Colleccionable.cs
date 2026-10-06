using UnityEngine;

public class Colleccionable : MonoBehaviour
{
    public GameObject onCollectEffect;

    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(0, 0.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Genera el efecto de partículas
            Instantiate(onCollectEffect, transform.position, transform.rotation);

            // Destruye el coleccionable
            Destroy(gameObject);
        }
    }
}
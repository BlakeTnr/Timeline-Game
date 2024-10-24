using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    public GameObject explosionParticles;
    public AudioSource explosionSource;

    private void OnTriggerEnter(Collider other)
    {
        explosionParticles.SetActive(true);
        Invoke("disableParticles", 1.7f);
        explosionSource.Play();
        other.GetComponent<Rigidbody>().AddExplosionForce(100, gameObject.transform.position, 10, 5, ForceMode.Impulse);
        Invoke("reloadScene", 4f);
    }

    private void disableParticles()
    {
        explosionParticles.SetActive(false);
    }

    private void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

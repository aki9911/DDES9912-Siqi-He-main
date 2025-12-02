using UnityEngine;

public class soundhit : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        audioSource.Play(); 
    }
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }
}

using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private string steel="Steel";
    public AudioClip butterflyShock;
    private AudioSource audio;


    void Start() 
    {
        audio = GetComponent<AudioSource>();
    }

	void OnCollisionEnter(Collision collision)
	{
		
        if (collision.collider.CompareTag(steel))  
		{
            audio.clip = butterflyShock;
            audio.Play();
			Destroy(collision.collider.gameObject);
		}
	}
}

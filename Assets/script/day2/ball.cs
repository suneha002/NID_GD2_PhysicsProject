
using TMPro;
using UnityEngine;

public class ball : MonoBehaviour
{
    private int numberOfBounces;
    public GameObject textbox;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // numberOfBounces = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("paddle"))
        {
            Debug.Log("Collided with paddle");
            numberOfBounces++;
            Debug.Log("number of bounces:" + numberOfBounces);
            textbox.GetComponent<TMP_Text>().text = "Bounces:" + numberOfBounces;
        }



        if (other.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
        }
    }
}

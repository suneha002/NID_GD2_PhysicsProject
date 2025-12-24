
using TMPro;
using UnityEngine;

public class ballandtext : MonoBehaviour
{

    private int numberofBouncing;
    public GameObject tbox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numberofBouncing =0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("paddle"))
        {
            Debug.Log("Collided");
            numberofBouncing++;
            Debug.Log("bounce:"+ numberofBouncing);
            tbox.GetComponent<TMP_Text>().text= "Score:" + numberofBouncing;
        }

        if(other.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
        }
    }
}

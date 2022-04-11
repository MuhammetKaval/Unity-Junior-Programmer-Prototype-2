using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public int timeBetweenSend = 1;
    public int timeCounter = 0;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeCounter == 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            timeCounter = timeBetweenSend;

            StartCoroutine("IncreaseCount");
        }
    }


    // Countdown for send a dog
    IEnumerator IncreaseCount()
    {
        while(timeCounter > 0)
        {
            Debug.Log(timeCounter);
            yield return new WaitForSeconds(1f);
            timeCounter--;
        }
    }
}

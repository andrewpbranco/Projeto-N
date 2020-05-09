using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float count = 0;
    private float currentcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentcount = count;
    }

    // Update is called once per frame
    void Update()
    {
        currentcount -= Time.deltaTime * 1;

        if (currentcount <= 0)
        {
            SceneManager.LoadScene("Menu");
		}
    }
}

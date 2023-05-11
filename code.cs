using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class code : MonoBehaviour
{

    public GameObject wall;
    private void Start()
    {
        m_MyText.text = "Coin = " + sum + " /5";
    }
    int sum = 0;
    public Text m_MyText;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("point"))
        {
            Debug.Log("point");
            sum = sum + 1;
            m_MyText.text = "Coin = " + sum + " /5";
            Destroy(other.gameObject);
            if (sum >= 3)
            {
                wall.SetActive(false);
            }
        }
        if (other.gameObject.CompareTag("poison"))
        {
            restart();
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}

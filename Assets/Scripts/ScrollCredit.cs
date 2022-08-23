using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollCredit : MonoBehaviour
{
    public GameObject creditsRun;
     void Start()
    {
        StartCoroutine(RollCreds());
    }
    IEnumerator RollCreds()
    {
        yield return new WaitForSeconds(0.5f);
        creditsRun.SetActive(true);
        yield return new WaitForSeconds(12);
        SceneManager.LoadScene(1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroText : MonoBehaviour
{
    [SerializeField] private GameObject Text;
    [SerializeField] private int timer;

    private void Start()
    {
        StartCoroutine(HideObject());

    }

    IEnumerator HideObject()
    {
        yield return new WaitForSeconds(timer);
        Text.SetActive(false);
    }
	
}

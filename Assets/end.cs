using UnityEngine;
using System.Collections;

public class end : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(xx());
    }

    public IEnumerator xx()
    {
        yield return new WaitForSeconds(3);
        Application.LoadLevel(0);
    }
}

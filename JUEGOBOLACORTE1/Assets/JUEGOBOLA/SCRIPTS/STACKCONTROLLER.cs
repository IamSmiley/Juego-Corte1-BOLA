using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STACKCONTROLER : MonoBehaviour
{
    [SerializeField]
    private STACKPARTCONTROLLER[] stackPartControlls = null;

    public void ShatterAllParts()
    {
        if(transform.parent != null)
        {
            transform.parent = null;
            FindObjectOfType<BOLA>().IncreaseBrokenStacks();
        }

        foreach (STACKPARTCONTROLLER o in stackPartControlls)
        {
            o.Shatter();
        }
        StartCoroutine(RemoveParts());
    }

    IEnumerator RemoveParts()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}

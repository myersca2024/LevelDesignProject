using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public float time = 2f;

    void Start()
    {
        Destroy(gameObject, time);
        StartCoroutine(FadeOutSound());
    }

    private IEnumerator FadeOutSound()
    {
        yield return new WaitForSeconds(time - 1);
        AudioSource src = GetComponent<AudioSource>();
        for (float second = 0; second <= 1; second += Time.deltaTime)
        {
            src.volume = 1 - second;
            yield return null;
        }
    }
}

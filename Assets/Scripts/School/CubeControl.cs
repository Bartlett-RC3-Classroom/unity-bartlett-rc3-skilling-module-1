using UnityEngine;
using System.Collections;

public class CubeControl : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         StartCoroutine(ScaleOverTime(20f, 5f));
    }

    // Update is called once per frame
    void Update()
    {
        // Alwas sping 1 degree
        transform.Rotate(1, 1, 1); 
        // If i press space the cube use gravity
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    private IEnumerator ScaleOverTime(float duration, float scale) 
    {
        var startScale = transform.localScale;
        var endScale = Vector3.one * scale;
        var elapsed = 0f;

        while (elapsed < duration) {
            var t = elapsed / duration;
            transform.localScale = Vector3.Lerp(startScale, endScale, t);
            elapsed += Time.deltaTime;
            yield return null;
        }

    transform.localScale = endScale;
    }
}


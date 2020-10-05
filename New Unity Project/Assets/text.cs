using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class text : MonoBehaviour
{
    Text a;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        num += 1;
        a.text = num.ToString();
    }
}

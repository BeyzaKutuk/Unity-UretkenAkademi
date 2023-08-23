using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BayrakToplama : MonoBehaviour
{

    private float skor = 0;
    public TextMeshProUGUI _text;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("Skor");
        _text.text = skor.ToString();
    }

    private void OnCollisionEnter(Collision col)
    {
        string temp;
        if (col.gameObject.tag == "Bayrak")
        {
            Destroy(col.gameObject);
            skor++;
            PlayerPrefs.SetFloat("Skor", skor);
        }

        print(PlayerPrefs.GetFloat("Skor"));
        temp = skor.ToString();
        _text.text = temp;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

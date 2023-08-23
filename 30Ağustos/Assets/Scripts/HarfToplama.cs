using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HarfToplama : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public TextMeshProUGUI z;
    public TextMeshProUGUI a1;
    public TextMeshProUGUI f;
    public TextMeshProUGUI e;
    public TextMeshProUGUI r1;
    public TextMeshProUGUI b;
    public TextMeshProUGUI a2;
    public TextMeshProUGUI y;
    public TextMeshProUGUI r2;
    public TextMeshProUGUI a3;
    public TextMeshProUGUI m;
    public TextMeshProUGUI i;

    private int count = 0;
    public GameObject panel;

    private void OnCollisionEnter(Collision col)
    {
        
        if(col.gameObject.tag == "Harf")
        {
            Destroy(col.gameObject);
            switch (col.gameObject.name.ToString())
            {
                case "A1 harfi":
                    a1.gameObject.SetActive(true);
                    count++;
                    break;

                case "B harfi":
                    b.gameObject.SetActive(true);
                    count++;
                    break;

                case "E harfi":
                    e.gameObject.SetActive(true);
                    count++;
                    break;

                case "A2 harfi":
                    a2.gameObject.SetActive(true);
                    count++;
                    break;

                case "A3 harfi":
                    a3.gameObject.SetActive(true);
                    count++;
                    break;

                case "Z harfi":
                    z.gameObject.SetActive(true);
                    count++;
                    break;

                case "Y harfi":
                    y.gameObject.SetActive(true);
                    count++;
                    break;

                case "F harfi":
                    f.gameObject.SetActive(true);
                    count++;
                    break;

                case "R1 harfi":
                    r1.gameObject.SetActive(true);
                    count++;
                    break;

                case "R2 harfi":
                    r2.gameObject.SetActive(true);
                    count++;
                    break;

                case "M harfi":
                    m.gameObject.SetActive(true);
                    count++;
                    break;

                case "I harfi":
                    i.gameObject.SetActive(true);
                    count++;
                    break;

            }

            if(count == 12)
            {
                panel.gameObject.SetActive(true);
            }
        }
        
    }
}

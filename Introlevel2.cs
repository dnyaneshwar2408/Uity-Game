using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Introlevel2 : MonoBehaviour
{
    [SerializeField] GameObject cloud1;
    [SerializeField] GameObject mom1;
    [SerializeField] GameObject cloud2;
    [SerializeField] GameObject child2;
    [SerializeField] GameObject cont;

    [SerializeField] public TextWriter textWriter; 
    // Start is called before the first frame update
    void Start()
    {
        
        
        StartCoroutine(go());
        // cloud1.SetActive(false);
        // mom1.SetActive(false);

    }
    public IEnumerator go()
    {
        Text code1 = GameObject.Find("intro/Canvas/mom1").GetComponent<Text>();
        textWriter.AddWriter(code1,"Kid , I have brought a Cake  . ",0.09f);
        yield return new WaitForSeconds(5f);
        cloud1.SetActive(false);
        mom1.SetActive(false);
        cloud2.SetActive(true);
        child2.SetActive(true);
        Text code2 = GameObject.Find("intro/Canvas/child1").GetComponent<Text>();
        textWriter.AddWriter(code2,"\t\t\t\tWow ! ! !  ",0.09f);
        yield return new WaitForSeconds(3f);
        cloud2.SetActive(false);
        child2.SetActive(false);
        cloud1.SetActive(true);
        mom1.SetActive(true);
        Text code3 = GameObject.Find("intro/Canvas/mom1").GetComponent<Text>();
        textWriter.AddWriter(code3,"Since its your Birthday\nFrom Home now directly go to \nStationary and bring Pencil Boxes\nfor your friends . ",0.09f);
        yield return new WaitForSeconds(10f);
        cloud1.SetActive(false);
        mom1.SetActive(false);
        cloud2.SetActive(true);
        child2.SetActive(true);
        Text code4 = GameObject.Find("intro/Canvas/child1").GetComponent<Text>();
        textWriter.AddWriter(code4,"  \t\t\tOkay  Mom ! ! !",0.09f);
        yield return new WaitForSeconds(4f);
        cloud2.SetActive(false);
        child2.SetActive(false);
        cont.SetActive(true);


    }

    // Update is called once per frame

}

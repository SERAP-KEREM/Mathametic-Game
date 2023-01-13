using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DortIslem : MonoBehaviour
{

    public Text ilkSayi;
    public Text ikinciSayi;
    public Text islem;
    public Text cevap;
    public Text sonuc;
    public InputField sonucInput;

    int sayi1;
    int sayi2;
    int islemIsareti;
    int islemSonucu;


    // Start is called before the first frame update
    void Start()
    {
        YeniSoru();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CevapKontrol()
    {
        if(int.Parse(cevap.text)==islemSonucu)
        {
            sonuc.text = "DOGRU";
        }
        else
        {
            sonuc.text = "YANLIS";
        }
    }
    public void YeniSoru()
    {
        cevap.text ="";
        sonuc.text ="";
        sonucInput.text = "";
        sayi1 = Random.Range(0, 10);
        sayi2 = Random.Range(0, 10);
        islemIsareti = Random.Range(1, 5);

        switch (islemIsareti)
        {
            case 1:
                islem.text = "+";
                islemSonucu = sayi1 + sayi2;
                break;
            case 2:
                islem.text = "-";
                islemSonucu = sayi1 - sayi2;

                break;
            case 3:
                islem.text = "/";
                
                islemSonucu = sayi1 / sayi2;
                break;
            case 4:
                islem.text = "*";
                islemSonucu = sayi1 * sayi2;
                break;
        }
        ilkSayi.text = sayi1.ToString();
        ikinciSayi.text = sayi2.ToString();
    }
}

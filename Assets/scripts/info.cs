using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class info : MonoBehaviour
{
    [Header("����������")]
    [Multiline]
    public string FIO;
     private string Klass;
    [Multiline]
    public string predmet;
    
    public Texture photo;
    [Header("�������")]
    public Text FIO_TEXT;
    public  Text Klass_nomer;
    public Text klass_imya;
    public Text PREDMET_NAZVANIE;
    public Image image;


    private void Start()
    {
        Klass = GetComponent<�����������>().�����_��������;
    }
    public void smena_infy()
    {
        FIO_TEXT.text =  FIO;
        Klass_nomer.text = "������� � "  + Klass;
        PREDMET_NAZVANIE.text = predmet;
        Klass_nomer.text = Klass;
        klass_imya.text = GetComponent<�����������>().�����_������;
        //image.canvasRenderer.SetTexture(photo);

    }
}

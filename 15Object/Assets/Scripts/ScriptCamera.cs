using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptCamera : MonoBehaviour
{
    public AudioSource au;
    public Rigidbody2D rgb2;
    public BoxCollider2D bxc;
    public script4 kd4;
    public script5 kd5;
    public CapsuleCollider2D cpc;
    public Rigidbody2D rgb7;
    public Rigidbody2D rgb8;
    public SphereCollider sc;
    public script10 kd10;
    public Text text1;
    public Button buton1;
    public InputField input1;
    public GameObject panel1;
    public Toggle toggle1;

    // Start is called before the first frame update
    void Start()
    {
        au = GameObject.FindWithTag("tag1").GetComponent<AudioSource>();
        au.loop = true;
        rgb2 = GameObject.FindWithTag("tag2").GetComponent<Rigidbody2D>();
        rgb2.useAutoMass = false;
        bxc = GameObject.FindWithTag("tag3").GetComponent<BoxCollider2D>();
        bxc.isTrigger = true;
        kd4 = GameObject.FindWithTag("tag4").GetComponent<script4>();
        kd4.sayi = 17;
        kd5 = GameObject.FindWithTag("tag5").GetComponent<script5>();
        kd5.isim = "Gorkem";
        cpc = GameObject.Find("obje6").GetComponent<CapsuleCollider2D>();
        cpc.usedByEffector = false;
        rgb7 = GameObject.Find("obje7").GetComponent<Rigidbody2D>();
        rgb7.simulated = true;
        rgb8 = GameObject.Find("obje8").GetComponent<Rigidbody2D>();
        rgb8.freezeRotation = false;
        sc = GameObject.Find("obje9").GetComponent<SphereCollider>();
        sc.isTrigger = true;
        kd10 = GameObject.Find("obje10").GetComponent<script10>();
        kd10.ekran = true;
        text1 = GameObject.Find("Text").GetComponent<Text>();
        text1.text = "ODEV YAPILDI";
        buton1 = GameObject.Find("Button").GetComponent<Button>();
        buton1.interactable = false;
        input1 = GameObject.Find("InputField").GetComponent<InputField>();
        input1.readOnly = true;
        panel1 = GameObject.Find("Panel");
        panel1.SetActive(false);
        toggle1 = GameObject.Find("Toggle").GetComponent<Toggle>();
        toggle1.isOn = false;
    }
}
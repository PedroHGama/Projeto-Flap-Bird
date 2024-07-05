using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

      public bool isGameOver;
      public GameObject obstaculo;
      public TextMeshProUGUI textoPontuacao;
      public int pontos;
      public GameObject Botoes;
     
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GerarObstaculo", 1, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        textoPontuacao.text = "Pontuação: " + pontos;

        if(isGameOver == true)
        {
          Botoes.SetActive(true);
        }
    } 
    public void GerarObstaculo()
    {
      if(isGameOver == false)
      {
        Instantiate(obstaculo, new Vector3(12, Random.Range(-1.7f, 2.46f), 0), transform.rotation);
      }
      
    }
    public void Sair()
    {
      Application.Quit();
    }

    public void Reiniciar()
    {
      SceneManager.LoadScene(0);
    }
}

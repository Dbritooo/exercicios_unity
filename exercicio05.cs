using UnityEngine;
//(Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
//recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
//exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
//incompleta".
public class exercicio05 : MonoBehaviour
{
    [SerializeField] int missaoPontos = 50;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (missaoPontos >= 50) 
        {
            print("miss�o sucedida");     
        }
        
        else
        {
            print("missao incompleto");
        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;
//(Itens do invent�rio) Crie um script onde o jogador pode coletar
//diferentes tipos de itens (como moedas, po��es, ou power-ups)
//que t�m efeitos diferentes dependendo do tipo coletado. Use um
//switch case para determinar o efeito de cada tipo de item.
public class exercise10 : MonoBehaviour
{
    [SerializeField] int powerUP;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (powerUP)
        {
            case 01:
                print("po�ao de fogo, de o dobro de dano");
                break;

            case 02:

                print("po��o de agua, atordoe seus inimigos");
                break;

            case 03:
                print("po��o de for�as, tiro mais rapido");
                break;


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

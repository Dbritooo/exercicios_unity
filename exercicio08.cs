using System.Threading;
using UnityEngine;
//(Contador de horas e dias) Crie um script que em que uma
//vari�vel inteira hora seja incrementada de uma unidade a cada 10
//segundos e volte a ser 0 quando alcan�ar o valor 24. Quando
//completar um ciclo, incremente uma vari�vel dias e escreva o
//n�mero de dias que se passaram no console. (Coloque o c�digo
//dentro da fun��o-evento Update).
public class exercicio08 : MonoBehaviour
{
   [SerializeField]   float segundos;
   [SerializeField]  float horas;
   [SerializeField] float dias;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        segundos += Time.deltaTime;

        if (segundos >= 10) 
        {
              horas ++;
            print(dias);
            segundos = 0;
             }

             else if
               (horas == 24)
                {
            dias ++;
            horas = 0;
            print(dias);
            print(horas);
                

            }
            
        
        
    }
}

using System;
usimg System.Collections.Generic;
using System.linq;
using System.Thread.Tasks;


namespace Atividade Xunit;
{
public class IMC
{
    public  double peso;
    
    public double altura

    public double IMC

    public string? categoria

    public void calcular_IMC()
    {
        imc = peso / (altura * altrura);
        IMC = Math.Round(IMC, 2);
    }
    public void classification_IMC()
    {
        if (imc < 18.5)
        {
            categoria = "Abaixo do Peso";
        }
        else if (imc <  25)
        {
            categoria = "Peso Normal";
        } 
        else if (IMC <  30)
        {
            categoria = "sobrepeso";
        }
        else if (IMC < 35)
        {
            categoria = "Obesidade grau I);
        }
         else if (IMC < 40)
        {
            categoria = "Obesidade grau II);
        }
          else  
        {
            categoria = "Obesidade grau III);
        }
    }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lagrange_interpolacion
{
    class Program
    {
        static void LagrangeForm() {
            Console.WriteLine("Punto a evaluar?");
            double numeroEvaluar = double.Parse(Console.ReadLine());
            //Console.WriteLine("Cuantos puntos?");
            StreamReader leer = new StreamReader("C:/Users/Dell/Documents/josueupbc/3er cuatrimestre/Prog. Estructurada/StreamReader/paresNumeros.txt");
            StreamWriter escribir;

          //  int puntos = int.Parse(Console.ReadLine());
            List<double>puntosX = new List<double>();
            List<double> fx = new List<double>();
            double suma=0;
            double buscarFx;
        while(!leer.EndOfStream){
            int conta = 0;
            var salto = leer.ReadLine();
            var valorObtenido = salto.Split('\t');
            puntosX.Add(double.Parse(valorObtenido[conta]));
            fx.Add(double.Parse(valorObtenido[(conta+1)]));

            conta++;
        }
           
            leer.Close();


            for(int i= 0; i<puntosX.Count;i++){
                buscarFx= fx[i];
                for (int j = 0; j < puntosX.Count;j++ ){
                    if(i != j)
                        buscarFx=buscarFx*(numeroEvaluar-puntosX[j])/(puntosX[i]-puntosX[j]);
                 }
                suma =suma+ buscarFx;
             

            
            }
            Console.WriteLine(suma);

            escribir = new StreamWriter("C:/Users/Dell/Documents/josueupbc/3er cuatrimestre/Prog. Estructurada/StreamReader/fx.txt",true);
            escribir.WriteLine("El valor de {0} es igual a {1}",numeroEvaluar,suma);
            escribir.Close();
        
        
        
        }

        static void Main() {
            LagrangeForm();
            Console.ReadKey();
        
        }
    }
}


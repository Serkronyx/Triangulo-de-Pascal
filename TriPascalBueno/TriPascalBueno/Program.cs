using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriPascalBueno
{
    class Program
    {
        static void Main(string[] args)
        {
            int renTotal = 10;
            int [] fil_Actual= new int[renTotal];
            int[] fil_Anterior = new int[renTotal];
            
            //r = los renglones donde me encuentro
            //hace el recorrido de de renglones (FILAS)
            for (int r = 1; r <= renTotal; r++)
            {
                //imprime los espacios en blanco 
                for (int nb = 1; nb <= renTotal - r; nb++)
                {
                    Console.Write(" ");                
                }             
                //el for que hace el recorrido
                //de columnas 
                    for (int col = 0; col < r; col++)
                    {
                        
                        //condicion que imprime los #1
                        if(col == 0 || col == r-1) 
                        {
                            fil_Actual[col]=1;
                            Console.Write(fil_Actual[col] + " ");
                            
                                                                 
                        }else//si no: hacer las operaciones 
                        {
                            fil_Actual[col] = fil_Anterior[col - 1] + fil_Anterior[col];
                            Console.Write(fil_Actual[col] + " ");

                            
                        }
                        
                        
                    }
                    //se utiliza el metodo Utility para hacer la copia del arreglo 
                    Utility.Copy(fil_Anterior, fil_Actual);

                    
                Console.WriteLine();

            }

            Console.ReadKey();

        }
    }
}

using System;

namespace triangulo_de_pascal_con_unos_NadiaReyes
{
    class Program
    {
        static void Main(int n){
            for(int i:n;if>-1;i--){
                int espacios = i;
                while(espacios-- >0){Console.Write("")}
                int unos = n-i;
                while (unos-- >0){Console.Write("1 ")}
                Console.Write();
        }
        }
    }
}
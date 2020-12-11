using System;

namespace overload.classes
{
    public class pagamento
    {
        private string[] lista= {"paulo","tsuka","samuca","priscila"};
        public void mostrar(){
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        public void mostrar(int indice)
        {
            Console.WriteLine("busca por indice: "+lista[indice]);
        }
        public void mostrar(string busca)
        {
            foreach (var item in lista)
            {
                if(item==busca){
                    Console.WriteLine("resultado da busca: "+item);
            } 
            }
           
        }
    }
}
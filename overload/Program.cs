using System;
using overload.classes;

namespace overload
{
    class Program
    {
        static void Main(string[] args)
        {
            pagamento pag= new pagamento();
            pag.mostrar();
            pag.mostrar("tsuka");
            pag.mostrar(1);
        }
    }
}

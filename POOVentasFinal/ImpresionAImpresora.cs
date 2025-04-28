namespace POOVentasFinal
{
    internal class ImpresionAImpresora : IImpresion

    {
        public void Imprimir (string texto) 
        {
         Console.WriteLine ($"Imprimiendo en impresora: {texto}");
        }
    }
}

namespace POOVentasFinal
{
    internal class ImprimirAArchivo : IImpresion
    {
        public void Imprimir (string texto) 
        {
            string directorio = Environment.CurrentDirectory;
            string nombreArchivo = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
            string rutaArchivo = Path.Combine(directorio, nombreArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo)) 
            {
             writer.Write(texto); 
            }
        }
    }
}

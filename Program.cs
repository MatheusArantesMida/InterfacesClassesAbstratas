namespace InterfacesClassesAbstratas
{
    internal class Program
    {
        static void Main()
        {
            Documento documento = new Documento();
            Foto foto = new Foto();
            documento.Salvar();
            foto.Salvar();
        }
    }
}
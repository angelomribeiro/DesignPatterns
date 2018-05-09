namespace Criacao.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // recuperando instancia da classe com singleton
            MyClassSingleton myClass = MyClassSingleton.Instance();
        }
    }
}

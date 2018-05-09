namespace Criacao.Singleton
{
    /// <summary>
    /// SINGLETON: garantir que uma classe tenha somente uma instância 
    /// e fornecer um ponto global de acesso a mesma
    /// </summary>
    public class MyClassSingleton
    {
        private static MyClassSingleton _instance;
        private MyClassSingleton() { }

        // metodo que retorna instancia da classe
        public static MyClassSingleton Instance()
        {
            // verifica se a instancia foi criada anteriormente
            if (_instance == null)
                _instance = new MyClassSingleton();
            // retorna instancia
            return _instance;
        }
    }
}

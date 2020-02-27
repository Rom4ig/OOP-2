namespace WpfApp8
{
    /// <summary>
    /// Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует,
    /// что для определенного класса будет создан только один объект, а также предоставит к этому объекту точку доступа.
    /// </summary>
    class Singleton
    {
        private static Singleton instance;

        public string Name { get; private set; }

        protected Singleton(string name)
        {
            this.Name = name;
        }

        public static Singleton getInstance(string name)
        {
            if (instance == null)
                instance = new Singleton(name);
            return instance;
        }
    }

    class Computer
    {
        public Singleton Singleton { get; set; }
        public void Launch(string Name)
        {
            Singleton = Singleton.getInstance(Name);
        }
    }
}

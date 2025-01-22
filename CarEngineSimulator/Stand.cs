namespace CarEngineSimulator
{
    abstract class Stand
    {
        protected Engine _engine;
        protected int _workTime = 0;
        protected int _maxTime;
        public abstract int MaxWorkTime { get; }
        protected Stand(ref Engine engine, int maxTime)
        {
            _engine = engine;
            _maxTime = maxTime;

            _engine.OnUpdate += Update;
        }

        protected abstract void Update();
        public abstract int StartSimulation(float TAir); //Метод возвращает время работы двигателя

    }
}

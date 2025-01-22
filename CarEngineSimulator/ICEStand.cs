namespace CarEngineSimulator
{
    class ICEStand : Stand
    {
        public override int MaxWorkTime => _maxTime;
        public ICEStand(ref Engine engine, int maxTime = 10800) : base(ref engine, maxTime)
        {

        }

        public override int StartSimulation(float TAir)
        {
            _engine.Start(TAir);
            _engine.OnUpdate -= Update;
            return _workTime;
        }

        protected override void Update()
        {
            _workTime++;
            if ((_engine.EngineTemp >= _engine.MaxTemp) || _workTime >= _maxTime) _engine.Stop();
        }
    }
}

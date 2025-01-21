using System.Collections.Generic;

namespace CarEngineSimulator
{
    class ICE : Engine
    {
        private float _curTemp = 0;
        private bool _isWorking = false;
        public override float EngineTemp => _curTemp; //Текущая температура

        public override float MaxTemp => _t; //Температура перегрева

        public override bool EngineStatus => _isWorking; //Состояние работы двигателя

        public ICE(float I, List<int> M, List<int> V, float T, float Hm, float Hv, float C)
        {
            _i = I;
            _m = M;
            _v = V;
            _t = T;
            _hm = Hm;
            _hv = Hv;   
            _c = C;
        }
        public override void Start(float TAir)
        {
            float a, Vh, Vc, M, V;

            for (int i = 0; i < _m.Count; i++)
            {
                M = _m[i];
                V = _v[i];

                while (V < _v[i + 1])
                {
                    a = M * _i;
                    Vh = M * _hm + V * V * _hv;
                    Vc = _c * (TAir - _curTemp);

                    _curTemp += Vh - Vc;
                    V += a;
                    M = (V - _v[i]) * (_m[i + 1] - _m[i]) / (_v[i + 1] - _v[i]) + _m[i];

                    if (!_isWorking) return;
                }
            }
        }

        public override void Stop() => _isWorking = false;
    }
}

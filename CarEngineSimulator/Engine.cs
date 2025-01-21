using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEngineSimulator
{
    abstract class Engine
    {
        protected float _i; //Момент инерции двигателя
        protected List<int> _m; //Кусочно-линейная зависимость крутящего момен
        protected List<int> _v; //Скорость вращения коленвала
        protected float _t; //Температура перегрева
        protected float _hm; //Коэффициент зависимости скорости нагрева от крутящего момента
        protected float _hv; //Коэффициент зависимости скорости нагрева от скорости вращения коленвала
        protected float _c; //Коэффициент зависимости скорости охлаждения

        public abstract float EngineTemp { get; } //Температура двигателя
        public abstract float MaxTemp { get; } //Температура перегрева
        public abstract bool EngineStatus { get; } //Работа двигателя

        public abstract void Start(float TAir); //Метод запуска двигателя
        public abstract void Stop(); //Метод остановки двигателя
    }
}

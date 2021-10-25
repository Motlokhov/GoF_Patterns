using System;

namespace GoF_Patterns.Behavior.Memento
{
    /// <summary>
    /// Посыльный (коробка напоминаний)
    /// </summary>
    internal class MementoBox
    {
        Memento _memento { get; init; }

        private MementoBox(Memento memento)
        {
            _memento = memento;
        }

        /// <summary>
        /// Хранитель (напоминание)
        /// </summary>
        internal class Memento
        {
            private State _state;

            private Memento(State state)
            {
                _state = state;
            }

            private State GetState()
            {
                return _state;
            }

            /// <summary>
            /// Инициатор хранения, тот чье состояние нужно зафиксировать
            /// </summary>
            //Обертка только для того чтобы остальной код не знал о хранителе и посыльном, но автор знал о них все
            // таким образом можно с большей вероятностью быть уверенным, что хранителе придет в том виде в котором ушел
            // и не будет левого хранителя
            // если будет необходимо можно сделать массив хранителей в посыльном
            internal class Author
            {
                State _currentState;

                public Author()
                {
                    _currentState = new State();
                    Console.WriteLine(_currentState.ToString());
                }

                public void ChangeState(int x, int y, int z)
                {
                    _currentState.ChangeState(x, y, z);
                    Console.WriteLine(_currentState.ToString());
                }

                public void RollbackState(MementoBox careTaker)
                {
                    _currentState = careTaker._memento.GetState();
                    Console.WriteLine(_currentState.ToString());
                }

                public MementoBox SaveState()
                {
                    return new MementoBox(new Memento(_currentState));
                }
            }
        }
    }
}

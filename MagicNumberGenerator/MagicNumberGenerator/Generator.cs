using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumberGenerator
{
    public class Generator
    {
        private bool _isEven;
        private int _number;
        public Generator() 
        {
            _number = 1;
            _isEven = _number % 2 == 0;
        }

        public void SetUpGenerator(int newNum)
        {
            _number = newNum;
            _isEven = _number % 2 == 0;
        }

        public int StartCalculation()
        {
            if (_isEven)
            {
                AddTen();
            }
            else
            {
                SubFive();
            }
            return _number;
        }

        public int StartLongCalculation()
        {
            if(_number > 100)
            {
                EvenLongerPrep();
                MultiOperation();
                AddTen();
            }
            else
            {
                LongPrep();
                MultiOperation();
                SubFive();
            }
            return _number;
        }

        public int StartComplexCalculation()
        {
            if (_isEven)
            {
                if (_number >= 100)
                {
                    HandleBigEven();
                }
                else 
                {
                    HandleSmallEven();
                }
            }
            else 
            {
                if (_number >= 100)
                {
                    HandleBigOdd();
                }
                else
                {
                    HandleSmallOdd();
                }
            }


                return _number;
        }

        private void AddTen()
        {
            _number += 10;
            _isEven = _number % 2 == 0;
            if (!_isEven)
            {
                SubFive();
            }
            else
            {
                MulTen();
            }
        }

        private void SubFive()
        {
            _number -= 5;
            _isEven = _number % 2 == 0;
            if (_isEven)
            {
                AddTen();
            }
            else
            {
                MulTen();
            }
        }

        private void MulTen() 
        {
            _number *= 10;
        }

        private void LongPrep()
        {
            for (int i = 0; i < 1000; i++)
            {
                _number++;
            }

            for (int i = 0; i < 1000; i++)
            {
                _number--;
            }
        }

        private void EvenLongerPrep()
        {
            for (int i = 0; i < 100; i++)
            {
                if(_number % 3 == 0)
                    Thread.Sleep(20);
                _number++;
            }

            for (int i = 0; i < 100; i++)
            {
                if (_number % 5 == 0)
                    Thread.Sleep(100);
                _number--;
            }
        }

        private void HandleSmallEven()
        {
            MulTen();
            SubOne();
            MulTwo();

        }

        private void MultiOperation()
        {
                _isEven = _number % 2 == 0;
                if (_isEven)
                {
                    SubFive();
                }
                else
                {
                    AddTen();
                }
        }

        private void HandleBigEven()
        {
            AddOne();
            MulTen();
            DivTwo();
            SubOne();
        }


        private void AddOne()
        {
            _number += 1;
        }

        private void SubOne()
        {
            _number -= 1;
        }

        private void HandleSmallOdd()
        {
            SubOne();
            DivTwo();
            MulTen();
            DivTwo();
        }

        private void MulTwo()
        {
            _number *= 2;
        }

        private void HandleBigOdd()
        {
            AddOne();
            MulTen();
            SubOne();
        }

        private void DivTwo()
        {
            _number /= 1;
        }

    }
}

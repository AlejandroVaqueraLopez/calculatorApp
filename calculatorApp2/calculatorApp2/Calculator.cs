using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorApp2
{
    internal class Calculator
    {
        private bool _addition;
        private bool _sustraction;
        private bool _plus;
        private bool _divide;
        private float _auxNumber;
        private float _result;
        private bool _isClean;
        private int _lastOp;
        private bool _point;
        private bool _blankSpace;

        public bool Addition { set { _addition = value; } get { return _addition; } }
        public bool Sustraction { set { _sustraction = value; } get { return _sustraction; } }
        public bool Plus { set { _plus = value; } get { return _plus; } }
        public bool Divide { set { _divide = value; } get { return _divide; } }
        public float AuxNumber { set { _auxNumber = value; } get { return _auxNumber; } }
        public float Result { set { _result = value; } get { return _result; } }
        public bool IsClean { set { _isClean = value; } get { return _isClean; } }
        public int LastOp { set { _lastOp = value; } get { return _lastOp; } }
        public bool Point { set { _point = value; } get { return _point; } }
        public bool BlankSpace { set { _blankSpace = value; } get { return _blankSpace; } }

        public Calculator()
        {
            _addition = false;
            _sustraction = false;
            _plus = false;
            _divide = false;
            _auxNumber = 1;
            _result = 0;
            _isClean = true;
            _lastOp = 0;//1 sum, 2 rest, 3 mult, 4 div, 0 false;
            _point = false; 
            _blankSpace = false;
        }

        
    }
}

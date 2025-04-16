using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class UDPMessage
    {
        private bool _isCheck;
        public bool IsCheck 
        { 
            get 
            { 
                return _isCheck; 
            } 
            set 
            { 
                _isCheck = value; 
            } 
        }
        private int _length;
        public int Length 
        { 
            get 
            { 
                return 
                    _length; 
            } 
            set 
            { 
                _length = value; 
            } 
        }
        private byte[] _message;
        public byte[] Message 
        {
            get 
            { 
                return _message; 
            } 
            set 
            { 
                _message = value; 
            }
        }
        public UDPMessage(byte[] message, bool check)
        {
            _message = message;
            _isCheck = check;
            _length = message.Length;
        }
        public UDPMessage()
        {
        }
    }
}

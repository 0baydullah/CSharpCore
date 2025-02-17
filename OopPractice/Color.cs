 using Dumpify;

namespace OopPractice
{
    public abstract class Color
    {
        private string _name;
        private int _code;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Code
        {
            get => _code;
            set => _code = value;
        }

        public Color(string name, int code)
        {
            _name = name;
            _code = code;
        }

        public Color()
        {

        }

        public void setName(string name)
        {
            _name = name;
        }
        public void setCode(int code)
        {
            _code = code;
        }
        public string getName()
        {
            return _name;
        }
        public int getCode()
        {
            return _code;
        }

        public abstract void Info();

        public void Info2(string message)
        {
            $"{message} Name: {Name}, Code: {Code}".Dump();
        }
    }
}

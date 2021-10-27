using Foundation;

namespace XamarinMacTest.Models
{
    [Register("Hoge")]
    public class Hoge : NSObject
    {
        private string _inputString;
        private int _stringLength;

        public Hoge(string inputString)
        {
            InputString = inputString;
        }

        [Export("InputString")]
        public string InputString {
            get { return _inputString; }
            set
            {
                WillChangeValue("InputString");
                WillChangeValue("StringLength");
                _inputString = value;
                DidChangeValue("InputString");
                DidChangeValue("StringLength");
            }
        }

        [Export("StringLength")]
        public int Price {
            get { return InputString.Length; }
        }
    }
}

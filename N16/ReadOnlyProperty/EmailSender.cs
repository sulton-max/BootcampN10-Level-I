using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace N16.ReadOnlyProperty
{
    internal class EmailSender
    {
        public const string FieldRegex = "as3423";
        public const string AppNameToken = "{{AppName}}";
        // token - value
        // token - {{AppName}} - kodni o'zida saqlanadi
        // value - Some Company - konfiguratsiya faylda saqlanadi

        // Const field
        //private const string _fromAddress = "test@gmail.com";

        // Readonly field
        private readonly string _fromAddress;

        // Read-only property
        public string FromAddress { get => _fromAddress; }

        // expression-bodied read-only property
        //public string FromAddress => _fromAddress;

        public EmailSender(string fromAddress)
        {
            _fromAddress = fromAddress;
            _fromAddress = fromAddress;
            _fromAddress = fromAddress;
            //_fromAddress = name;
        }

        public void DoSomething()
        {
            //FromAddress = "";
            //_fromAddress = "";
        }
    }
}

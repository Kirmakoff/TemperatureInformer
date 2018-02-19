using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TemperatureInformer
{
    public static class SimpleLogger
    {
        private static Enums.LoggerOutput _output;
        private static bool _initialized;

        public static void Initialize()
        {
            if (_initialized)
            {
                SetLoggerOutput();
            }
        }

        private static void SetLoggerOutput()
        {
            var put = Properties.Settings.Default.LoggerOutput;
            switch (put)
            {
                case 0:
                    _output = Enums.LoggerOutput.Application;
                    break;
                case 1:
                    _output = Enums.LoggerOutput.File;
                    break;
                case 2:
                    _output = Enums.LoggerOutput.ApplicationAndFile;
                    break;
                default:
                    throw new Exception("Wrong LoggerOutput value");
            }
        }


        public static void Write(string text)
        {
            if (_output == Enums.LoggerOutput.Application)
                WriteToWindow(text);
        }

        private static void WriteToWindow(string text)
        {
            Form1 frm1 = new Form1(); //как-то пиздец криво получилось
            frm1.richTextBoxLogInfo.Text += text;
        }
    }

}

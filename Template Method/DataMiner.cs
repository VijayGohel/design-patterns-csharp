using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class DataMiner
    {
        public void Execute()
        {
            this.OpenFile("");
            this.ExtractData("");
            this.ParseData("");
            this.AnalyzeData("");
            this.SendReport("");
            this.CloseFile("");
        }

        protected abstract void OpenFile(string path);

        protected abstract void ExtractData(string file); 

        protected abstract void ParseData(string rawData);

        protected virtual void AnalyzeData(string data)
        {
            Console.WriteLine($"Analysing data with Default method.");
        }

        protected virtual void SendReport(string analysis)
        {
            Console.WriteLine($"Sending report with Default method.");
        }

        protected abstract void CloseFile(string file);
    }
}

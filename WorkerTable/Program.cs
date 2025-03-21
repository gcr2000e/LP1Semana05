using System;
using Spectre.Console;
using Bogus;
using System.Linq;
using Bogus.DataSets;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int ID = int.Parse(args[0]);
            Randomizer.Seed = new Random(int.Parse(args[0]));
            var table = new Table();
            table.AddColumn("ID");
            table.AddColumn(new TableColumn("Name").Centered());
            table.AddColumn(new TableColumn("Job").Centered());
            table.AddRow($"{ID}");
            table.AddRow($"{workers}");

            var worker = workers.Generate();
            
            AnsiConsole.Write(table);
        }

        public void WorkerID(int ID)
        {
           for(int i = 1; i < 3; i++)
           {
               ID += i;
           } 
        }
        


    }
}

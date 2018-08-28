using System;
using System.Drawing.Imaging;

namespace SimuladorColmena
{
    public class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers, double weight) : base(weight)
        {
            this.workers = workers;
            this.Weight = weight;
            shiftNumber = 0;
        }

        public bool AssignWork(string job, int numberOfShifts)
        {
            foreach (var worker in workers)
            {
                if (worker.DoThisJob(job, numberOfShifts))
                    return true;
            }

            return false;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            
            var report = $"Report for Shift #{shiftNumber}:\r\n";

            for (var i = 0; i < workers.Length; i++)
            {
                var worker = workers[i];
                
                if (worker.DidYouFinish())
                {
                    report += $"Worker #{i + 1} finished the job. Therefore ";
                }
                
                if (string.IsNullOrWhiteSpace(worker.CurrentJob))
                {
                    report += $"Worker #{i + 1} está tocándose las pelotas.\r\n";
                }
                else
                {
                    if (worker.ShiftsLeft > 1)
                    {
                        report += $"Worker #{i + 1} is doing {worker.CurrentJob} for {worker.ShiftsLeft} more shifts.\r\n";
                    }
                    else
                    {
                        report += $"Worker #{i + 1} will be done with {worker.CurrentJob} after this shift.\r\n";
                    }
                }
            }

            return report;
        }
    }
}
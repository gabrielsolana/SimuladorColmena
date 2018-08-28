﻿namespace SimuladorColmena
{
    public class Worker : Bee
    {
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        private const double honeyUnitsPerShiftWorked = 0.65;

        public string CurrentJob { get; private set; }

        public int ShiftsLeft
        {
            get { return shiftsToWork - shiftsWorked; }
        }

        public Worker(string[] jobsICanDo, double weight) : base(weight)
        {
            this.jobsICanDo = jobsICanDo;
            this.Weight = weight;
        }

        public bool DoThisJob(string jobToDo, int shifts)
        {
            if (!string.IsNullOrWhiteSpace(CurrentJob))
                return false;

            foreach (var job in jobsICanDo)
            {
                if (job != jobToDo) continue;

                CurrentJob = job;
                shiftsToWork = shifts;
                shiftsWorked = 0;
                return true;
            }
            return false;
        }

        public bool DidYouFinish()
        {
            
            if (ShiftsLeft != 0)
            {
                shiftsWorked++;
                return false;
            }

            CurrentJob = string.Empty;
            shiftsToWork = 0;
            shiftsWorked = 0;
            return true;
        }

        public override double HoneyConsumptionRate()
        {
            var consumedHoney = base.HoneyConsumptionRate();
            consumedHoney += shiftsWorked * honeyUnitsPerShiftWorked; 

            return consumedHoney;
        }
    }

    
}
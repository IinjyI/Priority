using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priority
{
    public partial class Form1 : Form
    {

       static int numberOfProcesses = 4;
        Process[] processes = new Process[numberOfProcesses];

        void schedule(int processNo)
        {
            executionTimer.Interval = processes[processNo].processBurstTime * 1000;
            cpu.Text = "process #" + processes[processNo].processNumber + " is executing";
            ReadyQueue.Items.Remove($"process #{processes[processNo].processNumber} burst time:" + processes[processNo].processBurstTime);
        }

        static void sort(Process[] pArray)
        {
            for (int i=0; i < numberOfProcesses - 1; i++)
            {
                for (int j=0; j<numberOfProcesses-i-1; j++)
                {
                    if (pArray[j].processPriority > pArray[j + 1].processPriority)
                    {
                        Process temp = pArray[j];
                        pArray[j] = pArray[j + 1];
                        pArray[j + 1] = temp;
                    }
                    if(pArray[j].processPriority == pArray[j + 1].processPriority)
                    {
                        if (pArray[j].processBurstTime > pArray[j + 1].processBurstTime)
                        {
                            Process temp = pArray[j];
                            pArray[j] = pArray[j + 1];
                            pArray[j + 1] = temp;
                        }
                    }
                }
            }
        }
        public Form1()
           
        {
            InitializeComponent();
        }

        private void Priority_Click(object sender, EventArgs e)
        {
            Process process1 = new Process(Convert.ToInt32(p1Burst.Text), Convert.ToInt32(p1Priority.Text),1);
            Process process2 = new Process(Convert.ToInt32(p2Burst.Text), Convert.ToInt32(p2Priority.Text),2);
            Process process3 = new Process(Convert.ToInt32(p3Burst.Text), Convert.ToInt32(p3Priority.Text),3);
            Process process4 = new Process(Convert.ToInt32(p4Burst.Text), Convert.ToInt32(p4Priority.Text),4);
            processes[0] = process1;
            processes[1] = process2;
            processes[2] = process3;
            processes[3] = process4;

            for(int i = 0; i<numberOfProcesses; i++)
            {
                ReadyQueue.Items.Add($"process #{i+1} burst time:"+processes[i].processBurstTime);
            }

            sort(processes);

            executionTimer.Start();

        }

        private void executionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < numberOfProcesses; i++)
            {
                schedule(i);
            }

        }
    }

    class Process
    {
        public Process(int burst,int p, int n) { processBurstTime = burst; processPriority = p; processNumber = n; }
        public int processBurstTime;
        public int processPriority;
        public int processNumber;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades_Manager_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string selector = "0";


            List<string> firstname = new List<string>();
            List<string> grade = new List<string>();
            List<string> ID = new List<string>();
            List<string> lastname = new List<string>();


            int maxindex=0;
            int minindex = 0;
            decimal sum = 0m;
            decimal max = -1;
            decimal min = 1000;


            decimal aCount = 0m;
            decimal bcount = 0m;
            decimal ccount = 0m;
            decimal dcount = 0m;
            decimal fcount = 0m;
            
            
            while (selector != "5")
            {
                Console.WriteLine("1.Enter Students");
                Console.WriteLine("2.Display student grade average");
                Console.WriteLine("3.Remove student");
                Console.WriteLine("4.Grade Analytics");
                Console.WriteLine("5.Quit");

                

                selector = Console.ReadLine();

                switch (selector)

                {
                    case "1":

                        Console.WriteLine("Enter Student ID");
                        string inputid = Console.ReadLine();
                        if (ID.Contains(inputid))

                        {
                            //existing student
                            Console.WriteLine("This Student ID already exists");
                            break;
                        }
                        else
                        {
                            ID.Add(inputid);
                        }


                        Console.WriteLine("Enter student first name");
                        string inputfirstname = Console.ReadLine();
                        firstname.Add(inputfirstname);

                        Console.WriteLine("Enter student last name");
                        string inputlastname = Console.ReadLine();
                        lastname.Add(inputlastname);

                        break;

                    case "2":
                        Console.WriteLine("List of students");
                        firstname.Zip(lastname, (x, y) => x + " " + y).Zip(ID, (x, y) => x + " " + y).ToList().ForEach(x => Console.WriteLine(x));
                        Console.WriteLine(" enter student ID for grades");
                        string inputide = Console.ReadLine();

                        if (ID.Contains(inputide))

                        {
                            Console.WriteLine("enter student grade");
                            string inputgrade = Console.ReadLine();
                            grade.Add(inputgrade);
                        }
                        break;


                    case "3":
                        Console.WriteLine("List");
                        firstname.Zip(lastname, (x, y) => x + " " + y).Zip(ID, (x, y) => x + " " + y).ToList().ForEach(x => Console.WriteLine(x));
                        Console.WriteLine("Enter student ID to remove");
                        string removeid = Console.ReadLine();

                        if (ID.Contains(removeid))
                        {
                            ID.Remove(removeid);
                            //firstname.Remove(removeid);
                            //lastname.Remove(removeid);
                        }
                        Console.WriteLine("New student list after removal");
                        firstname.Zip(lastname, (x, y) => x + " " + y).Zip(ID, (x, y) => x + " " + y).ToList().ForEach(x => Console.WriteLine(x));
                        break;


                    case "4":

                        for (int i = 0; i < grade.Count; i++)
                        {

                            decimal temp = Convert.ToDecimal(grade[i]);
                            sum += temp;


                            if (max < temp)

                            {
                                max = temp;
                                maxindex = i;

                            }


                            if (min > temp)

                            {
                                min = temp;
                                minindex = i;

                            }




                            if (temp >= 90 && temp < 100)

                            {


                                aCount++;
                            }

                            if (temp >= 80 && temp < 89)

                            {


                                bcount++;

                            }

                            if (temp >= 70 && temp < 79)

                            {

                                ccount++;
                            }
                            if (temp >= 60 && temp < 69)
                            {

                                dcount++;
                            }
                            if (temp >= 0 && temp < 59)

                            {

                                fcount++;
                            }


                        }
                        decimal a = aCount / grade.Count();

                        decimal b = bcount / grade.Count();
                        decimal c = ccount / grade.Count();
                        decimal d = dcount / grade.Count();
                        decimal f = fcount / grade.Count();
                        decimal avg = sum / grade.Count();
                        Console.WriteLine("maximum:" + max + " " + firstname[maxindex]);
                        Console.WriteLine("Minimum:" + min + " " + firstname[minindex]);
                        Console.WriteLine("AVERAGE:" + avg);
                        Console.WriteLine("A:" + " " + a.ToString("P0"));

                        Console.WriteLine("B:" + " " + b.ToString("P0"));
                        Console.WriteLine("C:" + " " + c.ToString("P0"));
                        Console.WriteLine("D:" + " " + d.ToString("P0"));
                        Console.WriteLine("F:" + " " + f.ToString("P0"));


                        break;

                    case "5":

                        Environment.Exit(0);
                            break;
                        
                }
            }
            Console.ReadKey();
        }
    }
}

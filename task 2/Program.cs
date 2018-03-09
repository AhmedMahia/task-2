using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElawadyDataStructureTest;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1st year 1st term
            ElawadyDataStructureTest.Subject Math_1 = new ElawadyDataStructureTest.Subject("Math 1", 111);
            ElawadyDataStructureTest.Subject Ph_1 = new ElawadyDataStructureTest.Subject("Physics 1", 112);
            ElawadyDataStructureTest.Subject Mecha_1 = new ElawadyDataStructureTest.Subject("Mechanics 1", 113);
            ElawadyDataStructureTest.Subject Chem = new ElawadyDataStructureTest.Subject("Chemistry", 114);
            ElawadyDataStructureTest.Subject IntroComp = new ElawadyDataStructureTest.Subject("Introduction to Computer", 115);
            ElawadyDataStructureTest.Subject Eng_1 = new ElawadyDataStructureTest.Subject("English 1", 116);
            // 1st year 2nd term
            ElawadyDataStructureTest.Subject Math_2 = new ElawadyDataStructureTest.Subject("Math 2", 121);
            ElawadyDataStructureTest.Subject Ph_2 = new ElawadyDataStructureTest.Subject("Physics 2", 122);
            ElawadyDataStructureTest.Subject Mecha_2 = new ElawadyDataStructureTest.Subject("Mechanics 2", 123);
            ElawadyDataStructureTest.Subject ProTech = new ElawadyDataStructureTest.Subject("Production Technology", 124);
            ElawadyDataStructureTest.Subject ED_P = new ElawadyDataStructureTest.Subject("Engineering Drawing and Projection", 125);
            ElawadyDataStructureTest.Subject Eng_2 = new ElawadyDataStructureTest.Subject("English 2", 126);
            // 2nd year 1st term
            ElawadyDataStructureTest.Subject Math_3 = new ElawadyDataStructureTest.Subject("Math 3", 211);
            ElawadyDataStructureTest.Subject SProg = new ElawadyDataStructureTest.Subject("Structured Programming", 212);
            ElawadyDataStructureTest.Subject DCD = new ElawadyDataStructureTest.Subject("Digital Circuits Design", 213);
            ElawadyDataStructureTest.Subject EC_1 = new ElawadyDataStructureTest.Subject("Electric Circuits 1", 214);
            ElawadyDataStructureTest.Subject E_1 = new ElawadyDataStructureTest.Subject("Electronics", 215);
            ElawadyDataStructureTest.Subject MSWord = new ElawadyDataStructureTest.Subject("MS Word", 216);
            // 2nd year 2nd term
            ElawadyDataStructureTest.Subject Math_4 = new ElawadyDataStructureTest.Subject("Math 4", 221);
            ElawadyDataStructureTest.Subject PA = new ElawadyDataStructureTest.Subject("Programming Applecations", 222);
            ElawadyDataStructureTest.Subject Mea = new ElawadyDataStructureTest.Subject("Measurmnets", 223);
            ElawadyDataStructureTest.Subject EC_2 = new ElawadyDataStructureTest.Subject("Electric Circuits 2", 224);
            ElawadyDataStructureTest.Subject E_2 = new ElawadyDataStructureTest.Subject("Electronics 2", 225);
            ElawadyDataStructureTest.Subject TR = new ElawadyDataStructureTest.Subject("Techincal Reports", 226);
            //3rd year 1st term
            ElawadyDataStructureTest.Subject DSD = new ElawadyDataStructureTest.Subject("Digital Systems Design", 311);
            ElawadyDataStructureTest.Subject DS = new ElawadyDataStructureTest.Subject("Data Structure", 312);
            ElawadyDataStructureTest.Subject NS = new ElawadyDataStructureTest.Subject("Numrical Analysis", 313);
            ElawadyDataStructureTest.Subject Comm_1 = new ElawadyDataStructureTest.Subject("Comm 1", 314);
            ElawadyDataStructureTest.Subject ES = new ElawadyDataStructureTest.Subject("Energy Systems", 315);
            ElawadyDataStructureTest.Subject ET = new ElawadyDataStructureTest.Subject("Engineerging and Technology", 316);
            //3rd year 2nd term
            ElawadyDataStructureTest.Subject DM = new ElawadyDataStructureTest.Subject("Discrete Math", 321);
            ElawadyDataStructureTest.Subject OOP = new ElawadyDataStructureTest.Subject("OOP", 322);
            ElawadyDataStructureTest.Subject CA = new ElawadyDataStructureTest.Subject("Computer Architecture", 323);
            ElawadyDataStructureTest.Subject Mach = new ElawadyDataStructureTest.Subject("Machines", 324);
            ElawadyDataStructureTest.Subject Comm_2 = new ElawadyDataStructureTest.Subject("Comm 2", 325);
            //4th year 1st term
            ElawadyDataStructureTest.Subject ps = new ElawadyDataStructureTest.Subject("Programing System", 411);
            ElawadyDataStructureTest.Subject dbs = new ElawadyDataStructureTest.Subject("Database System", 412);
            ElawadyDataStructureTest.Subject iim = new ElawadyDataStructureTest.Subject("introduction in microprocessor", 413);
            ElawadyDataStructureTest.Subject acsy = new ElawadyDataStructureTest.Subject("Automatic control system", 414);
            ElawadyDataStructureTest.Subject comal = new ElawadyDataStructureTest.Subject("Computer algorithm", 415);
            ElawadyDataStructureTest.Subject lancomp = new ElawadyDataStructureTest.Subject("Language compilation", 415);
            ElawadyDataStructureTest.Subject contro = new ElawadyDataStructureTest.Subject("Controllers", 415);
            //4th year 2st term
            ElawadyDataStructureTest.Subject info = new ElawadyDataStructureTest.Subject("Information system", 421);
            ElawadyDataStructureTest.Subject c_gra = new ElawadyDataStructureTest.Subject("Computer Graphics", 422);
            ElawadyDataStructureTest.Subject op_sys = new ElawadyDataStructureTest.Subject("Operating System", 423);
            ElawadyDataStructureTest.Subject m_c_e = new ElawadyDataStructureTest.Subject("Modern Control Engineering", 424);
            ElawadyDataStructureTest.Subject m_a_s = new ElawadyDataStructureTest.Subject("Modeling and simulation", 425);
            ElawadyDataStructureTest.Subject d_o_m_c = new ElawadyDataStructureTest.Subject("Design of miniature computers", 425);
            ElawadyDataStructureTest.Subject Add_hand = new ElawadyDataStructureTest.Subject("Address handling", 425);
            //5th year 1st term
            ElawadyDataStructureTest.Subject AI = new ElawadyDataStructureTest.Subject("Artifical intelligence", 511);
            ElawadyDataStructureTest.Subject CN_1 = new ElawadyDataStructureTest.Subject("Networks 1", 512);
            ElawadyDataStructureTest.Subject SE = new ElawadyDataStructureTest.Subject("Software Engineering", 513);
            ElawadyDataStructureTest.Subject ECP = new ElawadyDataStructureTest.Subject("Eval Comp Per", 514);
            ElawadyDataStructureTest.Subject PR = new ElawadyDataStructureTest.Subject("Patterns Recognition", 514);
            ElawadyDataStructureTest.Subject DISD = new ElawadyDataStructureTest.Subject("Digital Integrated Systems Design", 514);
            ElawadyDataStructureTest.Subject P_1 = new ElawadyDataStructureTest.Subject("Porject 1", 525);
            //5th year 2st term 
            ElawadyDataStructureTest.Subject CS = new ElawadyDataStructureTest.Subject("Computing Systems", 521);
            ElawadyDataStructureTest.Subject DaSe = new ElawadyDataStructureTest.Subject("Data Security", 522);
            ElawadyDataStructureTest.Subject CN_2 = new ElawadyDataStructureTest.Subject("Networks 2", 523);
            ElawadyDataStructureTest.Subject NN = new ElawadyDataStructureTest.Subject("Neural Networks", 524);
            ElawadyDataStructureTest.Subject RE = new ElawadyDataStructureTest.Subject("Robotics Engineering", 524);
            ElawadyDataStructureTest.Subject ITDIS = new ElawadyDataStructureTest.Subject("Digital Integrated Systems Implementing and Testing", 524);
            ElawadyDataStructureTest.Subject P_2 = new ElawadyDataStructureTest.Subject("Project 2", 525);
           
            
            List<Subject>[] subjects = new List<Subject>[10];
            for (int i = 0; i < subjects.Length; i++)
            subjects[i] = new List<Subject>();
            subjects[0].Add(Math_1);
            subjects[0].Add(Ph_1);
            subjects[0].Add(Mecha_1);
            subjects[0].Add(Chem);
            subjects[0].Add(IntroComp);
            subjects[0].Add(Eng_1);
            subjects[1].Add(Math_2);
            subjects[1].Add(Ph_2);
            subjects[1].Add(Mecha_2);
            subjects[1].Add(ProTech);
            subjects[1].Add(ED_P);
            subjects[1].Add(Eng_2);
            subjects[2].Add(Math_3);
            subjects[2].Add(SProg);
            subjects[2].Add(DCD);
            subjects[2].Add(EC_1);
            subjects[2].Add(E_1);
            subjects[2].Add(MSWord);
            subjects[3].Add(Math_4);
            subjects[3].Add(PA);
            subjects[3].Add(Mea);
            subjects[3].Add(EC_2);
            subjects[3].Add(E_2);
            subjects[3].Add(TR);
            subjects[4].Add(DSD);
            subjects[4].Add(DS);
            subjects[4].Add(NS);
            subjects[4].Add(Comm_1);
            subjects[4].Add(ES);
            subjects[4].Add(ET);
            subjects[5].Add(DM);
            subjects[5].Add(OOP);
            subjects[5].Add(CA);
            subjects[5].Add(Mach);
            subjects[5].Add(Comm_2);
            subjects[6].Add(ps);
            subjects[6].Add(dbs);
            subjects[6].Add(iim);
            subjects[6].Add(acsy);
            subjects[6].Add(comal);
            subjects[6].Add(lancomp);
            subjects[7].Add(info);
            subjects[7].Add(c_gra);
            subjects[7].Add(op_sys);
            subjects[7].Add(m_c_e);
            subjects[7].Add(m_a_s);
            subjects[7].Add(d_o_m_c);
            subjects[8].Add(AI);
            subjects[8].Add(CN_1);
            subjects[8].Add(SE);
            subjects[8].Add(ECP);
            subjects[8].Add(PR);
            subjects[8].Add(DISD);
            subjects[9].Add(CS);
            subjects[9].Add(DaSe);
            subjects[9].Add(CN_2);
            subjects[9].Add(NN);
            subjects[9].Add(RE);
            subjects[9].Add(ITDIS);
            Test.GetGrade(subjects);
            Console.In.ReadLine();

            Console.In.Read();




        }
    }
}

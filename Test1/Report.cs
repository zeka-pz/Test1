using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Report
    {
        //public string[] headNames = new string[] { "ID", "Прізвище", "Ім’я", "По батькові", "Дата народження", "Посада", "Підрозділ (відділ)", "Номер кімнати", "Службовий телефон", "Місячний оклад", "Дата прийняття на роботу", "Поле для приміток" };

        public int[] maxColumnLengs = new int[] { 4, 12, 10, 12, 10, 12, 12, 7, 9, 8, 10, 8 };
        public string[] headNames = new string[] { "ID", "Прізвище", "Ім’я", "По\nбатькові", "Дата\nнародження", "Посада", "Підрозділ\n(відділ)", "Номер\nкімнати", "Службовий\nтелефон", "Місячний\nоклад", "Дата\nприйняття\nна роботу", "Поле\nдля\nприміток" };
        
        public int GetAllLengthOfReport()
        {
            int allLength = 0;
            foreach (int x in maxColumnLengs)
                allLength += x + 3;   // +3 , бо добалено "|  |"

            allLength += 1;           //Остання "|"

            return allLength;
        }

        public void PrintString(string[] columnValues, bool replaceEnter = true)
        {

            bool offTrans;
            int maxLeng;
            string columnValue;
            int endPosition;

            do
            {
                offTrans = true;

                Console.WriteLine();

                for (int i = 0; i <= columnValues.Length - 1; i++)
                {
                    maxLeng = maxColumnLengs[i];
                    columnValue = columnValues[i].Trim();
                    
                    if (replaceEnter == true)
                       if (columnValue.IndexOf("\n") >= 0)
                            columnValue = columnValue.Replace("\n", " ");

                    endPosition = columnValue.IndexOf("\n");

                    if (endPosition == -1 | endPosition > maxLeng)
                        endPosition = Math.Min(columnValue.Length, maxLeng);
                    
                    columnValues[i] = columnValue.Substring(endPosition);

                    if (columnValue.Length > maxLeng)
                        offTrans = false;

                    string res = "";

                    if (i == 0) res = "|";
                    res += " " + columnValue.Substring(0, endPosition).PadRight(maxLeng, ' ') + " |";

                    Console.Write(res);
                }

            }
            while (offTrans == false);


        }

        public void PrintHead()
        {
            int allLength = GetAllLengthOfReport();
            Console.Write(new string('-', allLength));
            PrintString(headNames, false);
            Console.Write("\n"+new string('-', allLength));
        }

        //public void ViewReport(object mas)
        //{
        //    PrintHead();
        //}




    }





}


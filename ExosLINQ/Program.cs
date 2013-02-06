using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQDataContext;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext LinqDataContext = new DataContext();

            #region Partie 1
            #region Exo 1.1
            //var qResult = LinqDataContext.Students.Select(s => new
            //{
            //    nom = string.Format("{0} {1}", s.First_Name, s.Last_Name),
            //    ddn = s.BirthDate,
            //    login = s.Login,
            //    yrResult = s.Year_Result
            //});

            //foreach (var s in qResult)
            //{
            //    Console.WriteLine(s.nom + " | " + s.ddn + " | " + s.login + " | " + s.yrResult);
            //}
            #endregion
            #region Exo 1.2
            //var qResult = LinqDataContext.Students.Select(s => new
            //{
            //    nom = string.Format("{0} {1}", s.First_Name, s.Last_Name),
            //    id = s.Student_ID,
            //    ddn = s.BirthDate
            //});

            //foreach (var s in qResult)
            //{
            //    Console.WriteLine(string.Format("{0} | {1} | {2}", s.nom, s.id, s.ddn));
            //}
            #endregion
            #region Exo 1.3
            //var qResult = LinqDataContext.Students.Select(s => new
            //{
            //    info = string.Format("{0} | {1} | {2} | {3} | {4} | {5} | {6} | {7}",
            //    s.Student_ID,
            //    s.First_Name,
            //    s.Last_Name,
            //    s.Login,
            //    s.BirthDate,
            //    s.Course_ID,
            //    s.Section_ID,
            //    s.Year_Result
            //    )
            //});

            //foreach (var s in qResult)
            //{
            //    Console.WriteLine(s.info);
            //}
            #endregion
            #endregion

            #region Partie 2
            #region Exo 2.1
            //var qResult = LinqDataContext.Students.Where(s => s.BirthDate.Year < 1955)
            //    .Select(s => new
            //    {
            //        nom = string.Format("{0} {1}", s.First_Name, s.Last_Name),
            //        yrResult = s.Year_Result,
            //        status = studentStatus(s.Year_Result)
            //    });

            //foreach (var s in qResult)
            //{
            //    Console.WriteLine(string.Format("{0} | {1} | {2}", s.nom, s.yrResult, s.status));
            //}
            #endregion
            #region Exo 2.2
            //var qResult = LinqDataContext.Students.Where(s => s.BirthDate.Year >= 1955 && s.BirthDate.Year <= 1965)
            //    .Select(s => new
            //    {
            //        nom = string.Format("{0} {1}", s.First_Name, s.Last_Name),
            //        yrResult = s.Year_Result,
            //        cat = studentCat(s.Year_Result)
            //    });

            //foreach (var s in qResult)
            //{
            //    Console.WriteLine(string.Format("{0} | {1} | {2} | {3}", s.nom, s.yrResult, s.cat));
            //}
            #endregion
            #region Exo 2.3
            //var qResult = LinqDataContext.Students.Where(s => checkLastLetter(s.Last_Name, 'r'))
            //    .Select(s => new
            //    {
            //        nom = s.Last_Name,
            //        section = s.Section_ID
            //    });

            //foreach (var s in qResult)
            //{
            //    Console.WriteLine(s.nom + " | " + s.section);
            //}
            #endregion
            #region Exo 2.4
            //var qResult = LinqDataContext.Students.Where(s => s.Year_Result <= 3)
            //    .Select(s => new
            //    {
            //        nom = string.Format("{0} {1}", s.First_Name, s.Last_Name),
            //        result = s.Year_Result
            //    })
            //    .OrderByDescending(s => s.result);

            //foreach (var s in qResult)
            //{
            //    Console.WriteLine(s.nom + " | " + s.result);
            //}
            #endregion
            #region Exo 2.5
            //var qResult = LinqDataContext.Students
            //    .Where(s => s.Section_ID == 1110)
            //    .Select(s => new
            //    {
            //        nom = string.Format("{0} {1}", s.Last_Name, s.First_Name),
            //        yrResult = s.Year_Result
            //    })
            //    .OrderBy(s => s.nom);

            //foreach (var s in qResult)
            //    Console.WriteLine(s.nom + " | " + s.yrResult);
            #endregion
            #region Exo 2.6
            //var qResult = LinqDataContext.Students
            //    .Where(s => (s.Section_ID == 1010 || s.Section_ID == 1020) && (s.Year_Result < 12 || s.Year_Result > 18))
            //    .Select(s => new
            //    {
            //        nom = s.Last_Name,
            //        section = s.Section_ID,
            //        yrResult = s.Year_Result
            //    })
            //    .OrderBy(s => s.yrResult);

            //foreach (var s in qResult)
            //    Console.WriteLine(string.Format("{0} | {1} | {2}", s.nom, s.section, s.yrResult));
            #endregion
            #region Exo 2.7
            //var qResult = LinqDataContext.Students
            //    .Where(s => (s.Section_ID >= 1300 && s.Section_ID < 1400) && resultOn100(s.Year_Result) <= 60)
            //    .Select(s => new
            //    {
            //        nom = s.Last_Name,
            //        section = s.Section_ID,
            //        result_100 = resultOn100(s.Year_Result)
            //    })
            //    .OrderByDescending(s => s.result_100);

            //foreach (var s in qResult)
            //    Console.WriteLine(string.Format("{0} | {1} | {2}", s.nom, s.section, s.result_100));
            #endregion
            #endregion

            #region Partie 3
            #region Exo 3.1
            //int qResult = (int)(LinqDataContext.Students
            //    .Select(s => s.Year_Result).ToList().Average());
            //Console.WriteLine(qResult);
            #endregion
            #region Exo 3.2
            //int qResult = LinqDataContext.Students.Select(s => s.Year_Result).Max();
            //Console.WriteLine(qResult);
            #endregion
            #region Exo 3.3
            //Console.WriteLine(LinqDataContext.Students.Select(s => s.Year_Result).Sum());
            #endregion
            #region Exo 3.4
            //Console.WriteLine(LinqDataContext.Students.Select(s => s.Year_Result).Min());
            #endregion
            #region Exo 3.5
            //Console.WriteLine(LinqDataContext.Students.Where(s => s.Year_Result % 2 == 1).Count());
            #endregion
            #endregion

            #region Partie 4
            #region Exo 4.1
            //var qResult = LinqDataContext.Students.GroupBy(s => s.Section_ID);

            //foreach (var section in qResult)
            //{
            //    Console.WriteLine("Résultat maximum pour la section {0} : {1}", section.Key, section.Select(s => s.Year_Result).Max());
            //}
            #endregion
            #region Exo 4.2
            var qResult = LinqDataContext.Students.Where(s => s.Section_ID >= 1000 && s.Section_ID < 1100).GroupBy(s => s.Section_ID);

            foreach (var section in qResult)
            {
                Console.WriteLine(string.Format("Moyenne pour la section {0} : {1}", section.Key, Math.Round(section.Select(s => s.Year_Result).Average(), 2)));
            }
            #endregion
            #region Exo 4.3

            #endregion
            #endregion

            Console.ReadKey();
        }

        #region Méthodes
        static int resultOn100(int yrResult)
        {
            return (int)((double)yrResult / 20 * 100);
        }

        static string studentCat(int yrResult)
        {
            if (yrResult < 10)
                return "Inférieur";
            else if (yrResult == 10)
                return "Neutre";
            else
                return "Supérieur";
        }

        static string studentStatus(int yrResult)
        {
            if (yrResult >= 12)
                return "OK";
            else
                return "KO";
        }

        static bool checkLastLetter(string s, char c)
        {
            char lastLetter = s.ElementAt(s.Length - 1);
            return lastLetter == c ? true : false;
        }
        #endregion
    }
}

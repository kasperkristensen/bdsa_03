using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment03
{
    public class Queries
    {
        public static IEnumerable<string> QueryRowlingWizardsLINQ()
        {
            var result = from Wizard w in Wizard.Wizards.Value where w.Creator.Equals("J. K. Rowling") select w.Name;    
            return result;
        }

        public static IEnumerable<string> QueryRowlingWizardsExt()
        {
            var result = Wizard.Wizards.Value.Where(w => w.Creator.Equals("J. K. Rowling")).Select(w => w.Name);  
            return result;
        }

        public static int QueryDarthExt()
        {
            var result = Wizard.Wizards.Value.Where(w => w.Name.Contains("Darth")).Select(w => w.Year).Min();
            return (int)result;                          
        }

        public static int QueryDarthLINQ()
        {
             var result = (from Wizard w in Wizard.Wizards.Value where w.Name.Contains("Darth") select w.Year).Min();    
            return (int)result;                        
        }

        public static IEnumerable<Tuple<string, int>> QueryAllWizardsFromHPLINQ()
        {
            var result = (from Wizard w in Wizard.Wizards.Value where w.Medium.Contains("Harry Potter") select new Tuple<string, int> (w.Name, (int) w.Year));    
            return result.Distinct();                        
        }

        public static IEnumerable<Tuple<string, int>> QueryAllWizardsFromHPExt()
        {
            var result = Wizard.Wizards.Value.Where(w => w.Medium.Contains("Harry Potter")).Select(w => new Tuple<string, int> (w.Name, (int) w.Year));
            return result.Distinct();
        }

        public static IEnumerable<string> QueryGroupedLINQ()
        {
            var result = (from Wizard w in Wizard.Wizards.Value 
                        orderby w.Creator.ToLower() descending, w.Name descending
                        select w.Name);   

            return result.ToList();                        
        }

        public static IEnumerable<string> QueryGroupedExt()
        {
            var result = Wizard.Wizards.Value.OrderByDescending(w => w.Creator)
            .ThenByDescending(w => w.Name)
            .GroupBy(w => w.Creator).SelectMany(g => g).Select(w => w.Name);

            return result;
        }
    }
}
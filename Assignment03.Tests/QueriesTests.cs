using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void rowling_LINQ()
        {
            var expected = new List<string>() {
                "Harry Potter", "Hermione Granger",
                "Ron Weasly", "Albus Dumbledore",
                "Severus Snape", "Draco Malfoy",
            };

            var actual = Queries.QueryRowlingWizardsLINQ();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void rowling_ext()
        {
            var expected = new List<string>() {
                "Harry Potter", "Hermione Granger",
                "Ron Weasly", "Albus Dumbledore",
                "Severus Snape", "Draco Malfoy",
            };

            var actual = Queries.QueryRowlingWizardsExt();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void darth_LINQ()
        {
            var expected = 1977;

            var actual = Queries.QueryDarthLINQ();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void darth_ext()
        {
            var expected = 1977;

            var actual = Queries.QueryDarthExt();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void all_wizards_from_hp_ext()
        {
            var expected = new List<Tuple<string, int>>();
            
            expected.Add(new Tuple<string, int>("Harry Potter", 1997));
            expected.Add(new Tuple<string, int>("Hermione Granger", 1997));
            expected.Add(new Tuple<string, int>("Ron Weasly", 1997));
            expected.Add(new Tuple<string, int>("Albus Dumbledore", 1997));
            expected.Add(new Tuple<string, int>("Severus Snape", 1997));
            expected.Add(new Tuple<string, int>("Draco Malfoy", 1997));

            var actual = Queries.QueryAllWizardsFromHPExt();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void all_wizards_from_hp_LINQ()
        {
            var expected = new List<Tuple<string, int>>();
            
            expected.Add(new Tuple<string, int>("Harry Potter", 1997));
            expected.Add(new Tuple<string, int>("Hermione Granger", 1997));
            expected.Add(new Tuple<string, int>("Ron Weasly", 1997));
            expected.Add(new Tuple<string, int>("Albus Dumbledore", 1997));
            expected.Add(new Tuple<string, int>("Severus Snape", 1997));
            expected.Add(new Tuple<string, int>("Draco Malfoy", 1997));

            var actual = Queries.QueryAllWizardsFromHPLINQ();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void grouped_ext()
        {
            var expected = new List<string>();
            expected.Add("Sauron");
            expected.Add("Gandalf");
            expected.Add("Severus Snape");
            expected.Add("Ron Weasly");
            expected.Add("Hermione Granger");
            expected.Add("Harry Potter");
            expected.Add("Draco Malfoy");
            expected.Add("Albus Dumbledore");
            expected.Add("Darth Vader");
            expected.Add("Darth Maul");

            var actual = Queries.QueryGroupedExt();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void grouped_LINQ()
        {
            var expected = new List<string>();
            expected.Add("Sauron");
            expected.Add("Gandalf");
            expected.Add("Severus Snape");
            expected.Add("Ron Weasly");
            expected.Add("Hermione Granger");
            expected.Add("Harry Potter");
            expected.Add("Draco Malfoy");
            expected.Add("Albus Dumbledore");
            expected.Add("Darth Vader");
            expected.Add("Darth Maul");

            var actual = Queries.QueryGroupedLINQ();

            Assert.Equal(expected, actual);
        }
    }
}
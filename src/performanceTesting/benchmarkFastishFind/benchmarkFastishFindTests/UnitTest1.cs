using benchmarkFastishFind;
using FluentAssertions;
using System;
using Xunit;

namespace benchmarkFastishFindTests
{
    public class UnitTest1
    {
        [Fact]
        public void FindByTreeBruteForcePersonFirstOne()
        {
            FindObjectInArray finder = new FindObjectInArray();
            string targetName = "Person1";

            finder.PopulatePeopleList();
            Person p = finder.FindByManualParallelTasksByProcessorCount(targetName);
            p.Should().NotBeNull();
            p.Name.Should().Be(targetName);
        }

        [Fact]
        public void FindByTreeBruteForcePersonMiddle()
        {
            FindObjectInArray finder = new FindObjectInArray();
            string targetName = "Person" + (finder.ListSize / 2);

            finder.PopulatePeopleList();
            Person p = finder.FindByManualParallelTasksByProcessorCount(targetName);
            p.Should().NotBeNull();
            p.Name.Should().Be(targetName);
        }

        [Fact]
        public void FindByTreeBruteForcePersonLast()
        {
            FindObjectInArray finder = new FindObjectInArray();
            string targetName = "Person" + (finder.ListSize - 1);

            finder.PopulatePeopleList();
            Person p = finder.FindByManualParallelTasksByProcessorCount(targetName);
            p.Should().NotBeNull();
            p.Name.Should().Be(targetName);
        }

        [Fact]
        public void FindByTreeBruteForcePersonOnePastLast()
        {
            FindObjectInArray finder = new FindObjectInArray();
            string targetName = "Person" + (finder.ListSize + 1);

            finder.PopulatePeopleList();
            Person p = finder.FindByManualParallelTasksByProcessorCount(targetName);
            p.Should().BeNull();
        }

        [Fact]
        public void FindByTreeBruteForcePerson1()
        {
            string targetName = "Person1";
            FindObjectInArray finder = new FindObjectInArray();
            finder.PopulatePeopleList();
            Person p = finder.FindByManualParallelTasksByProcessorCount(targetName);
            p.Should().NotBeNull();
            p.Name.Should().Be(targetName);
        }

        [Fact]
        public void FindByTreeBruteForcePerson2()
        {
            string targetName = "Person2";
            FindObjectInArray finder = new FindObjectInArray();
            finder.PopulatePeopleList();
            Person p = finder.FindByManualParallelTasksByProcessorCount(targetName);
            p.Should().NotBeNull();
            p.Name.Should().Be(targetName);
        }

        [Fact]
        public void FindByTreeBruteForcePerson99()
        {
            string targetName = "Person99";
            FindObjectInArray finder = new FindObjectInArray();
            finder.PopulatePeopleList();
            Person p = finder.FindByManualParallelTasksByProcessorCount(targetName);
            p.Should().NotBeNull();
            p.Name.Should().Be(targetName);
        }

        [Fact]
        public void FindByTreeBruteForcePerson100()
        {
            string targetName = "Person100";
            FindObjectInArray finder = new FindObjectInArray();
            finder.PopulatePeopleList();
            Person p = finder.FindByManualParallelTasksByProcessorCount(targetName);
            p.Should().NotBeNull();
            p.Name.Should().Be(targetName);
        }

        [Fact]
        public void FindByTreeBruteForcePerson200()
        {
            string targetName = "Person200";
            FindObjectInArray finder = new FindObjectInArray();
            finder.PopulatePeopleList();
            Person p = finder.FindByManualParallelTasksByProcessorCount(targetName);
            p.Should().NotBeNull();
            p.Name.Should().Be(targetName);
        }

        [Fact]
        public void FindByTreeBruteForcePerson499()
        {
            string targetName = "Person499";
            FindObjectInArray finder = new FindObjectInArray();
            finder.PopulatePeopleList();
            Person p = finder.FindByManualParallelTasksByProcessorCount(targetName);
            p.Should().NotBeNull();
            p.Name.Should().Be(targetName);
        }

        [Fact]
        public void FindByTreeBruteForcePerson500()
        {
            string targetName = "Person500";
            FindObjectInArray finder = new FindObjectInArray();
            finder.PopulatePeopleList();
            Person p = finder.FindByManualParallelTasksByProcessorCount(targetName);
            p.Should().NotBeNull();
            p.Name.Should().Be(targetName);
        }

        [Fact]
        public void FindByTreeBruteForcePerson999()
        {
            string targetName = "Person999";
            FindObjectInArray finder = new FindObjectInArray();
            finder.PopulatePeopleList();
            Person p = finder.FindByManualParallelTasksByProcessorCount(targetName);
            p.Should().NotBeNull();
            p.Name.Should().Be(targetName);
        }

        //[Fact]
        //public void FindByTreeBruteForcePerson1000()
        //{
        //    string targetName = "Person1000";
        //    FindObjectInArray finder = new FindObjectInArray();
        //    finder.PopulatePeopleList();
        //    Person p = finder.FindByTreeBruteForce(targetName);
        //    p.Should().NotBeNull();
        //    p.Name.Should().Be(targetName);
        //}

        //[Fact]
        //public void FindByTreeBruteForcePerson99999999999()
        //{
        //    string targetName = "Person9999999999999";
        //    FindObjectInArray finder = new FindObjectInArray();
        //    finder.PopulatePeopleList();
        //    Person p = finder.FindByTreeBruteForce(targetName);
        //    p.Should().BeNull();
        //}
    }
}

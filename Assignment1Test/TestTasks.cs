using System;
using System.Collections.Generic;
using System.Text;
using Assignment1;
using Xunit;

namespace Assignment1Test
{
    public class TestTasks
    {

        /*******************************************************************
        * Task 1
        ******************************************************************/
        [Fact]
        public void TestAnEmptyString()
        {
            string input = "";
            string expected = "";

            Assert.Equal(expected, Tasks.Reverse(input));
        }

        [Fact]
        public void TestAWord()
        {
            const string input = "robot";
            const string expected = "tobor";

            Assert.Equal(expected, Tasks.Reverse(input));
        }

        [Fact]
        public void TestACapitalizedWord()
        {
            const string input = "Ramen";
            const string expected = "nemaR";

            Assert.Equal(expected, Tasks.Reverse(input));
        }

        [Fact]
        public void TestASentenceWithPunctuation()
        {
            const string input = "I'm hungry!";
            const string expected = "!yrgnuh m'I";

            Assert.Equal(expected, Tasks.Reverse(input));
        }

        [Fact]
        public void TestAPalindrome()
        {
            const string input = "racecar";
            const string expected = "racecar";

            Assert.Equal(expected, Tasks.Reverse(input));
        }

        /*******************************************************************
        * Task 2
        ******************************************************************/
        [Fact]
        public void Basic()
        {
            const string phrase = "Portable Network Graphics";
            const string expected = "PNG";

            Assert.Equal(expected, Tasks.Acronym(phrase));
        }

        [Fact]
        public void Punctuation()
        {
            const string phrase = "First In, First Out";
            const string expected = "FIFO";

            Assert.Equal(expected, Tasks.Acronym(phrase));
        }

        [Fact]
        public void NonAcronymAllCapsWord()
        {
            const string phrase = "GNU Image Manipulation Program";
            const string expected = "GIMP";

            Assert.Equal(expected, Tasks.Acronym(phrase));
        }

        [Fact]
        public void PunctuationWithoutWhitespace()
        {
            const string phrase = "Complementary metal-oxide semiconductor";
            const string expected = "CMOS";

            Assert.Equal(expected, Tasks.Acronym(phrase));
        }

        /*******************************************************************
        * Task 3
        ******************************************************************/

        [Fact]
        public void trianglesWithNoEqualSidesAreNotEquilateral()
        {
            Tasks.Triangle triangle = new Tasks.Triangle(5, 4, 6);
            Assert.False(triangle.IsEquilateral());
        }

        [Fact]
        public void verySmallTrianglesCanBeEquilateral()
        {
            Tasks.Triangle triangle = new Tasks.Triangle(0.5, 0.5, 0.5);
            Assert.True(triangle.IsEquilateral());
        }

        [Fact]
        public void isoscelesTrianglesMustHaveAtLeastTwoEqualSides()
        {
            Tasks.Triangle triangle = new Tasks.Triangle(2, 3, 4);
            Assert.False(triangle.IsIsosceles());
        }

        [Fact]
        public void verySmallTrianglesCanBeIsosceles()
        {
            Tasks.Triangle triangle = new Tasks.Triangle(0.5, 0.4, 0.5);
            Assert.True(triangle.IsIsosceles());
        }

        [Fact]
        public void trianglesWithAllSidesEqualAreNotScalene()
        {
            Tasks.Triangle triangle = new Tasks.Triangle(4, 4, 4);
            Assert.False(triangle.IsScalene());
        }

        [Fact]
        public void verySmallTrianglesCanBeScalene()
        {
            Tasks.Triangle triangle = new Tasks.Triangle(0.5, 0.4, 0.6);
            Assert.True(triangle.IsScalene());
        }

        /*******************************************************************
        * Task 4
        ******************************************************************/


        /*******************************************************************
        * Task 5
        ******************************************************************/

        /*******************************************************************
        * Task 6
        ******************************************************************/

        /*******************************************************************
        * Task 7
        ******************************************************************/

        /*******************************************************************
        * Task 8
        ******************************************************************/

        /*******************************************************************
        * Task 9
        ******************************************************************/

        /*******************************************************************
        * Task 10
        ******************************************************************/

        /*******************************************************************
        * Task 11
        ******************************************************************/

        /*******************************************************************
        * Task 12
        ******************************************************************/

        /*******************************************************************
        * Task 13
        ******************************************************************/

        /*******************************************************************
        * Task 14
        ******************************************************************/

        /*******************************************************************
        * Task 15
        ******************************************************************/

        /*******************************************************************
        * Task 16
        ******************************************************************/

        /*******************************************************************
        * Task 17
        ******************************************************************/

        /*******************************************************************
        * Task 18
        ******************************************************************/

        /*******************************************************************
        * Task 19
        ******************************************************************/

        /*******************************************************************
        * Task 20
        ******************************************************************/
    }
}

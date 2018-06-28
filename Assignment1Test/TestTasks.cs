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
        public void TestAnEmptystring()
        {
            string input = "";
            string expected = "";
            string result = Tasks.Reverse(input);

            Assert.Equal(expected, result);
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

        ///*******************************************************************
        //* Task 3
        //******************************************************************/

        [Fact]
        public void TrianglesWithNoEqualSidesAreNotEquilateral()
        {
            Tasks.Triangle triangle = new Tasks.Triangle(5, 4, 6);
            Assert.False(triangle.IsEquilateral());
        }

        [Fact]
        public void VerySmallTrianglesCanBeEquilateral()
        {
            Tasks.Triangle triangle = new Tasks.Triangle(0.5, 0.5, 0.5);
            Assert.True(triangle.IsEquilateral());
        }

        [Fact]
        public void IsoscelesTrianglesMustHaveAtLeastTwoEqualSides()
        {
            Tasks.Triangle triangle = new Tasks.Triangle(2, 3, 4);
            Assert.False(triangle.IsIsosceles());
        }

        [Fact]
        public void VerySmallTrianglesCanBeIsosceles()
        {
            Tasks.Triangle triangle = new Tasks.Triangle(0.5, 0.4, 0.5);
            Assert.True(triangle.IsIsosceles());
        }

        [Fact]
        public void TrianglesWithAllSidesEqualAreNotScalene()
        {
            Tasks.Triangle triangle = new Tasks.Triangle(4, 4, 4);
            Assert.False(triangle.IsScalene());
        }

        [Fact]
        public void VerySmallTrianglesCanBeScalene()
        {
            Tasks.Triangle triangle = new Tasks.Triangle(0.5, 0.4, 0.6);
            Assert.True(triangle.IsScalene());
        }

        ///*******************************************************************
        //* Task 4
        //******************************************************************/

        [Fact]
        public void TestAValuableLetter()
        {
            Assert.Equal(4, Tasks.GetScrabbleScore("f"));
        }

        [Fact]
        public void TestAShortValuableWord()
        {
            Assert.Equal(12, Tasks.GetScrabbleScore("zoo"));
        }

        [Fact]
        public void TestAMediumWord()
        {
            Assert.Equal(6, Tasks.GetScrabbleScore("street"));
        }

        [Fact]
        public void TestAMediumValuableWord()
        {
            Assert.Equal(22, Tasks.GetScrabbleScore("quirky"));
        }

        [Fact]
        public void TestALongMixCaseWord()
        {
            Assert.Equal(41, Tasks.GetScrabbleScore("OxyphenButazone"));
        }

        ///*******************************************************************
        //* Task 5
        //******************************************************************/

        [Fact]
        public void CleansTheNumber()
        {
            const string expectedNumber = "2234567890";
            string actualNumber = Tasks.CleanPhoneNumber("(223) 456-7890");
            Assert.Equal(expectedNumber, actualNumber);
        }

        [Fact]
        public void CleansNumbersWithDots()
        {
            const string expectedNumber = "2234567890";
            string actualNumber = Tasks.CleanPhoneNumber("223.456.7890");
            Assert.Equal(expectedNumber, actualNumber);
        }

        [Fact]
        public void CleansNumbersWithMultipleSpaces()
        {
            const string expectedNumber = "2234567890";
            string actualNumber = Tasks.CleanPhoneNumber("223 456   7890   ");
            Assert.Equal(expectedNumber, actualNumber);
        }

        [Fact]
        public void InvalidWhenMoreThan11Digits()
        {
            Assert.Throws<ArgumentException>(() => Tasks.CleanPhoneNumber("321234567890"));
        }

        [Fact]
        public void InvalidWithNonNumeric()
        {
            Assert.Throws<ArgumentException>(() => Tasks.CleanPhoneNumber("123-abc-7890"));
            Assert.Throws<ArgumentException>(() => Tasks.CleanPhoneNumber("123-@:!-7890"));
        }

        ///*******************************************************************
        //* Task 6
        //******************************************************************/

        [Fact]
        public void CountOneWord()
        {
            IDictionary<string, int> expectedWordCount = new Dictionary<string, int>()
            {
                ["word"] = 1
            };

            IDictionary<string, int> actualWordCount = Tasks.WordCount("word");
            Assert.Equal(expectedWordCount, actualWordCount);
        }

        [Fact]
        public void CountOneOfEachWord()
        {
            IDictionary<string, int> expectedWordCount = new Dictionary<string, int>()
            {
                ["one"] = 1,
                ["of"] = 1,
                ["each"] = 1
            };


            IDictionary<string, int> actualWordCount = Tasks.WordCount("one of each");
            Assert.Equal(expectedWordCount, actualWordCount);
        }

        [Fact]
        public void MultipleOccurrencesOfAWord()
        {
            IDictionary<string, int> expectedWordCount = new Dictionary<string, int>()
            {
                ["one"] = 1,
                ["fish"] = 4,
                ["two"] = 1,
                ["red"] = 1,
                ["blue"] = 1
            };


            IDictionary<string, int> actualWordCount = Tasks.WordCount("one fish two fish red fish blue fish");
            Assert.Equal(expectedWordCount, actualWordCount);
        }

        [Fact]
        public void HandlesCrampedLists()
        {
            IDictionary<string, int> expectedWordCount = new Dictionary<string, int>()
            {
                ["one"] = 1,
                ["two"] = 1,
                ["three"] = 1
            };

            IDictionary<string, int> actualWordCount = Tasks.WordCount("one,two,three");
            Assert.Equal(expectedWordCount, actualWordCount);
        }

        [Fact]
        public void HandlesExpandedLists()
        {
            IDictionary<string, int> expectedWordCount = new Dictionary<string, int>()
            {
                ["one"] = 1,
                ["two"] = 1,
                ["three"] = 1
            };

            IDictionary<string, int> actualWordCount = Tasks.WordCount("one,\ntwo,\nthree");
            Assert.Equal(expectedWordCount, actualWordCount);
        }


        ///*******************************************************************
        //     * Question 7
        //     ******************************************************************/
        //[Fact]
        //public void findsAValueInTheMiddleOfAnArray()
        //{
        //    List<string> sortedList = new List<string>() { "1", "3", "4", "6", "8", "9", "11" };
        //    Tasks.BinarySearch<string> search = new Tasks.BinarySearch<string>(sortedList);

        //    Assert.Equal(3, search.IndexOf("6"));
        //}

        //[Fact]
        //public void findsAValueAtTheBeginningOfAnArray()
        //{
        //    List<int> sortedList = new List<int>() { 1, 3, 4, 6, 8, 9, 11 };
        //    Tasks.BinarySearch<int> search = new Tasks.BinarySearch<int>(sortedList);

        //    Assert.Equal(0, search.IndexOf(1));
        //}

        //[Fact]
        //public void findsAValueAtTheEndOfAnArray()
        //{
        //    List<int> sortedList = new List<int>() { 1, 3, 4, 6, 8, 9, 11 };
        //    Tasks.BinarySearch<int> search = new Tasks.BinarySearch<int>(sortedList);

        //    Assert.Equal(6, search.IndexOf(11));
        //}

        //[Fact]
        //public void findsAValueInAnArrayOfOddLength()
        //{
        //    List<int> sortedListOfOddLength = new List<int>() { 1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 634 };
        //    Tasks.BinarySearch<int> search = new Tasks.BinarySearch<int>(sortedListOfOddLength);

        //    Assert.Equal(9, search.IndexOf(144));
        //}

        //[Fact]
        //public void findsAValueInAnArrayOfEvenLength()
        //{
        //    List<int> sortedListOfEvenLength = new List<int>() { 1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };
        //    Tasks.BinarySearch<int> search = new Tasks.BinarySearch<int>(sortedListOfEvenLength);

        //    Assert.Equal(5, search.IndexOf(21));
        //}

        ///*******************************************************************
        // * Question 8
        // ******************************************************************/

        //[Fact]
        //public void testWordBeginningWithA()
        //{
        //    Assert.Equal("appleay", Tasks.ToPigLatin("apple"));
        //}

        //[Fact]
        //public void testThTreatedLikeAConsonantAtTheBeginningOfAWord()
        //{
        //    Assert.Equal("erapythay", Tasks.ToPigLatin("therapy"));
        //}

        //[Fact]
        //public void testSchTreatedLikeAConsonantAtTheBeginningOfAWord()
        //{
        //    Assert.Equal("oolschay", Tasks.ToPigLatin("school"));
        //}

        //[Fact]
        //public void testYTreatedLikeAConsonantAtTheBeginningOfAWord()
        //{
        //    Assert.Equal("ellowyay", Tasks.ToPigLatin("yellow"));
        //}

        //[Fact]
        //public void testAWholePhrase()
        //{
        //    Assert.Equal("ickquay astfay unray", Tasks.ToPigLatin("quick fast run"));
        //}

        ///*******************************************************************
        // * Question 9
        // ******************************************************************/

        //[Fact]
        //public void singleDigitsAreArmstrongNumbers()
        //{
        //    int input = 5;

        //    Assert.True(Tasks.IsArmstrongNumber(input));
        //}

        //[Fact]
        //public void noTwoDigitArmstrongNumbers()
        //{
        //    int input = 10;

        //    Assert.False(Tasks.IsArmstrongNumber(input));
        //}

        //[Fact]
        //public void threeDigitNumberIsArmstrongNumber()
        //{
        //    int input = 153;

        //    Assert.True(Tasks.IsArmstrongNumber(input));
        //}

        //[Fact]
        //public void threeDigitNumberIsNotArmstrongNumber()
        //{
        //    int input = 100;

        //    Assert.False(Tasks.IsArmstrongNumber(input));
        //}

        //[Fact]
        //public void fourDigitNumberIsArmstrongNumber()
        //{
        //    int input = 9474;

        //    Assert.True(Tasks.IsArmstrongNumber(input));
        //}

        ///*******************************************************************
        // * Question 10
        // ******************************************************************/

        //[Fact]
        //public void testPrimeNumber()
        //{
        //    Assert.Equal(new List<long> { 2L }, Tasks.CalculatePrimeFactorsOf(2L));
        //}

        //[Fact]
        //public void testSquareOfAPrime()
        //{
        //    Assert.Equal(new List<long> { 3L, 3L }, Tasks.CalculatePrimeFactorsOf(9L));
        //}

        //[Fact]
        //public void testCubeOfAPrime()
        //{
        //    Assert.Equal(new List<long> { 2L, 2L, 2L }, Tasks.CalculatePrimeFactorsOf(8L));
        //}

        //[Fact]
        //public void testProductOfPrimesAndNonPrimes()
        //{
        //    Assert.Equal(new List<long> { 2L, 2L, 3L }, Tasks.CalculatePrimeFactorsOf(12L));
        //}

        //[Fact]
        //public void testProductOfPrimes()
        //{
        //    Assert.Equal(new List<long> { 5L, 17L, 23L, 461L }, Tasks.CalculatePrimeFactorsOf(901255L));
        //}

        ///*******************************************************************
        // * Question 11
        // ******************************************************************/

        //[Fact]
        //public void RotateSingleCharacterWithWrapAround()
        //{
        //    Tasks.RotationalCipher rotationalCipher = new Tasks.RotationalCipher(13);
        //    Assert.Equal("a", rotationalCipher.Rotate("n"));
        //}

        //[Fact]
        //public void RotateCapitalLetters()
        //{
        //    Tasks.RotationalCipher rotationalCipher = new Tasks.RotationalCipher(5);
        //    Assert.Equal("TRL", rotationalCipher.Rotate("OMG"));
        //}

        //[Fact]
        //public void RotateNumbers()
        //{
        //    Tasks.RotationalCipher rotationalCipher = new Tasks.RotationalCipher(4);
        //    Assert.Equal("Xiwxmrk 1 2 3 xiwxmrk", rotationalCipher.Rotate("Testing 1 2 3 testing"));
        //}

        //[Fact]
        //public void RotatePunctuation()
        //{
        //    Tasks.RotationalCipher rotationalCipher = new Tasks.RotationalCipher(21);
        //    Assert.Equal("Gzo'n zvo, Bmviyhv!", rotationalCipher.Rotate("Let's eat, Grandma!"));
        //}

        //[Fact]
        //public void RotateAllLetters()
        //{
        //    Tasks.RotationalCipher rotationalCipher = new Tasks.RotationalCipher(13);
        //    Assert.Equal("The quick brown fox jumps over the lazy dog.",
        //            rotationalCipher.Rotate("Gur dhvpx oebja sbk whzcf bire gur ynml qbt."));
        //}

        ///*******************************************************************
        // * Question 12
        // ******************************************************************/

        //[Fact]
        //public void TestFirstPrime()
        //{
        //    Assert.Equal(2, Tasks.CalculateNthPrime(1));
        //}

        //[Fact]
        //public void TestSecondPrime()
        //{
        //    Assert.Equal(3, Tasks.CalculateNthPrime(2));
        //}

        //[Fact]
        //public void TestSixthPrime()
        //{
        //    Assert.Equal(13, Tasks.CalculateNthPrime(6));
        //}

        //[Fact]
        //public void TestBigPrime()
        //{
        //    Assert.Equal(104743, Tasks.CalculateNthPrime(10001));
        //}

        //[Fact]
        //public void TestUndefinedPrime()
        //{
        //    Assert.Throws<ArgumentException>(() => Tasks.CalculateNthPrime(0));
        //}

        ///*******************************************************************
        // * Question 13
        // ******************************************************************/

        //[Fact]
        //public void TestEncodeYes()
        //{
        //    Assert.Equal("bvh", Tasks.AtbashCipher.Encode("yes"));
        //}

        //[Fact]
        //public void TestEncodeOmgInCapital()
        //{
        //    Assert.Equal("lnt", Tasks.AtbashCipher.Encode("OMG"));
        //}

        //[Fact]
        //public void TestEncodeMindBlowingly()
        //{
        //    Assert.Equal("nrmwy oldrm tob", Tasks.AtbashCipher.Encode("mindblowingly"));
        //}

        //[Fact]
        //public void TestEncodeNumbers()
        //{
        //    Assert.Equal("gvhgr mt123 gvhgr mt", Tasks.AtbashCipher.Encode("Testing,1 2 3, testing."));
        //}

        //[Fact]
        //public void TestEncodeDeepThought()
        //{
        //    Assert.Equal("gifgs rhurx grlm", Tasks.AtbashCipher.Encode("Truth is fiction."));
        //}

        //[Fact]
        //public void TestEncodeAllTheLetters()
        //{
        //    Assert.Equal("gsvjf rxpyi ldmul cqfnk hlevi gsvoz abwlt",
        //            Tasks.AtbashCipher.Encode("The quick brown fox jumps over the lazy dog."));
        //}

        ///*******************************************************************
        // * Question 14
        // ******************************************************************/
        //[Fact]
        //public void testDecodeExercism()
        //{
        //    Assert.Equal("exercism", Tasks.AtbashCipher.Decode("vcvix rhn"));
        //}

        //[Fact]
        //public void testDecodeASentence()
        //{
        //    Assert.Equal("anobstacleisoftenasteppingstone",
        //            Tasks.AtbashCipher.Decode("zmlyh gzxov rhlug vmzhg vkkrm thglm v"));
        //}

        //[Fact]
        //public void testDecodeNumbers()
        //{
        //    Assert.Equal("testing123testing", Tasks.AtbashCipher.Decode("gvhgr mt123 gvhgr mt"));
        //}

        //[Fact]
        //public void testDecodeAllTheLetters()
        //{
        //    Assert.Equal("thequickbrownfoxjumpsoverthelazydog",
        //            Tasks.AtbashCipher.Decode("gsvjf rxpyi ldmul cqfnk hlevi gsvoz abwlt"));
        //}

        ///*******************************************************************
        // * Question 15
        // ******************************************************************/

        //[Fact]
        //public void ValidIsbnNumber()
        //{
        //    Assert.True(Tasks.IsValidIsbn("3-598-21508-8"));
        //}

        //[Fact]
        //public void InvalidIsbnCheckDigit()
        //{
        //    Assert.False(Tasks.IsValidIsbn("3-598-21508-9"));
        //}

        //[Fact]
        //public void ValidIsbnNumberWithCheckDigitOfTen()
        //{
        //    Assert.True(Tasks.IsValidIsbn("3-598-21507-X"));
        //}

        //[Fact]
        //public void CheckDigitIsACharacterOtherThanX()
        //{
        //    Assert.False(Tasks.IsValidIsbn("3-598-21507-A"));
        //}

        //[Fact]
        //public void InvalidCharacterInIsbn()
        //{
        //    Assert.False(Tasks.IsValidIsbn("3-598-2K507-0"));
        //}

        ///*******************************************************************
        // * Question 16
        // ******************************************************************/

        //[Fact]
        //public void emptySentenceIsNotPangram()
        //{
        //    Assert.False(Tasks.IsPangram(""));
        //}

        //[Fact]
        //public void recognizesPerfectLowerCasePangram()
        //{
        //    Assert.True(Tasks.IsPangram("abcdefghijklmnopqrstuvwxyz"));
        //}

        //[Fact]
        //public void pangramWithOnlyLowerCaseLettersIsRecognizedAsPangram()
        //{
        //    Assert.True(Tasks.IsPangram("the quick brown fox jumps over the lazy dog"));
        //}

        //[Fact]
        //public void phraseMissingCharacterXIsNotPangram()
        //{
        //    Assert.False(Tasks.IsPangram("a quick movement of the enemy will jeopardize five gunboats"));
        //}

        //[Fact]
        //public void phraseMissingAnotherCharacterIsNotPangram()
        //{
        //    Assert.False(Tasks.IsPangram("five boxing wizards jump quickly at it"));
        //}

        ///*******************************************************************
        // * Question 17
        // ******************************************************************/
        //[Fact]
        //public void ModernTime()
        //{
        //    Assert.Equal(new DateTime(2043, 1, 1, 1, 46, 40),
        //            Tasks.GetGigasecondDate(new DateTime(2011, 4, 25)));
        //}

        //[Fact]
        //public void AfterEpochTime()
        //{
        //    Assert.Equal(new DateTime(2009, 2, 19, 1, 46, 40),
        //            Tasks.GetGigasecondDate(new DateTime(1977, 6, 13)));
        //}

        //[Fact]
        //public void BeforeEpochTime()
        //{
        //    Assert.Equal(new DateTime(1991, 3, 27, 1, 46, 40),
        //            Tasks.GetGigasecondDate(new DateTime(1959, 7, 19)));
        //}

        //[Fact]
        //public void WithFullTimeSpecified()
        //{
        //    Assert.Equal(new DateTime(2046, 10, 2, 23, 46, 40),
        //            Tasks.GetGigasecondDate(new DateTime(2015, 1, 24, 22, 0, 0)));
        //}

        //[Fact]
        //public void WithFullTimeSpecifiedAndDayRollover()
        //{
        //    Assert.Equal(new DateTime(2046, 10, 3, 1, 46, 39),
        //            Tasks.GetGigasecondDate(new DateTime(2015, 1, 24, 23, 59, 59)));
        //}

        ///*******************************************************************
        // * Question 18
        // ******************************************************************/

        //[Fact]
        //public void TestSumOfMultiplesOf4and6UpToFifteen()
        //{

        //    int[] set = { 4, 6 };
        //    int output = Tasks.GetSumOfMultiples(15, set);
        //    Assert.Equal(30, output);

        //}

        //[Fact]
        //public void TestSumOfMultiplesOf5and6and8UpToOneHundredFifty()
        //{

        //    int[] set = { 5, 6, 8 };
        //    int output = Tasks.GetSumOfMultiples(150, set);
        //    Assert.Equal(4419, output);

        //}

        //[Fact]
        //public void TestSumOfMultiplesOf5and25UpToFiftyOne()
        //{

        //    int[] set = { 5, 25 };
        //    int output = Tasks.GetSumOfMultiples(51, set);
        //    Assert.Equal(275, output);

        //}

        //[Fact]
        //public void TestSumOfMultiplesOf43and47UpToTenThousand()
        //{

        //    int[] set = { 43, 47 };
        //    int output = Tasks.GetSumOfMultiples(10000, set);
        //    Assert.Equal(2203160, output);

        //}

        //[Fact]
        //public void TestSumOfMultiplesOfOneUpToOneHundred()
        //{

        //    int[] set = { 1 };
        //    int output = Tasks.GetSumOfMultiples(100, set);
        //    Assert.Equal(4950, output);

        //}

        ///*******************************************************************
        // * Question 19
        // ******************************************************************/

        //[Fact]
        //public void TestThatAValidCanadianSocialInsuranceNumberIsIdentifiedAsValidV1()
        //{
        //    Assert.True(Tasks.IsLuhnValid("046 454 286"));
        //}

        //[Fact]
        //public void TestThatAnInvalidCanadianSocialInsuranceNumberIsIdentifiedAsInvalid()
        //{
        //    Assert.False(Tasks.IsLuhnValid("046 454 287"));
        //}

        //[Fact]
        //public void TestThatAnInvalidCreditCardIsIdentifiedAsInvalid()
        //{
        //    Assert.False(Tasks.IsLuhnValid("8273 1232 7352 0569"));
        //}

        //[Fact]
        //public void TestThatAddingANonDigitCharacterToAValidstringInvalidatesThestring()
        //{
        //    Assert.False(Tasks.IsLuhnValid("046a 454 286"));
        //}

        //[Fact]
        //public void TestThatstringContainingPunctuationIsInvalid()
        //{
        //    Assert.False(Tasks.IsLuhnValid("055-444-285"));
        //}

        ///*******************************************************************
        // * Question 20
        // ******************************************************************/

        //[Fact]
        //public void testSingleAddition1()
        //{
        //    Assert.Equal(2, Tasks.SolveWordProblem("What is 1 plus 1?"));
        //}

        //[Fact]
        //public void testSingleAdditionWithNegativeNumbers()
        //{
        //    Assert.Equal(-11, Tasks.SolveWordProblem("What is -1 plus -10?"));
        //}

        //[Fact]
        //public void testSingleSubtraction()
        //{
        //    Assert.Equal(16, Tasks.SolveWordProblem("What is 4 minus -12?"));
        //}

        //[Fact]
        //public void testSingleMultiplication()
        //{
        //    Assert.Equal(-75, Tasks.SolveWordProblem("What is -3 multiplied by 25?"));
        //}

        //[Fact]
        //public void testSingleDivision()
        //{
        //    Assert.Equal(-11, Tasks.SolveWordProblem("What is 33 divided by -3?"));
        //}

    }
}

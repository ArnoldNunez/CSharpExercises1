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

        /*******************************************************************
        * Task 4
        ******************************************************************/

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

        /*******************************************************************
        * Task 5
        ******************************************************************/

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
            // TODO: Implement this message
            // expectedException.expect(IllegalArgumentException.class);
            //Tasks.CleanPhoneNumber("321234567890");
        }

        [Fact]
        public void InvalidWithNonNumeric()
        {
            // TODO: Implement this message
            // expectedException.expect(IllegalArgumentException.class);
            //Tasks.CleanPhoneNumber("123-abc-7890");
            //expectedException.expect(IllegalArgumentException.class);
            //Tasks.CleanPhoneNumber("123-@:!-7890");
        }

        /*******************************************************************
        * Task 6
        ******************************************************************/

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


        /*******************************************************************
             * Question 7
             ******************************************************************/
        //[Fact]
        //    public void findsAValueInTheMiddleOfAnArray()
        //{
        //    List<string> sortedList = Collections.unmodifiableList(Arrays.asList("1", "3", "4", "6", "8", "9", "11"));

        //    Tasks.BinarySearch<string> search = new Tasks.BinarySearch<>(sortedList);

        //    Assert.Equal(3, search.indexOf("6"));
        //}

        //[Fact]
        //    public void findsAValueAtTheBeginningOfAnArray()
        //{
        //    List<int> sortedList = Collections.unmodifiableList(Arrays.asList(1, 3, 4, 6, 8, 9, 11));

        //    Tasks.BinarySearch<int> search = new Tasks.BinarySearch<>(sortedList);

        //    Assert.Equal(0, search.indexOf(1));
        //}

        //[Fact]
        //    public void findsAValueAtTheEndOfAnArray()
        //{
        //    List<int> sortedList = Collections.unmodifiableList(Arrays.asList(1, 3, 4, 6, 8, 9, 11));

        //    Tasks.BinarySearch<int> search = new Tasks.BinarySearch<>(sortedList);

        //    Assert.Equal(6, search.indexOf(11));
        //}

        //[Fact]
        //    public void findsAValueInAnArrayOfOddLength()
        //{
        //    List<int> sortedListOfOddLength = Collections
        //            .unmodifiableList(Arrays.asList(1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 634));

        //    Tasks.BinarySearch<int> search = new Tasks.BinarySearch<>(sortedListOfOddLength);

        //    Assert.Equal(9, search.indexOf(144));
        //}

        //[Fact]
        //    public void findsAValueInAnArrayOfEvenLength()
        //{
        //    List<int> sortedListOfEvenLength = Collections
        //            .unmodifiableList(Arrays.asList(1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377));

        //    Tasks.BinarySearch<int> search = new Tasks.BinarySearch<>(sortedListOfEvenLength);

        //    Assert.Equal(5, search.indexOf(21));
        //}

        /*******************************************************************
         * Question 8
         ******************************************************************/
        //[Fact]
        //    public void testWordBeginningWithA()
        //{
        //    Assert.Equal("appleay", Tasks.toPigLatin("apple"));
        //}

        //[Fact]
        //    public void testThTreatedLikeAConsonantAtTheBeginningOfAWord()
        //{
        //    Assert.Equal("erapythay", Tasks.toPigLatin("therapy"));
        //}

        //[Fact]
        //    public void testSchTreatedLikeAConsonantAtTheBeginningOfAWord()
        //{
        //    Assert.Equal("oolschay", Tasks.toPigLatin("school"));
        //}

        //[Fact]
        //    public void testYTreatedLikeAConsonantAtTheBeginningOfAWord()
        //{
        //    Assert.Equal("ellowyay", Tasks.toPigLatin("yellow"));
        //}

        //[Fact]
        //    public void testAWholePhrase()
        //{
        //    Assert.Equal("ickquay astfay unray", Tasks.toPigLatin("quick fast run"));
        //}

        /*******************************************************************
         * Question 9
         ******************************************************************/
        //[Fact]
        //    public void singleDigitsAreArmstrongNumbers()
        //{
        //    int input = 5;

        //    assertTrue(Tasks.isArmstrongNumber(input));
        //}

        //[Fact]
        //    public void noTwoDigitArmstrongNumbers()
        //{
        //    int input = 10;

        //    assertFalse(Tasks.isArmstrongNumber(input));
        //}

        //[Fact]
        //    public void threeDigitNumberIsArmstrongNumber()
        //{
        //    int input = 153;

        //    assertTrue(Tasks.isArmstrongNumber(input));
        //}

        //[Fact]
        //    public void threeDigitNumberIsNotArmstrongNumber()
        //{
        //    int input = 100;

        //    assertFalse(Tasks.isArmstrongNumber(input));
        //}

        //[Fact]
        //    public void fourDigitNumberIsArmstrongNumber()
        //{
        //    int input = 9474;

        //    assertTrue(Tasks.isArmstrongNumber(input));
        //}

        /*******************************************************************
         * Question 10
         ******************************************************************/

        //[Fact]
        //    public void testPrimeNumber()
        //{
        //    Assert.Equal(Collections.singletonList(2L), Tasks.calculatePrimeFactorsOf(2L));
        //}

        //[Fact]
        //    public void testSquareOfAPrime()
        //{
        //    Assert.Equal(Arrays.asList(3L, 3L), Tasks.calculatePrimeFactorsOf(9L));
        //}

        //[Fact]
        //    public void testCubeOfAPrime()
        //{
        //    Assert.Equal(Arrays.asList(2L, 2L, 2L), Tasks.calculatePrimeFactorsOf(8L));
        //}

        //[Fact]
        //    public void testProductOfPrimesAndNonPrimes()
        //{
        //    Assert.Equal(Arrays.asList(2L, 2L, 3L), Tasks.calculatePrimeFactorsOf(12L));
        //}

        //[Fact]
        //    public void testProductOfPrimes()
        //{
        //    Assert.Equal(Arrays.asList(5L, 17L, 23L, 461L), Tasks.calculatePrimeFactorsOf(901255L));
        //}

        /*******************************************************************
         * Question 11
         ******************************************************************/

        //[Fact]
        //    public void rotateSingleCharacterWithWrapAround()
        //{
        //    Tasks.RotationalCipher rotationalCipher = new Tasks.RotationalCipher(13);
        //    Assert.Equal("a", rotationalCipher.rotate("n"));
        //}

        //[Fact]
        //    public void rotateCapitalLetters()
        //{
        //    Tasks.RotationalCipher rotationalCipher = new Tasks.RotationalCipher(5);
        //    Assert.Equal("TRL", rotationalCipher.rotate("OMG"));
        //}

        //[Fact]
        //    public void rotateNumbers()
        //{
        //    Tasks.RotationalCipher rotationalCipher = new Tasks.RotationalCipher(4);
        //    Assert.Equal("Xiwxmrk 1 2 3 xiwxmrk", rotationalCipher.rotate("Testing 1 2 3 testing"));
        //}

        //[Fact]
        //    public void rotatePunctuation()
        //{
        //    Tasks.RotationalCipher rotationalCipher = new Tasks.RotationalCipher(21);
        //    Assert.Equal("Gzo'n zvo, Bmviyhv!", rotationalCipher.rotate("Let's eat, Grandma!"));
        //}

        //[Fact]
        //    public void rotateAllLetters()
        //{
        //    Tasks.RotationalCipher rotationalCipher = new Tasks.RotationalCipher(13);
        //    Assert.Equal("The quick brown fox jumps over the lazy dog.",
        //            rotationalCipher.rotate("Gur dhvpx oebja sbk whzcf bire gur ynml qbt."));
        //}

        /*******************************************************************
         * Question 12
         ******************************************************************/
        //[Fact]
        //    public void testFirstPrime()
        //{
        //    assertThat(Tasks.calculateNthPrime(1), is (2));
        //}

        //[Fact]
        //    public void testSecondPrime()
        //{
        //    assertThat(Tasks.calculateNthPrime(2), is (3));
        //}

        //[Fact]
        //    public void testSixthPrime()
        //{
        //    assertThat(Tasks.calculateNthPrime(6), is (13));
        //}

        //[Fact]
        //    public void testBigPrime()
        //{
        //    assertThat(Tasks.calculateNthPrime(10001), is (104743));
        //}

        //[Fact]
        //    public void testUndefinedPrime()
        //{
        //    expectedException.expect(IllegalArgumentException.class);
        //		Tasks.calculateNthPrime(0);
        //	}

        /*******************************************************************
         * Question 13
         ******************************************************************/

        //	[Fact]
        //    public void testEncodeYes()
        //{
        //    Assert.Equal("bvh", Tasks.AtbashCipher.encode("yes"));
        //}

        //[Fact]
        //    public void testEncodeOmgInCapital()
        //{
        //    Assert.Equal("lnt", Tasks.AtbashCipher.encode("OMG"));
        //}

        //[Fact]
        //    public void testEncodeMindBlowingly()
        //{
        //    Assert.Equal("nrmwy oldrm tob", Tasks.AtbashCipher.encode("mindblowingly"));
        //}

        //[Fact]
        //    public void testEncodeNumbers()
        //{
        //    Assert.Equal("gvhgr mt123 gvhgr mt", Tasks.AtbashCipher.encode("Testing,1 2 3, testing."));
        //}

        //[Fact]
        //    public void testEncodeDeepThought()
        //{
        //    Assert.Equal("gifgs rhurx grlm", Tasks.AtbashCipher.encode("Truth is fiction."));
        //}

        //[Fact]
        //    public void testEncodeAllTheLetters()
        //{
        //    Assert.Equal("gsvjf rxpyi ldmul cqfnk hlevi gsvoz abwlt",
        //            Tasks.AtbashCipher.encode("The quick brown fox jumps over the lazy dog."));
        //}

        /*******************************************************************
         * Question 14
         ******************************************************************/
        //[Fact]
        //    public void testDecodeExercism()
        //{
        //    Assert.Equal("exercism", Tasks.AtbashCipher.decode("vcvix rhn"));
        //}

        //[Fact]
        //    public void testDecodeASentence()
        //{
        //    Assert.Equal("anobstacleisoftenasteppingstone",
        //            Tasks.AtbashCipher.decode("zmlyh gzxov rhlug vmzhg vkkrm thglm v"));
        //}

        //[Fact]
        //    public void testDecodeNumbers()
        //{
        //    Assert.Equal("testing123testing", Tasks.AtbashCipher.decode("gvhgr mt123 gvhgr mt"));
        //}

        //[Fact]
        //    public void testDecodeAllTheLetters()
        //{
        //    Assert.Equal("thequickbrownfoxjumpsoverthelazydog",
        //            Tasks.AtbashCipher.decode("gsvjf rxpyi ldmul cqfnk hlevi gsvoz abwlt"));
        //}

        /*******************************************************************
         * Question 15
         ******************************************************************/
        //[Fact]
        //    public void validIsbnNumber()
        //{
        //    assertTrue(Tasks.isValidIsbn("3-598-21508-8"));
        //}

        //[Fact]
        //    public void invalidIsbnCheckDigit()
        //{
        //    assertFalse(Tasks.isValidIsbn("3-598-21508-9"));
        //}

        //[Fact]
        //    public void validIsbnNumberWithCheckDigitOfTen()
        //{
        //    assertTrue(Tasks.isValidIsbn("3-598-21507-X"));
        //}

        //[Fact]
        //    public void checkDigitIsACharacterOtherThanX()
        //{
        //    assertFalse(Tasks.isValidIsbn("3-598-21507-A"));
        //}

        //[Fact]
        //    public void invalidCharacterInIsbn()
        //{
        //    assertFalse(Tasks.isValidIsbn("3-598-2K507-0"));
        //}

        /*******************************************************************
         * Question 16
         ******************************************************************/
        //[Fact]
        //    public void emptySentenceIsNotPangram()
        //{
        //    assertFalse(Tasks.isPangram(""));
        //}

        //[Fact]
        //    public void recognizesPerfectLowerCasePangram()
        //{
        //    assertTrue(Tasks.isPangram("abcdefghijklmnopqrstuvwxyz"));
        //}

        //[Fact]
        //    public void pangramWithOnlyLowerCaseLettersIsRecognizedAsPangram()
        //{
        //    assertTrue(Tasks.isPangram("the quick brown fox jumps over the lazy dog"));
        //}

        //[Fact]
        //    public void phraseMissingCharacterXIsNotPangram()
        //{
        //    assertFalse(Tasks.isPangram("a quick movement of the enemy will jeopardize five gunboats"));
        //}

        //[Fact]
        //    public void phraseMissingAnotherCharacterIsNotPangram()
        //{
        //    assertFalse(Tasks.isPangram("five boxing wizards jump quickly at it"));
        //}

        /*******************************************************************
         * Question 17
         ******************************************************************/
        //[Fact]
        //    public void modernTime()
        //{
        //    Assert.Equal(LocalDateTime.of(2043, Month.JANUARY, 1, 1, 46, 40),
        //            Tasks.getGigasecondDate(LocalDate.of(2011, Month.APRIL, 25)));
        //}

        //[Fact]
        //    public void afterEpochTime()
        //{
        //    Assert.Equal(LocalDateTime.of(2009, Month.FEBRUARY, 19, 1, 46, 40),
        //            Tasks.getGigasecondDate(LocalDate.of(1977, Month.JUNE, 13)));
        //}

        //[Fact]
        //    public void beforeEpochTime()
        //{
        //    Assert.Equal(LocalDateTime.of(1991, Month.MARCH, 27, 1, 46, 40),
        //            Tasks.getGigasecondDate(LocalDate.of(1959, Month.JULY, 19)));
        //}

        //[Fact]
        //    public void withFullTimeSpecified()
        //{
        //    Assert.Equal(LocalDateTime.of(2046, Month.OCTOBER, 2, 23, 46, 40),
        //            Tasks.getGigasecondDate(LocalDateTime.of(2015, Month.JANUARY, 24, 22, 0, 0)));
        //}

        //[Fact]
        //    public void withFullTimeSpecifiedAndDayRollover()
        //{
        //    Assert.Equal(LocalDateTime.of(2046, Month.OCTOBER, 3, 1, 46, 39),
        //            Tasks.getGigasecondDate(LocalDateTime.of(2015, Month.JANUARY, 24, 23, 59, 59)));
        //}

        /*******************************************************************
         * Question 18
         ******************************************************************/
        //[Fact]
        //    public void testSumOfMultiplesOf4and6UpToFifteen()
        //{

        //    int[] set = { 4, 6 };
        //    int output = Tasks.getSumOfMultiples(15, set);
        //    Assert.Equal(30, output);

        //}

        //[Fact]
        //    public void testSumOfMultiplesOf5and6and8UpToOneHundredFifty()
        //{

        //    int[] set = { 5, 6, 8 };
        //    int output = Tasks.getSumOfMultiples(150, set);
        //    Assert.Equal(4419, output);

        //}

        //[Fact]
        //    public void testSumOfMultiplesOf5and25UpToFiftyOne()
        //{

        //    int[] set = { 5, 25 };
        //    int output = Tasks.getSumOfMultiples(51, set);
        //    Assert.Equal(275, output);

        //}

        //[Fact]
        //    public void testSumOfMultiplesOf43and47UpToTenThousand()
        //{

        //    int[] set = { 43, 47 };
        //    int output = Tasks.getSumOfMultiples(10000, set);
        //    Assert.Equal(2203160, output);

        //}

        //[Fact]
        //    public void testSumOfMultiplesOfOneUpToOneHundred()
        //{

        //    int[] set = { 1 };
        //    int output = Tasks.getSumOfMultiples(100, set);
        //    Assert.Equal(4950, output);

        //}

        /*******************************************************************
         * Question 19
         ******************************************************************/
        //[Fact]
        //    public void testThatAValidCanadianSocialInsuranceNumberIsIdentifiedAsValidV1()
        //{
        //    assertTrue(Tasks.isLuhnValid("046 454 286"));
        //}

        //[Fact]
        //    public void testThatAnInvalidCanadianSocialInsuranceNumberIsIdentifiedAsInvalid()
        //{
        //    assertFalse(Tasks.isLuhnValid("046 454 287"));
        //}

        //[Fact]
        //    public void testThatAnInvalidCreditCardIsIdentifiedAsInvalid()
        //{
        //    assertFalse(Tasks.isLuhnValid("8273 1232 7352 0569"));
        //}

        //[Fact]
        //    public void testThatAddingANonDigitCharacterToAValidstringInvalidatesThestring()
        //{
        //    assertFalse(Tasks.isLuhnValid("046a 454 286"));
        //}

        //[Fact]
        //    public void testThatstringContainingPunctuationIsInvalid()
        //{
        //    assertFalse(Tasks.isLuhnValid("055-444-285"));
        //}

        /*******************************************************************
         * Question 20
         ******************************************************************/
        //[Fact]
        //    public void testSingleAddition1()
        //{
        //    Assert.Equal(2, Tasks.solveWordProblem("What is 1 plus 1?"));
        //}

        //[Fact]
        //    public void testSingleAdditionWithNegativeNumbers()
        //{
        //    Assert.Equal(-11, Tasks.solveWordProblem("What is -1 plus -10?"));
        //}

        //[Fact]
        //    public void testSingleSubtraction()
        //{
        //    Assert.Equal(16, Tasks.solveWordProblem("What is 4 minus -12?"));
        //}

        //[Fact]
        //    public void testSingleMultiplication()
        //{
        //    Assert.Equal(-75, Tasks.solveWordProblem("What is -3 multiplied by 25?"));
        //}

        //[Fact]
        //    public void testSingleDivision()
        //{
        //    Assert.Equal(-11, Tasks.solveWordProblem("What is 33 divided by -3?"));
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace Assignment1
{
    /** Can use these for debugging in tests **/
    //Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
    //Trace.WriteLine("*******" + someString + "**********");

    /// <summary>
    /// Contains the tasks to accomplisth.
    /// </summary>
    public class Tasks
    {

        /// <summary>
        /// 
        /// 1. Without using the StringBuilder class, write a 
        ///     method that reverses a String. Example: reverse("example");
        ///     -> "elpmaxe"
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Reverse(string str)
        {
            char[] strCharArrRev = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                strCharArrRev[i] = str[str.Length - 1 - i];
            }

            return new string(strCharArrRev);
        }


        /// <summary>
        /// 
        /// 2. Convert a string to its acronym. Techies love
        ///     their TLA (Three Letter Acronyms)! Help generate some jargon by
        ///     writing a program that converts a long name like Portable
        ///     Network Graphics to its acronym (PNG).
        /// 
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public static string Acronym(string phrase)
        {
            StringBuilder acro = new StringBuilder();
            string whiteSpaceRegex = @"\s+";    // Regex to match whitespaces (any number of them together)

            // hyphens count as 2 words
            string[] words = Regex.Split(phrase.Trim().Replace("-", " "), whiteSpaceRegex);

            // Iterate through words and get first char
            foreach (string word in words)
            {
                acro.Append(word[0]);
            }

            return acro.ToString().ToUpper();
        }

        /// <summary>
        /// 
        /// 3. Determine if a triangle is equilateral, isosceles, or scalene. An
	    ///    equilateral triangle has all three sides the same length.An isosceles
	    ///    triangle has at least two sides the same length. (It is sometimes specified
	    ///    as having exactly two sides the same length, but for the purposes of this
	    ///    exercise we'll say at least two.) A scalene triangle has all sides of
	    ///    ifferent lengths.
        /// 
        /// </summary>
        public class Triangle
        {
            // Auto implemented properties
            public double SideOne { get; set; }
            public double SideTwo { get; set; }
            public double SideThree { get; set; }

            public Triangle() : base() { }

            public Triangle(double sideOne, double sideTwo, double sideThree)
            {
                SideOne = sideOne;
                SideTwo = sideTwo;
                SideThree = sideThree;
            }

            public bool IsEquilateral()
            {
                return (SideOne == SideTwo && SideTwo == SideThree);
            }

            public bool IsIsosceles()
            {
                return (SideOne == SideTwo || SideTwo == SideThree || SideOne == SideThree);
            }

            public bool IsScalene()
            {
                return (SideOne != SideTwo && SideTwo != SideThree && SideOne != SideThree); ;
            }
        }


        /// <summary>
        /// 
        /// 4. Given a word, compute the scrabble score for that word.
	    ///    
	    ///    --Letter Values-- Letter Value A, E, I, O, U, L, N, R, S, T = 1; D, G = 2; B,
	    ///    C, M, P = 3; F, H, V, W, Y = 4; K = 5; J, X = 8; Q, Z = 10; Examples
        ///    "cabbage" should be scored as worth 14 points:
	    ///    
	    ///    3 points for C, 1 point for A, twice 3 points for B, twice 2 points for G, 1
	    ///    point for E And to total:
	    ///    
	    ///    3 + 2*1 + 2*3 + 2 + 1 = 3 + 2 + 6 + 3 = 5 + 9 = 14
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int GetScrabbleScore(string str)
        {
            int score = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char letter = char.ToLower(str[i]);

                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'l':
                    case 'n':
                    case 'r':
                    case 's':
                    case 't':
                        {
                            score += 1;
                            break;
                        }
                    case 'd':
                    case 'g':
                        {
                            score += 2;
                            break;
                        }

                    case 'b':
                    case 'c':
                    case 'm':
                    case 'p':
                        {
                            score += 3;
                            break;
                        }
                    case 'f':
                    case 'h':
                    case 'v':
                    case 'w':
                    case 'y':
                        {
                            score += 4;
                            break;
                        }
                    case 'k':
                        {
                            score += 5;
                            break;
                        }

                    case 'j':
                    case 'x':
                        {
                            score += 8;
                            break;
                        }

                    case 'q':
                    case 'z':
                        {
                            score += 10;
                            break;
                        }
                }
            }

            return score;
        }


        /**
	     * 5. Clean up user-entered phone numbers so that they can be sent SMS messages.
	     * 
	     * The North American Numbering Plan (NANP) is a telephone numbering system used
	     * by many countries in North America like the United States, Canada or Bermuda.
	     * All NANP-countries share the same international country code: 1.
	     * 
	     * NANP numbers are ten-digit numbers consisting of a three-digit Numbering Plan
	     * Area code, commonly known as area code, followed by a seven-digit local
	     * number. The first three digits of the local number represent the exchange
	     * code, followed by the unique four-digit number which is the subscriber
	     * number.
	     * 
	     * The format is usually represented as
	     * 
	     * 1 (NXX)-NXX-XXXX where N is any digit from 2 through 9 and X is any digit
	     * from 0 through 9.
	     * 
	     * Your task is to clean up differently formatted telephone numbers by removing
	     * punctuation and the country code (1) if present.
	     * 
	     * For example, the inputs
	     * 
	     * +1 (613)-995-0253 613-995-0253 1 613 995 0253 613.995.0253 should all produce
	     * the output
	     * 
	     * 6139950253
	     * 
	     * Note: As this exercise only deals with telephone numbers used in
	     * NANP-countries, only 1 is considered a valid country code.
	     */
        public static string CleanPhoneNumber(string str)
        {
            string result = str;

            // Validate input
            Match match = Regex.Match(result, @"[^\s()+0-9.-]");

            // If we found non-allowed char, throw exceptions
            if (match.Success == true)
            {
                throw new ArgumentException("Incorrect phone format");
            }
            else
            {
                // Remove anything thats not a number
                string digits = Regex.Replace(result.Trim(), @"\D", "");

                if (digits.Length == 11)
                {
                    return digits.Substring(1);
                }
                else if (digits.Length == 10)
                {
                    return digits;
                }
                else
                {
                    throw new ArgumentException("Incorrect phone format");
                }
            }
        }


        /**
	     * 6. Given a phrase, count the occurrences of each word in that phrase.
	     * 
	     * For example for the input "olly olly in come free" olly: 2 in: 1 come: 1
	     * free: 1
	     * 
	     * @param string
	     * @return
	     */
        public static IDictionary<string, int> WordCount(string str)
        {
            IDictionary<string, int> wordCount = new Dictionary<string, int>();

            // Remove newlines from a string
            string oneLine = str.Replace(Environment.NewLine, "").Replace("\n", "");

            // Remove punctaion and split on words
            string[] words = Regex.Replace(oneLine.Trim(), @"[^\sa-zA-Z,]", "").Split(new[] { ',', ' ' });
            
            foreach (string word in words)
            {
                // Word already in dictionary, increment it
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word] += 1;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
            }

            return wordCount;
        }



        /**
	     * 7. Implement a binary search algorithm.
	     * 
	     * Searching a sorted collection is a common task. A dictionary is a sorted list
	     * of word definitions. Given a word, one can find its definition. A telephone
	     * book is a sorted list of people's names, addresses, and telephone numbers.
	     * Knowing someone's name allows one to quickly find their telephone number and
	     * address.
	     * 
	     * If the list to be searched contains more than a few items (a dozen, say) a
	     * binary search will require far fewer comparisons than a linear search, but it
	     * imposes the requirement that the list be sorted.
	     * 
	     * In computer science, a binary search or half-interval search algorithm finds
	     * the position of a specified input value (the search "key") within an array
	     * sorted by key value.
	     * 
	     * In each step, the algorithm compares the search key value with the key value
	     * of the middle element of the array.
	     * 
	     * If the keys match, then a matching element has been found and its index, or
	     * position, is returned.
	     * 
	     * Otherwise, if the search key is less than the middle element's key, then the
	     * algorithm repeats its action on the sub-array to the left of the middle
	     * element or, if the search key is greater, on the sub-array to the right.
	     * 
	     * If the remaining array to be searched is empty, then the key cannot be found
	     * in the array and a special "not found" indication is returned.
	     * 
	     * A binary search halves the number of items to check with each iteration, so
	     * locating an item (or determining its absence) takes logarithmic time. A
	     * binary search is a dichotomic divide and conquer search algorithm.
	     * 
	     */
        public class BinarySearch<T> where T : IComparable<T>
        {
            private List<T> sortedList;
            // Property
            public List<T> SortedList
            {
                get { return sortedList; }
                set
                {
                    // Copy list so we don't accidently modify list
                    sortedList = new List<T>(value);
                }
            }

            public int IndexOf(T t)
            {
                int leftNdx = 0;
                int rightNdx = SortedList.Count - 1;
                int searchLoc;
                T value;

                while (leftNdx <= rightNdx)
                {
                    searchLoc = leftNdx + ((rightNdx - leftNdx) / 2);
                    value = SortedList[searchLoc];

                    if (t.CompareTo(value) < 0)
                    {
                        // t is less than value at search location - Look to left
                        // We subtract 1 because we know that the value at serachLoc
                        // is not the value we are looking for so don't include it in the next
                        // iteration.
                        rightNdx = searchLoc - 1;
                    }
                    else if (t.CompareTo(value) > 0)
                    {
                        // t is greater than value at serach location - Look to right
                        leftNdx = searchLoc + 1;
                    }
                    else
                    {
                        // t equals value at serach location, we are done!
                        return searchLoc;
                    }
                }

                return -1;
            }

            public BinarySearch() { }
            public BinarySearch(List<T> sList)
            {
                SortedList = sList;
            }
        }

        /**
         * 8. Implement a program that translates from English to Pig Latin.
         * 
         * Pig Latin is a made-up children's language that's intended to be confusing.
         * It obeys a few simple rules (below), but when it's spoken quickly it's really
         * difficult for non-children (and non-native speakers) to understand.
         * 
         * Rule 1: If a word begins with a vowel sound, add an "ay" sound to the end of
         * the word. Rule 2: If a word begins with a consonant sound, move it to the end
         * of the word, and then add an "ay" sound to the end of the word. There are a
         * few more rules for edge cases, and there are regional variants too.
         * 
         * See http://en.wikipedia.org/wiki/Pig_latin for more details.
         * 
         * @param string
         * @return
         */
        public static string ToPigLatin(string str)
        {
            String AY = "ay";

            List<char> vowelList = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            string lowStr = str.ToLower();
            string[] splitStr = lowStr.Split(" ");

            // Iterate over words
            for (int i = 0; i < splitStr.Length; i++)
            {
                if (vowelList.Contains(splitStr[i][0]))
                {
                    // We have a vowel sound
                    splitStr[i] = splitStr[i] + AY;
                }
                else
                {
                    // We have a consonant sound
                    int vowelNdx = -1;
                    char[] word = splitStr[i].ToCharArray();

                    

                    // Find first occurance of vowel if any
                    for (int j = 0; j < word.Length; ++j)
                    {
                        if (vowelList.Contains(word[j]))
                        {
                            // qu is an exception in pig latin
                            if (word[j] == 'u' && j > 0 && word[j - 1] == 'q')
                            {

                            }
                            else
                            {
                                vowelNdx = j;
                                break;
                            }
                        }
                    }

                    // Word does actually have a vowel
                    if (vowelNdx != -1)
                    {
                        string first = splitStr[i].Substring(0, vowelNdx);
                        string last = splitStr[i].Substring(vowelNdx);
                        splitStr[i] = last + first + AY;
                    }
                    else
                    {
                        // No vowel in word, simply add ay to end
                        splitStr[i] = splitStr[i] + AY;
                    }

                }
            }

            // Make the new string
            StringBuilder strBld = new StringBuilder();
            foreach (string word in splitStr)
            {
                strBld.Append(word).Append(" ");
            }

            return strBld.ToString().Trim();
        }


        /**
         * 9. An Armstrong number is a number that is the sum of its own digits each
         * raised to the power of the number of digits.
         * 
         * For example:
         * 
         * 9 is an Armstrong number, because 9 = 9^1 = 9 10 is not an Armstrong number,
         * because 10 != 1^2 + 0^2 = 2 153 is an Armstrong number, because: 153 = 1^3 +
         * 5^3 + 3^3 = 1 + 125 + 27 = 153 154 is not an Armstrong number, because: 154
         * != 1^3 + 5^3 + 4^3 = 1 + 125 + 64 = 190 Write some code to determine whether
         * a number is an Armstrong number.
         * 
         * @param input
         * @return
         */
        public static bool IsArmstrongNumber(int input)
        {
            // Get the number of digits from input
            char[] IndividualInts = input.ToString().ToCharArray();

            // Iterate through digits and raise each to power
            double sum = 0;
            int numInts = IndividualInts.Length;
            double charToDoub;
            for (int i = 0; i < numInts; i++)
            {
                // Add result to sum
                charToDoub = Char.GetNumericValue(IndividualInts[i]);
                sum += Math.Pow(charToDoub, numInts);
            }

            // Check if sum == input
            if (sum == input)
            {
                return true;
            }

            return false;
        }


        /**
         * 10. Compute the prime factors of a given natural number.
         * 
         * A prime number is only evenly divisible by itself and 1.
         * 
         * Note that 1 is not a prime number.
         * 
         * @param l
         * @return
         */
        public static List<long> CalculatePrimeFactorsOf(long l)
        {
            List<long> primeFactors = new List<long>();

            // Determine how many times 2 can be a factor
            long cnt = 0;
            while (l % 2 == 0)
            {
                // While input is not odd, 2 is always a factor
                l /= 2;
                primeFactors.Add(2L);
            }

            // Checked evens, so now check odd numbers up to the 
            // sqrt(targetnumber). No need to check higher than that
            // because higher is guaranteed to not be prime.
            for (long i = 3; i <= Math.Sqrt(l); i += 2)
            {
                // Primes are determined by the remainder.
                // We want duplicates so check how many times a number
                // can be prime.
                while (l % i == 0)
                {
                    primeFactors.Add(i);
                    l /= i;
                }
            }

            // if l is still greater than 2, l is a prime so add itself
            if (l > 2)
            {
                primeFactors.Add(l);
            }

            return primeFactors;
        }


        /**
	     * 11. Create an implementation of the rotational cipher, also sometimes called
	     * the Caesar cipher.
	     * 
	     * The Caesar cipher is a simple shift cipher that relies on transposing all the
	     * letters in the alphabet using an integer key between 0 and 26. Using a key of
	     * 0 or 26 will always yield the same output due to modular arithmetic. The
	     * letter is shifted for as many values as the value of the key.
	     * 
	     * The general notation for rotational ciphers is ROT + <key>. The most commonly
	     * used rotational cipher is ROT13.
	     * 
	     * A ROT13 on the Latin alphabet would be as follows:
	     * 
	     * Plain: abcdefghijklmnopqrstuvwxyz Cipher: nopqrstuvwxyzabcdefghijklm It is
	     * stronger than the Atbash cipher because it has 27 possible keys, and 25
	     * usable keys.
	     * 
	     * Ciphertext is written out in the same formatting as the input including
	     * spaces and punctuation.
	     * 
	     * Examples: ROT5 omg gives trl ROT0 c gives c ROT26 Cool gives Cool ROT13 The
	     * quick brown fox jumps over the lazy dog. gives Gur dhvpx oebja sbk whzcf bire
	     * gur ynml qbt. ROT13 Gur dhvpx oebja sbk whzcf bire gur ynml qbt. gives The
	     * quick brown fox jumps over the lazy dog.
	     */
        public class RotationalCipher
        {
            private int key;

            public RotationalCipher(int key)
            {
                this.key = key;
            }

            public string Rotate(String str)
            {
                char[] strCharArr = str.ToCharArray();

                // Iterate through each char
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLetter(strCharArr[i]))
                    {
                        if (char.IsUpper(strCharArr[i]))
                        {
                            // Char + key, loop back if it goes out of  range.
                            // Normalize range to 0 - 26 then see if it goes over,
                            // when it goes over it goes to 0. Finally add 65 to get
                            // original mapping.
                            strCharArr[i] = (char) ( (strCharArr[i] + key - 65) % 26 + 65 );
                        }
                        else
                        {
                            // Same as above but different range for lowercase characters
                            strCharArr[i] = (char)( (strCharArr[i] + key - 97) % 26 + 97 );
                        }
                    }
                }

                return new string(strCharArr);
            }
        }

        /**
	     * 12. Given a number n, determine what the nth prime is.
	     * 
	     * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see
	     * that the 6th prime is 13.
	     * 
	     * If your language provides methods in the standard library to deal with prime
	     * numbers, pretend they don't exist and implement them yourself.
	     * 
	     * @param i
	     * @return
	     */
        public static int CalculateNthPrime(int i)
        {
            int primeNum = 0;   // The prime number at the current primeCnt
            int primeCnt = 0;   // The number inde of the prime
            Boolean isPrime;

            if (i < 1)
            {
                throw new ArgumentException();
            }

            // Its gonna find the first i primes. only store 1 prime at a time
            for (int num = 2; primeCnt < i; num++)
            {
                isPrime = true;

                // Check if number is prime by dividing by all possible numbers
                // if it is ever evenly divisible by a number other than itself or 1...
                // it is not prime
                for (int k = 2; k < num; k++)
                {
                    if (num % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeCnt++;
                    primeNum = num;
                }
            }


            return primeNum;
        }


        /**
	     * 13 & 14. Create an implementation of the atbash cipher, an ancient encryption
	     * system created in the Middle East.
	     * 
	     * The Atbash cipher is a simple substitution cipher that relies on transposing
	     * all the letters in the alphabet such that the resulting alphabet is
	     * backwards. The first letter is replaced with the last letter, the second with
	     * the second-last, and so on.
	     * 
	     * An Atbash cipher for the Latin alphabet would be as follows:
	     * 
	     * Plain: abcdefghijklmnopqrstuvwxyz Cipher: zyxwvutsrqponmlkjihgfedcba It is a
	     * very weak cipher because it only has one possible key, and it is a simple
	     * monoalphabetic substitution cipher. However, this may not have been an issue
	     * in the cipher's time.
	     * 
	     * Ciphertext is written out in groups of fixed length, the traditional group
	     * size being 5 letters, and punctuation is excluded. This is to make it harder
	     * to guess things based on word boundaries.
	     * 
	     * Examples Encoding test gives gvhg Decoding gvhg gives test Decoding gsvjf
	     * rxpyi ldmul cqfnk hlevi gsvoz abwlt gives thequickbrownfoxjumpsoverthelazydog
	     *
	     */
        public class AtbashCipher
        {
            /// <summary>
            /// Mappings for the alphabet
            /// </summary>
            private static readonly Dictionary<char, char> alphaMap = new Dictionary<char, char>() 
            {
                ['a'] = 'z', ['f'] = 'u', ['k'] = 'p', ['p'] = 'k', ['u'] = 'f', ['z'] = 'a',
                ['b'] = 'y', ['g'] = 't', ['l'] = 'o', ['q'] = 'j', ['v'] = 'e', 
                ['c'] = 'x', ['h'] = 's', ['m'] = 'n', ['r'] = 'i', ['w'] = 'd', 
                ['d'] = 'w', ['i'] = 'r', ['n'] = 'm', ['s'] = 'h', ['x'] = 'c', 
                ['e'] = 'v', ['j'] = 'q', ['o'] = 'l', ['t'] = 'g', ['y'] = 'b' 
            };

            /// <summary>
            /// 
            /// Question 13
            /// 
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public static string Encode(string str)
            {
                // Convert to char array with only letters
                char[] strChars = Regex.Replace(str, "[^A-Za-z0-9]+", "").ToLower().ToCharArray();

                for (int i = 0; i < strChars.Length; i++)
                {
                    // Make sure we are changing alphabetical character
                    if (alphaMap.ContainsKey(strChars[i]))
                    {
                        strChars[i] = alphaMap[strChars[i]];
                    }                    
                }


                // Group every 5 characters into word
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < strChars.Length; i++)
                {
                    if (i % 5 == 0 && i != 0)
                    {
                        // Add a space before
                        sb.Append(" ");
                    }

                    sb.Append(strChars[i]);
                }

                return sb.ToString();
            }

            /// <summary>
            /// 
            /// Question 14
            /// 
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public static string Decode(string str)
            {
                // Why does this work? It is a simle one to one direct mapping.
                // Mapping the resulting chars back to originals is simply done
                // by encoding again.
                string resultStr = AtbashCipher.Encode(str).Replace(" ", "");
                return resultStr;
            }
        }


        /**
	     * 15. The ISBN-10 verification process is used to validate book identification
	     * numbers. These normally contain dashes and look like: 3-598-21508-8
	     * 
	     * ISBN The ISBN-10 format is 9 digits (0 to 9) plus one check character (either
	     * a digit or an X only). In the case the check character is an X, this
	     * represents the value '10'. These may be communicated with or without hyphens,
	     * and can be checked for their validity by the following formula:
	     * 
	     * (x1 * 10 + x2 * 9 + x3 * 8 + x4 * 7 + x5 * 6 + x6 * 5 + x7 * 4 + x8 * 3 + x9
	     * * 2 + x10 * 1) mod 11 == 0 If the result is 0, then it is a valid ISBN-10,
	     * otherwise it is invalid.
	     * 
	     * Example Let's take the ISBN-10 3-598-21508-8. We plug it in to the formula,
	     * and get:
	     * 
	     * (3 * 10 + 5 * 9 + 9 * 8 + 8 * 7 + 2 * 6 + 1 * 5 + 5 * 4 + 0 * 3 + 8 * 2 + 8 *
	     * 1) mod 11 == 0 Since the result is 0, this proves that our ISBN is valid.
	     * 
	     * @param string
	     * @return
	     */
        public static bool IsValidIsbn(string str)
        {
            // Check inputs

            if (str.Length != 13)
            {
                return false;
            }

            // Only last number can be x
            MatchCollection matches = Regex.Matches(str.Substring(0, str.Length - 1), ".*[^0-9-].*");
            if (matches.Count > 0)
            {
                return false;
            }

            // Make sure check character is valid
            if (char.ToLower(str[12]) != 'x' && !char.IsDigit(str[12]))
            {
                return false;
            }

            // Format is valid now perform calculations
            int sum = 0;
            char[] chrArr = str.ToCharArray();

            for (int mult = 10, i = 0; i < chrArr.Length; i++)
            {
                if (char.IsDigit(chrArr[i]))
                {
                    sum += (int) char.GetNumericValue(chrArr[i]) * mult;
                    mult--;
                }
                else if (chrArr[i] == 'x' || chrArr[i] == 'X')
                {
                    sum += 10 * i;
                    mult--;
                }
            }

            if (sum % 11 == 0)
            {
                return true;
            }

            return false;
        }


        /**
	     * 16. Determine if a sentence is a pangram. A pangram (Greek: παν γράμμα, pan
	     * gramma, "every letter") is a sentence using every letter of the alphabet at
	     * least once. The best known English pangram is:
	     * 
	     * The quick brown fox jumps over the lazy dog.
	     * 
	     * The alphabet used consists of ASCII letters a to z, inclusive, and is case
	     * insensitive. Input will not contain non-ASCII symbols.
	     * 
	     * @param string
	     * @return
	     */
        public static bool IsPangram(string str)
        {
            const string atoz = "abcdefghijklmnopqrstuvwxyz";
            HashSet<char> atozSet = new HashSet<char>();

            // We will use set to store the alphabet
            for (int i = 0; i < atoz.Length; i++)
            {
                atozSet.Add(atoz[i]);
            }

            // Remove the character from the set if it exists.
            string lowerStr = str.ToLower();
            for (int i = 0; i < lowerStr.Length; i++)
            {
                atozSet.Remove(lowerStr[i]);
            }

            // check if the set is empty
            if (atozSet.Count == 0)
            {
                return true;
            }

            return false;
        }

        /**
	     * 17. Calculate the moment when someone has lived for 10^9 seconds.
	     * 
	     * A gigasecond is 109 (1,000,000,000) seconds.
	     * 
	     * @param given
	     * @return
	     */
        public static DateTime? GetGigasecondDate(DateTime given)
        {
            const long GIGASECOND = 1_000_000_000L;

            DateTime dt = given.AddSeconds(GIGASECOND);

            return dt;
        }

        /**
         * 18. Given a number, find the sum of all the unique multiples of particular
         * numbers up to but not including that number.
         * 
         * If we list all the natural numbers below 20 that are multiples of 3 or 5, we
         * get 3, 5, 6, 9, 10, 12, 15, and 18.
         * 
         * The sum of these multiples is 78.
         * 
         * @param i
         * @param set
         * @return
         */
        public static int GetSumOfMultiples(int i, int[] set)
        {
            HashSet<int> multiples = new HashSet<int>();
            int multiple;
            int sum = 0;

            if (set.Length == 0)
            {
                return 0;
            }

            // For every number in the set * 2
            for (int j = 0; j < set.Length; j++)
            {
                multiples.Add(set[j]);
                multiple = set[j] * 2;
                while (multiple < i)
                {
                    multiples.Add(multiple);
                    multiple += set[j];
                }
            }

            // Sum up the elements
            foreach (int myInt in multiples)
            {
                sum += myInt;
            }

            return sum;
        }


        /**
         * 19. Given a number determine whether or not it is valid per the Luhn formula.
         * 
         * The Luhn algorithm is a simple checksum formula used to validate a variety of
         * identification numbers, such as credit card numbers and Canadian Social
         * Insurance Numbers.
         * 
         * The task is to check if a given string is valid.
         * 
         * Validating a Number Strings of length 1 or less are not valid. Spaces are
         * allowed in the input, but they should be stripped before checking. All other
         * non-digit characters are disallowed.
         * 
         * Example 1: valid credit card number 1 4539 1488 0343 6467 The first step of
         * the Luhn algorithm is to double every second digit, starting from the right.
         * We will be doubling
         * 
         * 4_3_ 1_8_ 0_4_ 6_6_ If doubling the number results in a number greater than 9
         * then subtract 9 from the product. The results of our doubling:
         * 
         * 8569 2478 0383 3437 Then sum all of the digits:
         * 
         * 8+5+6+9+2+4+7+8+0+3+8+3+3+4+3+7 = 80 If the sum is evenly divisible by 10,
         * then the number is valid. This number is valid!
         * 
         * Example 2: invalid credit card number 1 8273 1232 7352 0569 Double the second
         * digits, starting from the right
         * 
         * 7253 2262 5312 0539 Sum the digits
         * 
         * 7+2+5+3+2+2+6+2+5+3+1+2+0+5+3+9 = 57 57 is not evenly divisible by 10, so
         * this number is not valid.
         * 
         * @param string
         * @return
         */
        public static bool IsLuhnValid(string str)
        {
            int sum = 0;
            string noSpaces = str.Replace(" ", "");

            // Check for anything thats not a digit
            if (Regex.Matches(str, ".*[^0-9].*").Count == 0)
            {
                return false;
            }

            // String matches format we want - perform calculation
            for (int i = noSpaces.Length - 1, odd = 1; i >= 0; i--, odd++)
            {
                if (odd % 2 == 0)
                {
                    int doubledVal = (int) char.GetNumericValue(noSpaces[i]) * 2;
                    if (doubledVal > 9) { doubledVal -= 9; }
                    sum += doubledVal;
                }
                else
                {
                    sum += (int) char.GetNumericValue(noSpaces[i]);
                }
            }

            if (sum % 10 == 0)
            {
                return true;
            }

            return false;
        }


        /**
	     * 20. Parse and evaluate simple math word problems returning the answer as an
	     * integer.
	     * 
	     * Add two numbers together.
	     * 
	     * What is 5 plus 13?
	     * 
	     * 18
	     * 
	     * Now, perform the other three operations.
	     * 
	     * What is 7 minus 5?
	     * 
	     * 2
	     * 
	     * What is 6 multiplied by 4?
	     * 
	     * 24
	     * 
	     * What is 25 divided by 5?
	     * 
	     * 5
	     * 
	     * @param string
	     * @return
	     */
        public static int SolveWordProblem(string str)
        {
            int operatorFlag = -1;
            int result = 0;

            // Extract numbers from string
            string[] words = str.Split(" ");
            List<int> operands = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (Regex.IsMatch(words[i], @"-?[0-9]{1,}?\\?"))
                {
                    // Make sure number is clean of punctuation
                    string digit = Regex.Replace(words[i], @"[\p{P}-[-]]", "");
                    operands.Add(int.Parse(digit));
                }
                else if (words[i].Contains("plus"))
                {
                    operatorFlag = 1;
                }
                else if (words[i].Contains("minus"))
                {
                    operatorFlag = 2;
                }
                else if (words[i].Contains("multiplied"))
                {
                    operatorFlag = 3;
                }
                else if (words[i].Contains("divided"))
                {
                    operatorFlag = 4;
                }
            }

            result = operands[0];
            switch (operatorFlag)
            {
                case 1:
                    for (int i = 1; i < operands.Count; i++)
                    {
                        result += operands[i];
                    }
                    break;
                case 2:
                    for (int i = 1; i < operands.Count; i++)
                    {
                        result -= operands[i];
                    }
                    break;
                case 3:
                    for (int i = 1; i < operands.Count; i++)
                    {
                        result *= operands[i];
                    }
                    break;
                case 4:
                    for (int i = 1; i < operands.Count; i++)
                    {
                        result /= operands[i];
                    }
                    break;
                default:
                    break;
            }

            return result;
        }


    }
}

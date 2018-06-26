using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
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
            // TODO: implement this method
            return "";
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
            // TODO: implement this method
            return "";
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
                // TODO: implement this method
                return false;
            }

            public bool IsIsosceles()
            {
                // TODO: implement this method
                return false;
            }

            public bool IsScalene()
            {
                // TODO: implement this method
                return false;
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
        public int GetScrabbleScoore(string str)
        {
            // TODO: implement this method
            return 0;
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
        public string CleanPhoneNumber(string str)
        {
            // TODO: implement this method
            return null;
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
        public IDictionary<string, int> WordCount(string str)
        {
            return null;
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
        public class BinarySearch<T>
        {
            // Auto implemented property
            public List<T> SortedList { get; set; }

            public int IndexOf(T t)
            {
                // TODO: implement this method
                return 0;
            }

            public BinarySearch(List<T> sortedList) : base()
            {
                SortedList = sortedList;
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
        public String ToPigLatin(string str)
        {
            // TODO: implement this method
            return null;
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
        public bool IsArmstrongNumber(int input)
        {
            // TODO: implement this method
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
        public List<long> calculatePrimeFactorsOf(long l)
        {
            // TODO: implement this method
            return null;
        }

    }
}

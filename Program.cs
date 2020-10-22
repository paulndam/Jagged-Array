using System;

namespace Arrays {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

            test ();
            avergaCalc ();

            //  using a jagged array to  track one week of sales for two months, assigns sales figures to its elements and then loops thru the array to calculate the average for one week of both months stored in the array.

            int[] jan = new int[31];
            int[] feb = new int[29];
            int[][] sales = new int[][]{jan, feb};

            int month, day, total;

            double average = 0.0;

            sales[0][0] = 41;
            sales[0][1] = 30;
            sales[0][0] = 41;
            sales[0][1] = 30;
            sales[0][2] = 23;
            sales[0][3] = 34;
            sales[0][4] = 28;
            sales[0][5] = 35;
            sales[0][6] = 45;
            sales[1][0] = 35;
            sales[1][1] = 37;
            sales[1][2] = 32;
            sales[1][3] = 26;
            sales[1][4] = 45;
            sales[1][5] = 38;
            sales[1][6] = 42;

            for (month = 0; month < 1; month++) {
                total = 0;
                for (day = 0; day <= 6; day++) {
                    total += sales[month][day];
                    average = total / 7;

                    Console.WriteLine ("Average sales for month: " + month + " : " + average);
                }
            }

        }

        public static void test () {

            int[] numbers;
            numbers = new int[] { 0, 1, 3, 4 };
            Type arrayType = numbers.GetType ();
            if (arrayType.IsArray) {
                Console.WriteLine ("array type is {0}", arrayType);
            } else {
                Console.WriteLine ("not an array type ");
                Console.Read ();
            }

        }

        public static void avergaCalc () {
            int[, ] grades = new int[, ] { { 1, 82, 74, 89, 100 }, { 2, 93, 96, 85, 86 }, { 3, 83, 72, 95, 89 }, { 4, 91, 98, 79, 88 }

            };

            int lastGrade = grades.GetUpperBound (1);
            double average = 0.0;
            int total;
            int lastStudent = grades.GetUpperBound (0);

            for (int row = 0; row < lastStudent; row++) {
                total = 0;
                for (int col = 0; col < lastGrade; col++) {
                    total += grades[row, col];
                    average = total / lastGrade;
                    Console.WriteLine ("Avg :-> " + average);
                }
            }

        }

        // parameter array

        public static int sumNums (params int[] nums) {

            int sum = 0;
            for (int i = 0; i <= nums.GetUpperBound (0); i++) {
                sum += nums[i];

            }
            return sum;

        }

    }

}
﻿using System;

namespace Csharp.其他
{
    public class SomeArray<T>
    {


        //实现二分查找，方法名BinarySeek(int[] numbers, int target)：
        //         传入一个有序（从大到小 / 从小到大）数组和数组中要查找的元素
        //         如果找到，返回该元素所在的下标；否则，返回 - 1
        //用泛型改造二分查找、堆栈和双向链表
        //  用泛型改造“取数组中最大值”（提示：IComparable）
        public static int BinarySeek(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            int middle;
            while (left <= right)
            {
                middle = (left + right) / 2;
                if (target > numbers[middle])
                {
                    left = middle + 1;
                }
                else if (target < numbers[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }





        /// <summary>
        /// 设立并显示一个多维数组的值，元素值等于下标之和。
        /// </summary>
        public static void MarreyXB()
        {
            int[,] Marrey = new int[3, 4];
            // GetLength(0) 获得第一维的长度(行数) GetLength(1) 获得第二维的长度(列数)
            for (int i = 0; i < Marrey.GetLength(0); i++)
            {
                for (int j = 0; j < Marrey.GetLength(1); j++)
                {
                    Console.Write(i + j + "---");
                }
                Console.WriteLine("\n");
            }
        }

        /// <summary>
        ///  利用ref调用Swap()方法交换两个同学的床位号
        /// </summary>
        private static void Swap()
        {

        }

        /// <summary>
        ///   //传入一个数组返回最小值
        /// </summary>
        private static void getMinArray()
        {
            int[] arraymax = { 2, 5, 7, 8, 9 };
            for (int i = 0; i < arraymax.Length; i++)
            {
                //从小到大 
                for (int j = 0; j < arraymax.Length - 1; j++)
                {
                    if (arraymax[j] < arraymax[j + 1])
                    {
                        int temp = arraymax[j];
                        arraymax[j] = arraymax[j + 1];
                        arraymax[j + 1] = temp;

                    }

                }

            }

            Console.WriteLine(arraymax[arraymax.Length - 1]);

        }
        /// <summary>
        ///   //传入一个数组返回最大值
        /// </summary>
        private static void getMaxArray()
        {
            int[] arraymax = { 2, 5, 7, 8, 9 };
            for (int i = 0; i < arraymax.Length; i++)
            {
                //从小到大 
                for (int j = 0; j < arraymax.Length - 1; j++)
                {
                    if (arraymax[j] > arraymax[j + 1])
                    {
                        int temp = arraymax[j];
                        arraymax[j] = arraymax[j + 1];
                        arraymax[j + 1] = temp;

                    }

                }

            }

            Console.WriteLine(arraymax[arraymax.Length - 1]);
        }
        /// <summary>
        ///  生成一个元素（值随机）从小到大排列的数组
        /// </summary>
        public static void ArraySort()
        {
            //给随机数组赋值
            int[] arryasc = new int[10];
            Random Rvalue = new Random();
            arryasc[0] = Rvalue.Next(5);
            for (int i = 1; i < 10; i++)
            {
                arryasc[i + 1] = Rvalue.Next(0, 100) + arryasc[i];

                Console.WriteLine(arryasc[i]);
            }
            //冒泡排序
            for (int i = 0; i < arryasc.Length; i++)
            {
                //从小到大 
                for (int j = 0; j < arryasc.Length - 1; j++)
                {
                    if (arryasc[j] > arryasc[j + 1])
                    {
                        int temp = arryasc[j];
                        arryasc[j] = arryasc[j + 1];
                        arryasc[j + 1] = temp;

                    }

                }

            }


        }
        //传入一个数组返回最大值，最小值

        /// <summary>
        /// 猜数游戏
        /// </summary>
        //完成“猜数字”游戏，方法名GuessMe()：
        //随机生成一个大于0小于1000的整数
        //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
        //没猜中可以继续猜，但最多不能超过10次
        //如果5次之内猜中，输出：你真牛逼！
        //如果8次之内猜中，输出：不错嘛！
        //10次还没猜中，输出：(～￣(OO)￣)ブ  
        public static void GuessMe()
        {

            Random r = new Random();
            int b = r.Next(0, 1000);//随机数
            Console.WriteLine(b);
            Console.WriteLine("请输入您猜的数字：");

            ///1、猜中
            ///1.1检查次数
            ///2、未猜中
            ///2.1未到10次，继续
            ///2.2到了10次,结束
            for (int i = 0; i < 20; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a != b)
                {
                    if (i <= 10)
                    {
                        if (a > b)
                        {
                            Console.WriteLine("大了");
                        }
                        else if (a < b)
                        {
                            Console.WriteLine("小了");
                        }
                    }
                    else if (i > 10)
                    {
                        Console.WriteLine("不能再输了");
                        break;
                    }
                }
                else
                {
                    if (i <= 5)
                    {
                        Console.WriteLine("你真牛逼");
                    }
                    else if (i <= 8)
                    {
                        Console.WriteLine("不错嘛！");
                    }
                    else if (i <= 10)
                    {
                        Console.WriteLine("这么多次才中，加油哦");
                    }
                }

            }

        }

        /// <summary>
        /// 平均成绩
        /// </summary>
        /// <param name="score1"></param>
        public static void GetAverage(double[] score1)
        {
            double sum = 0;
            double avg;

            for (int i = 0; i < score1.Length; i++)
            {
                sum += score1[i];
            }
            avg = Math.Round((sum / score1.Length), 2);
            Console.WriteLine("分数是" + avg);



        }
        public static void Grow(Student student)//2、18
        {
            // student = new Student();
            student.age++;
            Console.WriteLine(student.age);//3、19

        }
        public static void Grow(ref Student student)
        {
            student = new Student();
            student.age++;
            Console.WriteLine(student.age);
        }
    }
}

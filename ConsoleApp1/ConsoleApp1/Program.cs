using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine(BestAlbum(new string[] { "classic", "pop", "classic", "classic", "pop", "pop" }, new int[] { 500, 600, 150, 800, 2500,600 }));
        }

        /// <summary>
        /// 프로그래머스 3단계 베스트앨범
        /// </summary>
        /// <param name="genres"></param>
        /// <param name="plays"></param>
        /// <returns></returns>
        static int[] BestAlbum(string[] genres, int[] plays)
        {
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            Dictionary<string, int> dictSum = new Dictionary<string, int>();
            for (int i = 0; i < genres.Length; i++)
            {
                if (!dict.ContainsKey(genres[i]))
                {
                    dict.Add(genres[i], new Dictionary<int,int>());
                    dictSum.Add(genres[i], 0);
                }
                {
                    dict[genres[i]].Add(i, plays[i]);
                    dictSum[genres[i]] += plays[i];
                }
            }

            var dictSort = dictSum.OrderByDescending(x => x.Value);
            for(int i = 0; i < dict.Count(); i++)
            {
                var value = (Dictionary<int,int>)dict.ElementAt(i).Value;
                var descending = value.OrderBy(x => x.Key).OrderByDescending(y => y.Value).ToList();
                dict[dict.ElementAt(i).Key] = descending;

            }
            Queue q = new Queue();
            for (int i = 0; i < dictSort.Count(); i++)
            {
                int count = 0;
                foreach(var value in dict[dictSort.ElementAt(i).Key])
                {
                    if (count == 2) break;
                    q.Enqueue(value.Key);
                    count++;
                }
            }
            int[] answer = new int[q.Count];
            for(int i = 0; i < answer.Length; i++)
            {
                answer[i] = Convert.ToInt32(q.Dequeue());
            }
            return answer;
        }
    }
}

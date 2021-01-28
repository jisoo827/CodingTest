using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();

			#region TestEnd
			//int answer = p.diskControl(new int[,] { { 0, 3 }, { 1, 5 }, { 10, 6 }, { 500, 6 }, { 15, 7 }, { 16, 3 }, { 7, 2 }, { 11, 3 } });
			//int answer = p.diskControl(new int[,] { { 0, 3 }, { 0, 1 }, { 0, 2 }, { 0, 4 } });
			//int answer = p.diskControl(new int[,] { { 0, 3 }, { 1, 9 }, { 2, 6 }});
			//int answer = p.diskControl2(new int[,] { { 24, 10 }, { 18, 39 }, { 34, 20 }, { 37, 5 }, { 47,22 }, { 20, 47 }, { 15,// 2 }, { 15, 34 }, { 35, 43 }, {26,1} });
			//answer = p.diskControl2(new int[,] { { 24, 10 }, { 18, 39 }, { 34, 20 }, { 37, 5 }, { 47, 22 }, { 20, 47 }, { 15, 34 }, { 15, 2 }, { 35, 43 }, { 26, 1 } });
			//answer = p.diskControl2(new int[,] { { 0, 3 }, { 1, 9 }, { 2, 6 } });
			//answer = p.diskControl2(new int[,] { { 1, 9 }, { 1, 4 }, { 1, 5 }, { 1, 7 }, { 1, 3 } });
			//answer = p.diskControl2(new int[,] { { 0, 3 }, { 0, 1 }, { 0, 2 }, { 0, 4 } });
			//answer = p.diskControl2(new int[,] { { 0, 3 }, { 1, 5 }, { 10, 6 }, { 500, 6 }, { 15, 7 }, { 16, 3 }, { 7, 2 }, { 11, 3 } });
			//answer = p.diskControl2(new int[,] { { 0, 3 }, { 1, 5 }, { 10, 6 }, { 500, 6 }, { 15, 7 }, { 16, 3 }, { 8, 2 } });
			//answer = p.diskControl(new int[,] { { 1, 9 }, { 1, 4 }, { 1, 5 }, { 1, 7 }, { 1, 3 } });
			//bool answer = p.stringSol("(())()");
			//int answer = p.truck(5, 5, new int[] { 2, 2, 2, 2, 1, 1, 1, 1, 1 });
			//int answer = p.truck(5, 5, new int[] { 1, 1, 1, 1, 1,2, 2, 2, 2 });
			//int answer = p.truck(3, 1, new int[] { 1, 1, 1});
			//int[] answer = p.investprice(new int[] {1,2,3,2,3});
			//int answer = p.print2(new int[] { 2, 1, 3, 2 }, 2);
			//answer = p.print2(new int[] { 1,1,9,1,1,1}, 0);
			//int answer = p.numberGame(new int[] { 5, 1, 3, 7 }, new int[] { 2, 2, 6, 8 });
			//long answer = p.extraWork(4, new int[] { 4,3,3 });
			//long answer = p.longjump(4);
			//int[] answer = p.progress(new int[] { 93, 30, 55 }, new int[] { 1, 30, 5 });
			//int answer = p.joystick("BBABA");
			//answer = p.joystick("BBBAAB");
			//answer = p.joystick("BBAABAA");
			//answer = p.joystick("BBAABBB");
			//answer = p.joystick("BBAABAAAA");
			//answer = p.joystick("BBAABAAAAB");
			//answer = p.joystick("JEROEN");
			//answer = p.joystick("JAN");
			//answer = p.joystick("AZAAAZ");
			//answer = p.joystick("ABAAAAAAAAAAABBBBB");
			//answer = p.joystick("CANAAAAANAN");
			//answer = p.joystick("KJEAZAAN");
			//int answer = p.numBaseball(new int[,] { { 123, 1, 1 }, { 356, 1, 0 }, { 327, 2, 0 }, { 489, 0, 1 } });
			//int answer = p.spyclothes(new string[,] { { "crow_mask", "face" }, { "blue_sunglasses", "face" }, { "smoke_makeup", "face" }, { "yellow_hat", "headgear" }, { "blue_sunglasses", "eyewear" }, { "green_turban", "headgear" }
			//});
			//answer = p.spyclothes(new string[,] { { "crow_mask", "face" }, { "blue_sunglasses", "face" }, { "smoke_makeup", "face" }, { "yellow_hat", "headgear" }, { "blue_sunglasses", "eyewear" }, { "green_turban", "headgear" }
			//,{ "crow_mask1", "top" },{ "crow_mask2", "top" },{ "crow_mask3", "top" },{ "crow_mask4", "top" }
			//});
			//answer = p.spyclothes(new string[,] { { "yellow_hat", "headgear" }, { "blue_sunglasses", "eyewear" }, { "green_turban", "headgear" } });

			//int answer = p.bridge(4,new int[,] {{0,1,1},{0,2,2},{1,2,5},{1,3,1},{2,3,8}});
			//answer = p.bridge(4, new int[,] { { 0, 1, 1 }, { 0, 2, 2 }, { 1, 2, 5 }, { 1, 3, 3 }, { 2, 3, 8 }, {3,4,1} });
			//int answer = p.targetNumber(new int[] { 1, 1, 1, 1, 1 }, 3);
			//Console.WriteLine(answer);
			//Coin();
			//Dfs_Bfs();
			//HideNSeek();
			//MinRoute();
			//BitMask();
			//Tree_Dp();
			//SelectStr();
			//ConvertStr("ZZAZ");
			//ConvertStr("fasdfdzfgzsdf");

			//ShortestPass(new int[,] { { 1, 1, 2, 1 }, { 2, 1, 2, 2 }, { 2, 2, 1, 2 }, { 2, 2, 2, 3 }, { 1, 2, 1, 3 } }, 3, 1, 1, 9, 2, 3);
			//ShortestPass(new int[,] { { 1, 1, 2, 1 }, { 2, 1, 2, 2 }, { 2, 2, 1, 2 }, { 2, 2, 2, 3 }, { 1, 2, 1, 3 }, { 2, 2, 3, 2 }, { 2, 3, 3, 3 }, { 3, 2, 3, 1 } }, 9, 2, 1, 9, 3, 3);

			//10 2 [4,3] // 8 1 [3,3] //24 24 [8,6] 
			//Capet(10, 2);
			//Capet(8, 1);
			//Capet(24, 24);

			//p.Bridge(5, new int[,] { { 0, 1, 1 }, { 0, 2, 2 }, { 1, 2, 5 }, { 1, 3, 3 }, { 2, 3, 8 }, { 3, 4, 1 } });
			//p.Bridge(5, new int[,] { { 0, 1, 1 }, { 2, 3, 1 }, { 3, 4, 2 }, { 1, 2, 2 }, { 0, 4, 100 } });

			//Tree_Dp();
			//FarthestNode(6, new int[,] { { 3, 6 }, { 4, 3 }, { 3, 2 }, { 1, 3 }, { 1, 2 }, { 2, 4 }, { 5, 2 } });
			//FarthestNode(10, new int[,] { { 1, 6 }, { 6, 5 }, { 5, 2 }, { 2, 3 }, { 1, 4 }, { 4, 10 }, { 10, 8 }, { 8, 9 }});
			//Balloon(new int[] { -16, 27, 65, -2, 58, -92, -71, -68, -61, -33 });
			//Network(3, new int[,] { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } });
			//Network(4, new int[,] { { 1, 0, 0, 1 }, { 0, 1, 1, 0 }, { 0, 1, 1, 0 }, { 1, 1, 0, 1 } });
			//Network(5, new int[,] { { 1, 1, 0, 0, 0 }, { 1, 1, 1, 0, 0 }, { 0, 1, 1, 0, 0 }, { 0, 0, 0, 1, 1 }, { 0, 0, 0, 1, 1 } });
			//Debug.WriteLine(BestAlbum(new string[] { "classic", "pop", "classic", "classic", "pop", "pop" }, new int[] { 500, 600, 150, 800, 2500,600 }));
			//TriangularSnail(5);
			#endregion
			//TravelPath(new string[,] { { "ICN", "SFO" }, { "ICN", "ATL" }, { "SFO", "ATL" }, { "ATL", "ICN" }, { "ATL", "SFO" } });
			//TravelPath(new string[,] { { "ICN", "JFK" }, { "HND", "IAD" }, { "JFK", "HND" } });
			//TravelPath(new string[,] { { "ICN", "2" }, { "2", "ICN" }, { "ICN", "2" }, { "2", "3" } });
			//TravelPath(new string[,] { { "ICN" , "2" }, { "2", "ICN" }, { "ICN", "2" }, { "2", "ICN" }, { "ICN", "2" } });
			TravelPath(new string[,] { { "1", "3" }, { "1", "2" }, { "3", "1" }, { "2", "4" } });
			//TravelPath(new string[,] {{"ICN", "BOO"}, {"ICN", "COO"}, {"COO", "DOO"}, {"DOO", "COO"}, {"BOO", "DOO"},{"DOO", "BOO"}, {"BOO", "ICN"}, {"COO", "BOO"}});

		}

		/// <summary>
		/// 프로그래머스 해시 3단계 베스트앨범
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
					dict.Add(genres[i], new Dictionary<int, int>());
					dictSum.Add(genres[i], 0);
				}
				{
					dict[genres[i]].Add(i, plays[i]);
					dictSum[genres[i]] += plays[i];
				}
			}

			var dictSort = dictSum.OrderByDescending(x => x.Value);
			for (int i = 0; i < dict.Count(); i++)
			{
				var value = (Dictionary<int, int>)dict.ElementAt(i).Value;
				var descending = value.OrderBy(x => x.Key).OrderByDescending(y => y.Value).ToList();
				dict[dict.ElementAt(i).Key] = descending;

			}
			Queue q = new Queue();
			for (int i = 0; i < dictSort.Count(); i++)
			{
				int count = 0;
				foreach (var value in dict[dictSort.ElementAt(i).Key])
				{
					if (count == 2) break;
					q.Enqueue(value.Key);
					count++;
				}
			}
			int[] answer = new int[q.Count];
			for (int i = 0; i < answer.Length; i++)
			{
				answer[i] = Convert.ToInt32(q.Dequeue());
			}
			return answer;
		}
		public int[] solution(int[] heights)
		{
			Stack stack = new Stack();
			for (int i = heights.Length; i > 0; i--)
			{
				if (i == 1)
				{
					stack.Push(0);
					break;
				}
				for (int j = i - 1; j >= 0; j--)
				{
					if (j == 0)
					{
						stack.Push(0);
						break;
					}
					if (heights[j - 1] > heights[i - 1])
					{
						stack.Push(j);
						break;
					}
				}
			}
			int[] answer = new int[stack.Count];
			//int[] answer = new int[] { (int)(stack.Pop()), (int)(stack.Pop()), (int)(stack.Pop()), (int)(stack.Pop()), (int)(stack.Pop()) };
			int cnt = 0;
			while (stack.Count > 0)
			{
				answer[cnt++] = (int)(stack.Pop());
			}

			return answer;
		}

		/// <summary>
		/// 프로그래머스 연습문제 1단계 자릿수 더하기
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public int solution1(int n)
		{
			int answer = 0;
			string str = n.ToString();

			try
			{
				foreach (char a in str)
				{
					answer += Int32.Parse(a.ToString());
				}
			}
			catch (ArgumentNullException e)
			{
				Console.WriteLine(e.StackTrace.ToString());
				Console.WriteLine(e.StackTrace.ToString());
			}
			return answer;
		}

		public int[] solution2(int n)
		{
			//0 1
			//001 3
			//0010100 7
			//001010001101011 15
			// 31
			// 63
			int cnt = Int32.Parse(Math.Pow(2, n).ToString());
			int[] answer = new int[cnt - 1];
			int mid = 0;
			for (int i = 0; i < cnt - 1; i++)
			{
				if (i == 0)
				{
					answer[i] = 0;
				}
				else if (is2Pow((double)i + 1))
				{
					mid = i;
					answer[i] = 0;
				}
				else
				{
					answer[i] = answer[2 * mid - i] == 0 ? 1 : 0;
				}

			}
			return answer;
		}
		public bool is2Pow(double n)
		{
			bool answer = true;
			if (n % 2 == 0)
			{
				answer = is2Pow(n / 2);
			}
			else
			{
				answer = n == 1 ? true : false;
			}
			return answer;
		}

		/// <summary>
		/// 프로그래머스 Summer/Winter Coding(~2018) 4단계 쿠키 구입
		/// </summary>
		/// <param name="cookie"></param>
		/// <returns></returns>
		public int Cookie(int[] cookie)
		{
			int answer = 0;
			int leftSum = 0;
			int rightSum = 0;
			bool flag = true;

			if (cookie.Length > 2000) return 0;


			for (int i = 0; i <= cookie.Length - 2; i++)
			{
				flag = true;
				int k = i + 1;
				leftSum = 0;
				for (int j = i; j >= 0; j--)
				{
					rightSum = 0;
					leftSum += cookie[j];
					if (leftSum <= answer) continue;
					if (i - j > cookie.Length / 2) break;
					for (int l = k; l <= cookie.Length - 1; l++)
					{
						rightSum += cookie[l];
						if (rightSum > leftSum) break;
						else if (l == cookie.Length - 1 && leftSum > rightSum)
						{
							flag = false;
							break;
						}
						else if (leftSum == rightSum)
						{
							answer = Math.Max(leftSum, answer);
						}
					}
					if (!flag)
						break;
				}
			}

			return answer;
		}

		public int SteppingStones(int distance, int[] rocks, int n)
		{
			int answer = 0;
			Array.Sort<int>(rocks, new Comparison<int>((i1, i2) => i1.CompareTo(i2)));

			return answer;
		}

		/// <summary>
		/// 프로그래머스 이분탐색 3단계 입국심사
		/// </summary>
		/// <param name="n"></param>
		/// <param name="times"></param>
		/// <returns></returns>
		public long Immigration(int n, int[] times)
		{
			long answer = 0;
			Array.Sort<int>(times, new Comparison<int>((i1, i2) => i1.CompareTo(i2)));

			long left = 1;
			long right = (long)(n * times[times.Length - 1] / 2 - 1);
			long mid = 0;

			while (left <= right)
			{
				long cnt = 0;
				mid = (left + right) / 2;

				for (int i = 0; i < times.Length; i++)
				{
					cnt += mid / times[i];
					if (cnt >= n)
					{
						break;
					}
				}
				if (cnt >= n)
				{
					right = mid - 1;
					answer = mid;
				}
				else
				{
					left = mid + 1;
				}
			}

			return answer;
		}

		/// <summary>
		/// 프로그래머스 정렬 1단계 k번째 수
		/// </summary>
		/// <param name="array"></param>
		/// <param name="commands"></param>
		/// <returns></returns>
		public int[] kNum(int[] array, int[,] commands)
		{
			//1,5,2,6,3,7,4
			int[] answer = new int[commands.GetLength(0)];
			for (int i = 0; i < commands.GetLength(0); i++)
			{
				int i1, i2, i3;
				i1 = commands[i, 0];
				i2 = commands[i, 1];
				i3 = commands[i, 2];
				int[] arr2 = new int[i2 - i1 + 1];
				Array.Copy(array, i1 - 1, arr2, 0, i2 - i1 + 1);
				Array.Sort<int>(arr2, new Comparison<int>((j1, j2) => j1.CompareTo(j2)));

				answer[i] = arr2[i3 - 1];

			}
			return answer;
		}

		/// <summary>
		/// 프로그래머스 힙 3단계 디스크 컨트롤러
		/// </summary>
		/// <param name="jobs"></param>
		/// <returns></returns>
		public int diskControl(int[,] jobs)
		{
			int answer = 0;
			int[,] arr = new int[jobs.GetLength(0), 2];
			int[] arr2 = new int[jobs.GetLength(0)];
			int[] arr3 = new int[jobs.GetLength(0)];
			int runP = 0;
			int proS = 0;
			int sum = 0;
			for (int i = 0; i < jobs.GetLength(0); i++)
			{
				arr2[i] = jobs[i, 0];
				arr3[i] = jobs[i, 1];
			}
			Array.Sort(arr2, arr3);
			for (int i = 0; i < jobs.GetLength(0); i++)
			{
				jobs[i, 0] = arr2[i];
				jobs[i, 1] = arr3[i];
			}
			sort(jobs);

			for (int i = 0; i < jobs.GetLength(0); i++)
			{
				proS = jobs[i, 0];
				runP += jobs[i, 1];
				for (int j = i; j < jobs.GetLength(0) - 1; j++)
				{
					if (j == proS) continue;
					if (jobs[j, 0] > runP) break;
					if (jobs[j, 1] > jobs[j + 1, 1] && jobs[j + 1, 0] <= runP)
					{
						int temp = jobs[j, 1];
						jobs[j, 1] = jobs[j + 1, 1];
						jobs[j + 1, 1] = temp;
						temp = jobs[j, 0];
						jobs[j, 0] = jobs[j + 1, 0];
						jobs[j + 1, 0] = temp;
						j--;
					}
				}
			}
			proS = 0;
			for (int i = 0; i < jobs.GetLength(0); i++)
			{
				if (jobs[i, 0] > proS + sum)
				{
					sum = 0;
					proS = jobs[i, 0];
				}
				sum += jobs[i, 1];
				answer += sum + proS - jobs[i, 0];
			}

			return answer / jobs.GetLength(0);

		}
		public void sort(int[,] arr)
		{
			for (int i = 1; i < arr.GetLength(0); i++)
			{
				if (arr[i, 0] == arr[i - 1, 0] && arr[i, 1] < arr[i - 1, 1])
				{
					int temp = arr[i, 1];
					arr[i, 1] = arr[i - 1, 1];
					arr[i - 1, 1] = temp;
					temp = arr[i, 0];
					arr[i, 0] = arr[i - 1, 0];
					arr[i - 1, 0] = temp;
					sort(arr);
				}
				if (arr[i, 0] != arr[i - 1, 0])
					break;
			}
		}

		/// <summary>
		/// 프로그래머스 힙 3단계 디스크 컨트롤러
		/// </summary>
		/// <param name="jobs"></param>
		/// <returns></returns>
		public int diskControl2(int[,] jobs)
		{
			int answer = 0;
			int[] arr2 = new int[jobs.GetLength(0)];
			int[] arr3 = new int[jobs.GetLength(0)];

			for (int i = 0; i < jobs.GetLength(0); i++)
			{
				arr2[i] = jobs[i, 0];
				arr3[i] = jobs[i, 1];
			}
			Array.Sort(arr2, arr3);
			for (int i = 0; i < jobs.GetLength(0); i++)
			{
				jobs[i, 0] = arr2[i];
				jobs[i, 1] = arr3[i];
			}
			sort(jobs);

			Queue<KeyValuePair<int, int>> que = new Queue<KeyValuePair<int, int>>();
			int runP = 0;
			int proS = 0;
			int sum = 0;
			int quecnt = 0;
			bool isRun = false;

			for (int i = 0; i < jobs.GetLength(0); i++)
			{
				proS = isRun ? runP + proS : jobs[i, 0];
				runP = jobs[i, 1];
				for (int j = i; j < jobs.GetLength(0); j++)
				{
					if (j == i) continue;
					if (jobs[j, 0] <= proS + runP)
					{
						que.Enqueue(new KeyValuePair<int, int>(jobs[j, 0], jobs[j, 1]));
					}
				}
				quecnt = que.Count;
				isRun = true;
				if (quecnt > 1)
				{
					arr2 = new int[quecnt];
					arr3 = new int[quecnt];
					for (int j = 0; j < quecnt; j++)
					{
						var q = que.Dequeue();
						arr2[j] = q.Key;
						arr3[j] = q.Value;
					}
					Array.Sort(arr3, arr2);
					for (int j = i + 1; j < i + 1 + quecnt; j++)
					{
						jobs[j, 0] = arr2[j - i - 1];
						jobs[j, 1] = arr3[j - i - 1];
					}
				}
				else if (quecnt == 0)
				{
					isRun = false;
				}
				que.Clear();
			}
			proS = 0;
			for (int i = 0; i < jobs.GetLength(0); i++)
			{
				if (jobs[i, 0] > proS + sum)
				{
					sum = 0;
					proS = jobs[i, 0];
				}
				sum += jobs[i, 1];
				answer += sum + proS - jobs[i, 0];
			}

			return answer / jobs.GetLength(0);

		}

		/// <summary>
		/// 프로그래머스 연습문제 3단계 야근 지수
		/// </summary>
		/// <param name="n"></param>
		/// <param name="works"></param>
		/// <returns></returns>
		public long extraWork(int n, int[] works)
		{
			long answer = 0;
			Array.Sort(works);
			Array.Reverse(works);

			int max = works[0];
			while (n > 0)
			{
				for (int i = 0; i < works.Length; i++)
				{
					if (works[0] == 0) return 0;
					if (n <= 0) break;
					if (works[i] >= max)
					{
						works[i]--;
						n--;
					}
					else
					{
						break;
					}
				}
				max--;
			}
			foreach (int j in works)
			{
				answer += j * j;
			}
			return answer;
		}

		public bool stringSol(string s)
		{
			bool answer = true;
			Queue que = new Queue();
			foreach (char c in s)
			{
				try
				{
					if (c == '(')
						que.Enqueue(c);
					else
						que.Dequeue();
				}
				catch
				{
					answer = false;
				}
			}
			if (que.Count > 0) answer = false;
			return answer;
		}

		/// <summary>
		/// 프로그래머스 스택/큐 2단계 다리를 지나는 트럭
		/// </summary>
		/// <param name="br_length"></param>
		/// <param name="weight"></param>
		/// <param name="truck_weights"></param>
		/// <returns></returns>
		public int truck(int br_length, int weight, int[] truck_weights)
		{
			int answer = br_length;
			int sum = 0;
			Queue que = new Queue();
			Queue que2 = new Queue();
			for (int i = 0; i < truck_weights.Length; i++)
			{
				if (sum + truck_weights[i] <= weight)
				{
					sum += truck_weights[i];
					answer++;
					que.Enqueue(truck_weights[i]);
					que2.Enqueue(answer);
					if (answer - (int)que2.Peek() + 1 >= br_length)
					{
						sum -= (int)que.Peek();
						que.Dequeue();
						answer = (int)que2.Dequeue() + br_length - 1;
					}
				}
				else
				{
					sum -= (int)que.Peek();
					que.Dequeue();
					answer = (int)que2.Dequeue() + br_length - 1;
					i--;
				}
			}
			return answer;
		}

		/// <summary>
		/// 프로그래머스 스택/큐 2단계 주식가격
		/// </summary>
		/// <param name="prices"></param>
		/// <returns></returns>
		public int[] investprice(int[] prices)
		{
			int[] answer = new int[prices.Length];
			//1,2,3,2,3
			//4,3,1,1,0
			for (int i = 0; i < prices.Length; i++)
			{
				int count = -1;
				for (int j = i; j < prices.Length; j++)
				{
					count++;
					if (prices[j] >= prices[i]) continue;
					else break;
				}
				answer[i] = count;
			}
			return answer;
		}

		/// <summary>
		/// 프로그래머스 스택/큐 2단계 프린터
		/// </summary>
		/// <param name="priorities"></param>
		/// <param name="location"></param>
		/// <returns></returns>
		public int print(int[] priorities, int location)
		{
			int answer = 0;
			int cnt = 0;
			List<Print> list = new List<Print>();
			bool isDelete = false;
			foreach (int n in priorities)
			{
				Print p = new Print();
				p.num = cnt++;
				p.prior = n;
				list.Add(p);
			}
			for (int i = 0; i < list.Count; i++)
			{
				isDelete = false;
				for (int j = i; j < list.Count; j++)
				{
					if (list[j].prior > list[i].prior)
					{
						Print p1 = new Print();
						p1.num = list[i].num;
						p1.prior = list[i].prior;
						list.Add(p1);
						isDelete = true;
						break;
					}
				}
				if (isDelete)
					list.RemoveAt(i--);

			}
			cnt = 1;
			foreach (Print p in list)
			{
				if (p.num == location)
				{
					answer = cnt;
					break;
				}
				cnt++;
			}
			return answer;
		}

		/// <summary>
		/// 프로그래머스 스택/큐 2단계 프린터
		/// </summary>
		/// <param name="priorities"></param>
		/// <param name="location"></param>
		/// <returns></returns>
		public int print2(int[] priorities, int location)
		{
			int answer = 0;
			Queue<KeyValuePair<int, int>> que = new Queue<KeyValuePair<int, int>>();
			for (int i = 0; i < priorities.Length; i++)
			{
				que.Enqueue(new KeyValuePair<int, int>(i, priorities[i]));
			}
			while (true)
			{
				int nMax = que.Max(x => x.Value);
				var kv = que.Dequeue();
				if (kv.Value == nMax)
				{
					if (kv.Key == location) return answer + 1;
					else
					{
						answer++;
						continue;
					}
				}
				que.Enqueue(kv);
			}

			return answer;
		}

		/// <summary>
		/// 프로그래머스 Summer/Winter Coding(~2018) 3단계 숫자 게임
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <returns></returns>
		public int numberGame(int[] A, int[] B)
		{
			int answer = 0;
			Array.Sort(A);
			Array.Sort(B);
			Array.Reverse(A);
			Array.Reverse(B);
			int aIndex = 0;
			int bIndex = 0;

			if (A[A.Length - 1] > B[0]) return 0;

			for (int j = 0; j < A.Length; j++)
			{
				if (B[bIndex] > A[aIndex])
				{
					answer++;
					bIndex++;
				}
				aIndex++;
			}

			return answer;
		}

		/// <summary>
		/// 프로그래머스 연습문제 3단계 멀리 뛰기
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public long longjump(int n)
		{
			long answer = 0;
			if (n < 4) return n;
			int[] arr = new int[n];
			arr[0] = 1; arr[1] = 2; arr[2] = 3;
			for (int i = 3; i < n; i++)
			{
				arr[i] = (arr[i - 2] + arr[i - 1]) % 1234567;
			}
			answer = arr[n - 1];

			return answer;
		}

		/// <summary>
		/// 프로그래머스 스택/큐 2단계 기능개발
		/// </summary>
		/// <param name="progresses"></param>
		/// <param name="speeds"></param>
		/// <returns></returns>
		public int[] progress(int[] progresses, int[] speeds)
		{
			//93, 30, 55 / 1, 30, 5 => 2, 1

			int[] list = new int[progresses.Length];
			int idx = -1;
			int pre = 0;
			double cur = 0;
			for (int i = 0; i < progresses.Length; i++)
			{
				cur = Math.Ceiling((100 - (double)progresses[i]) / (double)speeds[i]);
				if (cur > pre)
				{
					pre = (int)cur;
					idx++;
				}
				list[idx]++;

			}
			int[] answer = new int[idx + 1];
			for (int j = 0; j <= idx; j++)
			{
				answer[j] = list[j];
			}
			return answer;
		}

		/// <summary>
		/// 프로그래머스 탐욕법 2단계 조이스틱(실패)
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public int joystick(string name)
		{
			// JEROEN - 56, JAN - 23
			//BBBBAAAAABAAAAAAAAAAAABA
			//123456789012345678901234
			//abcdefghijklm
			//nopqrstuvwxyz
			//BABABAAAABA
			//ABAAAAAAAAAAABBBBB
			//KJEAZAAANN
			//KJEAZAAANNKJEAZAAANN
			int answer = 0;
			int cnt = 0;
			int lastpos = 1;
			bool reverse = false;
			int acnt = 0;
			foreach (char c in name)
			{
				answer = c > 'N' ? answer + 'Z' + 1 - (int)c : answer + (int)c - 'A';
				cnt++;
				if (cnt == 1 || c == 'A' || reverse)
				{
					acnt++;
					continue;
				}
				acnt = 0;
				if (cnt - lastpos > name.Length - cnt + lastpos)
				{
					reverse = true;
					answer += name.Length - cnt + lastpos;
				}
				else
				{
					answer += cnt - lastpos;
				}
				lastpos = cnt;

			}
			return answer;
		}

		public int numBaseball(int[,] baseball)
		{
			//123, 1, 1
			//356, 1, 0
			//327, 2, 0
			//489, 0, 1
			int answer = 0;
			int s = 0;
			int b = 0;

			List<int> list = new List<int>();

			for (int i = 123; i <= 987; i++)
			{
				s = 0; b = 0;
				string str = i.ToString();
				//if (str[0] == '0' || str[1] == '0' || str[2] == '0' || str[0] == str[1] || str[0] == str[2] || str[1] == str[2])
				//{
				//	continue;
				//}
				if (str.GroupBy(x => x).Select(x => x.Count()).Max() > 1) continue;
				if (str.Where(x => x == '0').Count() > 0) continue;
				string hit = baseball[0, 0].ToString();
				for (int j = 0; j < 3; j++)
				{
					for (int k = 0; k < 3; k++)
					{
						if (str[j] == hit[k])
						{
							if (j == k) s++;
							else b++;
						}
					}
				}
				if (s != baseball[0, 1] || b != baseball[0, 2])
				{
					continue;
				}
				list.Add(i);
			}
			referee(list, baseball, 1);

			answer = list.Count();

			return answer;
		}
		public void referee(List<int> list, int[,] baseball, int rownum)
		{
			if (baseball.GetLength(0) < rownum + 1) return;

			int s = 0;
			int b = 0;

			for (int i = 0; i < list.Count; i++)
			{
				s = 0; b = 0;
				string str = list[i].ToString();
				string hit = baseball[rownum, 0].ToString();
				for (int j = 0; j < 3; j++)
				{
					for (int k = 0; k < 3; k++)
					{
						if (str[j] == hit[k])
						{
							if (j == k) s++;
							else b++;
						}
					}
				}
				if (s != baseball[rownum, 1] || b != baseball[rownum, 2])
				{
					list.RemoveAt(i);
					i--;
				}
			}
			referee(list, baseball, rownum + 1);
		}

		/// <summary>
		/// 프로그래머스 해시 2단계 위장
		/// </summary>
		/// <param name="clothes"></param>
		/// <returns></returns>
		public int spyclothes(string[,] clothes)
		{
			//int answer = p.spyclothes(new string[,] { { "yellow_hat", "headgear" }, { "blue_sunglasses", "eyewear" }, { "green_turban", "headgear" } });
			int answer = 1;
			bool isThere = false;
			List<Clothes> list = new List<Clothes>();
			//answer += clothes.GetLength(0);
			for (int i = 0; i < clothes.GetLength(0); i++)
			{
				isThere = false;
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].Kind == clothes[i, 1].ToString())
					{
						Clothes c1 = list[j];
						c1.Cnt++;
						list[j] = c1;
						isThere = true;
						break;
					}
				}
				if (isThere)
				{
					continue;
				}
				else
				{
					Clothes c2 = new Clothes();
					c2.Kind = clothes[i, 1].ToString();
					c2.Cnt = 1;
					list.Add(c2);
				}
			}
			list.Sort((x1, x2) => x2.Cnt.CompareTo(x1.Cnt));
			int cnt = list.Count - 1;
			for (int i = 0; i < list.Count; i++)
			{
				//answer += list[i].Cnt * cal(list, i+1);
				//answer += list[i].Cnt + (answer*list[i].Cnt);				
				answer *= (list[i].Cnt + 1);
			}

			return answer;
		}
		public struct Clothes
		{
			public string Kind;
			public int Cnt;
		}
		public int cal(List<Clothes> list, int n)
		{
			int answer = 0;
			for (int i = n; i < list.Count; i++)
			{
				answer += list[i].Cnt;
			}
			if (n + 1 < list.Count)
				answer += list[n].Cnt * cal(list, n + 1);
			return answer;
		}

		/// <summary>
		/// 프로그래머스 탐욕법 3단계 섬 연결하기
		/// </summary>
		/// <param name="n"></param>
		/// <param name="costs"></param>
		/// <returns></returns>
		public int Bridge(int n, int[,] costs)
		{
			//bridge(5,new int[,] {{0,1,1},{0,2,2},{1,2,5},{1,3,3},{2,3,8},{3,4,1}})
			int answer = 0;
			int[] island = new int[n];
			int check = 1;

			var sorted = from x in Enumerable.Range(0, costs.GetLength(0))
						 select new
						 {
							 X = costs[x, 0],
							 Y = costs[x, 1],
							 Z = costs[x, 2]
						 } into point
						 orderby point.Z ascending, point.X ascending, point.Y ascending
						 select point;
			foreach (var test in sorted)
			{
				if (island[test.X] == 0 && island[test.Y] == 0)
				{
					island[test.X] = island[test.Y] = check++;
				}
				else if (island[test.X] == 0 || island[test.Y] == 0)
                {
					island[test.X] = island[test.Y] = Math.Max(island[test.X], island[test.Y]);
                }
				else 
                {
					if (island[test.X] == island[test.Y]) continue;
					int testY = island[test.Y];
					for (int i = 0; i < island.Count(); i++)
                    {
						island[i] = island[i] == testY ? island[test.X] : island[i];
					}

                }
				answer += test.Z;
			}
			return answer;
		}

		/// <summary>
		/// 프로그래머스 깊이/너비 우선 탐색(DFS/BFS) 2단계 타겟 넘버
		/// </summary>
		/// <param name="numbers"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public int targetNumber(int[] numbers, int target)
		{
			int answer = 0;
			int n = Int32.Parse(Math.Pow(2, numbers.Count()).ToString()) - 1;
			int len = Convert.ToString(n, 2).Length;

			for (int i = 0; i <= n; i++)
			{
				int target_sub = 0;
				string str = Convert.ToString(i, 2);
				str = str.PadLeft(len, '0');
				int cnt = 0;
				foreach (char c in str)
				{
					target_sub = c == '0' ? target_sub + numbers[cnt++] : target_sub - numbers[cnt++];
				}
				if (target_sub == target) answer++;
			}
			return answer;
		}

		public static void Coin()
		{
			//3,10 1 2 5
			int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] dp = new int[10001];
			dp.Initialize();
			dp[0] = 1;
			int[] coin = new int[arr[0] + 1];
			coin[0] = 0;
			for (int i = 1; i < coin.Length; i++) coin[i] = int.Parse(Console.ReadLine());

			for (int i = 1; i < coin.Length; i++)
			{
				for (int j = 0; j < dp.Length; j++)
				{
					//if (j == coin[i])
					//{
					//	dp[j] = dp[j] + 1;
					//}
					//else if (j > coin[i])
					//{
					//	dp[j] = dp[j] + dp[j - coin[i]];
					//}					
					dp[j] = j > coin[i] ? dp[j] + dp[j - coin[i]] : j == coin[i] ? dp[j] + 1 : dp[j];
				}
			}
			Console.WriteLine(dp[arr[1]]);

		}

		public static void Dfs_Bfs()
		{
			//4 5 1//1 2// 1 3//1 4//2 4//3 4//1 2 4 3//1 2 3 4//
			int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[,] data = new int[arr[0] + 1, arr[0] + 1];
			for (int i = 0; i < arr[1]; i++)
			{
				int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				data[i, 0] = input[0];
				data[i, 1] = input[1];
			}
			//Array.Sort(data);

		}

		public static void HideNSeek()
		{
			//5 17 // 4
			int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int x = input[0];
			int v = input[1];
			Queue q = new Queue();
			int[] visit = new int[10002];
			visit[x] = 1;
			q.Enqueue(x);
			while (q.Count != 0)
			{
				x = (int)q.Dequeue();
				if (x == v)
				{
					Console.WriteLine(visit[x] - 1);
					return;
				}

				if (x - 1 >= 0 && visit[x - 1] == 0)
				{
					visit[x - 1] = visit[x] + 1;
					q.Enqueue(x - 1);
				}
				if (x + 1 <= 10001 && visit[x + 1] == 0)
				{
					visit[x + 1] = visit[x] + 1;
					q.Enqueue(x + 1);
				}
				if (x * 2 <= 10001 && visit[x * 2] == 0)
				{
					visit[x * 2] = visit[x] + 1;
					q.Enqueue(x * 2);
				}
			}
		}

		public static void MinRoute()
		{
			//int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			//int start = int.Parse(Console.ReadLine());
			int[] input = new int[] { 5, 6 };
			int start = 1;
			int[] dist = new int[input[0] + 1];
			for (int i = 0; i < dist.Length; i++) dist[i] = 300002;
			dist[start] = 1;
			int[,] data = new int[input[1], 3];
			//List<int> list = new List<int>();
			Queue que = new Queue();
			que.Enqueue(start);
			int[] visit = new int[input[0] + 1];
			//for (int i = 0; i < input[1]; i++)
			for (int i = 0; i < 6; i++)
			{
				int[] route = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				data[i, 0] = route[0];
				data[i, 1] = route[1];
				data[i, 2] = route[2];
			}
			var sorted = from x in Enumerable.Range(0, data.GetLength(0))
						 select new
						 {
							 X = data[x, 0],
							 Y = data[x, 1],
							 Z = data[x, 2]
						 } into point
						 where point.Z != 0
						 orderby point.X ascending, point.Z ascending, point.Y ascending
						 select point;
			List<Prior> list = new List<Prior>();
			foreach (var test in sorted)
			{
				Prior pr = new Prior();
				pr.X = test.X;
				pr.Y = test.Y;
				pr.Z = test.Z;
				list.Add(pr);
			}
			while (que.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].X > (int)que.Peek()) break;
					if (list[i].X == (int)que.Peek())
					{
						dist[list[i].Y] = Math.Min(dist[list[i].Y], dist[list[i].X] + list[i].Z);
						if (visit[list[i].Y] == 0)
						{
							visit[list[i].Y]++;
							que.Enqueue(list[i].Y);
							list.RemoveAt(i);
							i--;
						}

					}
				}
				que.Dequeue();

			}
			for (int i = 1; i < dist.Length; i++) Console.WriteLine(dist[i] == 300002 ? "INF" : (dist[i] - 1).ToString());
		}

		public static void BitMask()
		{
			int cnt = int.Parse(Console.ReadLine());
			bool[] data = new bool[21];
			data.Initialize();
			StringBuilder str = new StringBuilder();
			while (cnt > 0)
			{
				string[] input = Console.ReadLine().Split();
				int n = 0;
				if (input.Length > 1) n = int.Parse(input[1]);
				switch (input[0])
				{
					case "add":
						data[n] = true;
						break;
					case "remove":
						data[n] = false;
						break;
					case "check":
						Console.WriteLine(data[n] ? "1\n" : "0\n");
						break;
					case "toggle":
						data[n] = !data[n];
						break;
					case "all":
						data = Enumerable.Repeat(true, 21).ToArray();
						break;
					case "empty":
						data = new bool[21];
						break;

				}
				cnt--;
			}
		}

		public static void Lst()
		{
			int[] _base = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] dot = new int[10001];
			int[,] data = new int[_base[1], 3];
			for (int i = 0; i < _base[1]; i++)
			{
				int[] route = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				data[i, 0] = route[0];
				data[i, 1] = route[1];
				data[i, 2] = route[2];
			}
			var sorted = from x in Enumerable.Range(0, data.GetLength(0))
						 select new
						 {
							 X = data[x, 0],
							 Y = data[x, 1],
							 Z = data[x, 2]
						 } into point
						 orderby point.X ascending, point.Z ascending, point.Y ascending
						 select point;
			List<Prior> list = new List<Prior>();
			foreach (var test in sorted)
			{
				Prior pr = new Prior();
				pr.X = test.X;
				pr.Y = test.Y;
				pr.Z = test.Z;
				list.Add(pr);
			}
			for (int i = 0; i < list.Count - 1; i++)
			{
				if (!Join(list[i].X, list[i].Y, dot))
				{ }
			}
		}

		public static bool Join(int x, int y, int[] dot)
		{
			int _x = ParentRoute(x, dot);
			int _y = ParentRoute(y, dot);
			if (_x == _y)
			{
				return true;
			}
			else if (_x < _y)
			{
				dot[_y] = _x;
			}
			else
			{
				dot[_x] = _y;
			}

			return false;
		}
		public static int ParentRoute(int x, int[] dot)
		{
			if (dot[x] == x) return x;
			else return ParentRoute(x, dot);
		}

		public static void Tree_Dp()
		{
			//7 //10 30 40 10 20 20 70//14 16 45 26 23 37
			//int n = int.Parse(Console.ReadLine());
			//int[] popul = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
			//List<List<int>> list2 = new List<List<int>>();
			//for (int i = 0; i < n + 1; i++) list2.Add(new List<int>());
			//int answer = 0;
			//for (int i = 0; i < n - 1; i++)
			//{
			//	int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			//	if (input[0] > input[1])
			//	{
			//		list2[input[1]].Add(input[0]);
			//	}
			//	else
			//	{
			//		list2[input[0]].Add(input[1]);
			//	}
			//}
			//answer = Math.Max(Tree_Dp_Sub(1, list2, popul, true), Tree_Dp_Sub(1, list2, popul, false));

			//Console.WriteLine(answer);
			int n = int.Parse(Console.ReadLine());
			int[] popul = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			List<List<int>> list2 = new List<List<int>>();
			bool[] visited = new bool[n + 1];
			for (int i = 0; i < n + 1; i++) list2.Add(new List<int>());
			int answer = 0;
			for (int i = 0; i < n - 1; i++)
			{
				int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				list2[input[1]].Add(input[0]);
				list2[input[0]].Add(input[1]);
			}
			answer = Tree_Dp_Sub(1, list2, popul, true, visited);
			answer = Math.Max(answer, Tree_Dp_Sub(1, list2, popul, false, visited));
			Console.WriteLine(answer);
		}

		public static int Tree_Dp_Sub(int pos, List<List<int>> list, int[] popul, bool visit, bool[] visited)
		{
			//int answer = 0;
			//for (int i = 0; i < list[pos].Count; i++)
			//{
			//	if(visit)
			//	{
			//		answer += Tree_Dp_Sub(list[pos][i], list, popul, false);
			//	}
			//	else 
			//	{
			//		answer += Math.Max(Tree_Dp_Sub(list[pos][i], list, popul, false), Tree_Dp_Sub(list[pos][i], list, popul, true));
			//	}

			//}
			//if (visit && pos > 0) answer += popul[pos - 1];

			//return answer;
			visited[pos] = true;
			int answer = 0;
			for (int i = 0; i < list[pos].Count; i++)
			{
				if (visited[list[pos][i]]) continue;
				if (visit) answer += Tree_Dp_Sub(list[pos][i], list, popul, false, visited);
				else answer += Math.Max(Tree_Dp_Sub(list[pos][i], list, popul, false, visited), Tree_Dp_Sub(list[pos][i], list, popul, true, visited));
			}
			if (visit && pos > 0) answer += popul[pos - 1];
			visited[pos] = false;
			return answer;

		}

		public static void SelectStr()
		{
			// ABC ABCDAB ABCDABCDABDE ABCDABDABCDABD asdABCDABD
			string str = Console.ReadLine();
			string answer = string.Empty;
			string find = Console.ReadLine();
			int cnt = 0;
			for (int i = 0; i < str.Length; i++)
			{
				int index = str.IndexOf(find, i);
				if (index >= 0)
				{
					answer += (index + 1).ToString() + " ";
					i = index;
					cnt++;
				}
			}

			Console.WriteLine(answer.Trim());
		}

		/// <summary>
		/// 오토에버 챌린지 3번
		/// </summary>
		/// <param name="pStr"></param>
		/// <returns></returns>
		public static string ConvertStr(string pStr)
		{
			string answer = string.Empty;
			bool isChange = false;
			string newStr = string.Empty;
			string curStr = string.Empty;
			char newC = '0';
			for (int i = 0; i < pStr.Length; i++)
			{
				for (int j = i + 1; j < pStr.Length; j++)
				{
					if (pStr[j] > pStr[i] && pStr[j] >= newC)
					{
						curStr = pStr.Substring(0, i) + ConvertStr_Sub(pStr.Substring(i, j - i + 1));
						if (j < pStr.Length - 1) curStr += pStr.Substring(j + 1, pStr.Length - j - 1);
						if (curStr.CompareTo(newStr) > 0)
						{
							newStr = curStr;
							newC = pStr[j];
						}
						isChange = true;
					}
				}
				if (isChange) break;
			}
			answer = newStr;
			return answer;
		}
		public static string ConvertStr_Sub(string pStr)
		{
			string rtnStr = string.Empty;
			Stack s = new Stack();
			for (int i = 0; i < pStr.Length; i++)
			{
				s.Push(pStr.Substring(i, 1));
			}
			while (s.Count > 0)
			{
				rtnStr += s.Pop().ToString();
			}
			return rtnStr;
		}

		/// <summary>
		/// 오토에버 챌린지 2번
		/// </summary>
		/// <param name="open">갈수있는 길</param>
		/// <param name="r1">출발 행</param>
		/// <param name="c1">출발 열</param>
		/// <param name="r2">목적 행</param>
		/// <param name="c2">목적 열</param>
		/// <param name="rcnt">행 추가</param>
		/// <param name="ccnt">열 추가</param>
		/// <returns></returns>
		public static int ShortestPass(int[,] open, int r1, int c1, int r2, int c2, int rcnt, int ccnt)
		{
			//{ { 1, 1, 2, 1 }, { 2, 1, 2, 2 }, { 2, 2, 1, 2 }, { 2, 2, 2, 3 }, { 1, 2, 1, 3 } }, 3, 1, 1, 9, 2, 3
			int answer = 0;
			//int[,] block = new int[,] { };
			int[,] map = new int[(rcnt * rcnt) + 1, (ccnt * ccnt) + 1];
			List<string> list = new List<string>();
			string route = string.Empty;
			for (int i = 0; i < open.GetLength(0); i++)
			{
				route = string.Empty;
				route = open[i, 0].ToString() + open[i, 1].ToString() + open[i, 2].ToString() + open[i, 3].ToString();
				list.Add(route);
				route = open[i, 2].ToString() + open[i, 3].ToString() + open[i, 0].ToString() + open[i, 1].ToString();
				list.Add(route);
			}
			for (int i = 0; i < map.GetLength(0); i++)
			{
				for (int j = 0; j < map.GetLength(1); j++)
				{
					map[i, j] = 999999;
				}
			}
			map[r1, c1] = 0;

			Route(r1, c1, list, rcnt, ccnt, 0, map);
			answer = map[r2, c2];
			for (int i = 0; i < map.GetLength(0); i++)
			{
				for (int j = 0; j < map.GetLength(1); j++)
				{
					Console.Write(map[i, j] == 999999 ? "0\t" : map[i, j].ToString() + "\t");
				}
				Console.WriteLine();
			}

			return answer;
		}
		delegate int Move(int a, int b);
		public static bool IsPass(int fromX, int fromY, string direction, List<string> route, int rcnt, int ccnt)
		{
			bool rtnBool = false;
			Move devide = (a, b) => ((a - 1) / b) + 1;
			Move minus = (a, b) => (a % b) == 0 ? b : (a % b);
			int x1 = minus(fromX, rcnt);
			int y1 = minus(fromY, ccnt);
			int x2 = x1;
			int y2 = y1;

			x2 = direction == "UP" ? x1 - 1 : direction == "DOWN" ? x1 + 1 : x1;
			y2 = direction == "LEFT" ? y1 - 1 : direction == "RIGHT" ? y1 + 1 : y1;

			string moving1 = x1.ToString() + y1.ToString() + x2.ToString() + y2.ToString();
			foreach (string str in route)
			{
				if (str == moving1) rtnBool = true;
			}
			if (!rtnBool)
			{
				x2 = direction == "UP" ? fromX - 1 : direction == "DOWN" ? fromX + 1 : fromX;
				y2 = direction == "LEFT" ? fromY - 1 : direction == "RIGHT" ? fromY + 1 : fromY;
				x1 = devide(fromX, rcnt);
				y1 = devide(fromY, ccnt);
				x2 = devide(x2, rcnt);
				y2 = devide(y2, ccnt);
				string moving2 = x1.ToString() + y1.ToString() + x2.ToString() + y2.ToString();
				foreach (string str in route)
				{
					if (str == moving2) rtnBool = true;
				}
			}
			return rtnBool;
		}

		public static void Route(int fromX, int fromY, List<string> route, int rcnt, int ccnt, int movCnt, int[,] map)
		{
			if (fromX - 1 > 0 && map[fromX - 1, fromY] > movCnt + 1)
			{
				if (IsPass(fromX, fromY, "UP", route, rcnt, ccnt))
				{
					map[fromX - 1, fromY] = movCnt + 1;
					Route(fromX - 1, fromY, route, rcnt, ccnt, movCnt + 1, map);
				}
			}
			if (fromX + 1 <= rcnt * rcnt && map[fromX + 1, fromY] > movCnt + 1)
			{
				if (IsPass(fromX, fromY, "DOWN", route, rcnt, ccnt))
				{
					map[fromX + 1, fromY] = movCnt + 1;
					Route(fromX + 1, fromY, route, rcnt, ccnt, movCnt + 1, map);
				}
			}
			if (fromY - 1 > 0 && map[fromX, fromY - 1] > movCnt + 1)
			{
				if (IsPass(fromX, fromY, "LEFT", route, rcnt, ccnt))
				{
					map[fromX, fromY - 1] = movCnt + 1;
					Route(fromX, fromY - 1, route, rcnt, ccnt, movCnt + 1, map);
				}
			}
			if (fromY + 1 <= ccnt * ccnt && map[fromX, fromY + 1] > movCnt + 1)
			{
				if (IsPass(fromX, fromY, "RIGHT", route, rcnt, ccnt))
				{
					map[fromX, fromY + 1] = movCnt + 1;
					Route(fromX, fromY + 1, route, rcnt, ccnt, movCnt + 1, map);
				}
			}
		}

		/// <summary>
		/// 프로그래머스 완전탐색 2단계 카펫
		/// </summary>
		/// <param name="brown"></param>
		/// <param name="yellow"></param>
		/// <returns></returns>
		public static int[] Capet(int brown, int yellow)
		{
			//10 2 [4,3] // 8 1 [3,3] //24 24 [8,6]
			int[] answer = new int[2];
			double x = 0;
			double y = 0;
			int b = ((brown / 2) - 2);
			x = (b + Math.Sqrt((b * b) - (4 * yellow))) / 2;
			y = (b - Math.Sqrt((b * b) - (4 * yellow))) / 2;
			answer[0] = (int)x + 2;
			answer[1] = (int)y + 2;
			Console.WriteLine("{0}, {1}", x + 2, y + 2);
			return answer;
		}

		/// <summary>
		/// 프로그래머스 그래프 3단계 가장 먼 노드
		/// </summary>
		/// <param name="n"></param>
		/// <param name="edge"></param>
		/// <returns></returns>
		public static int FarthestNode(int n, int[,] edge)
		{
			//6, {{3,6},{4,3},{3,2},{1,5},{1,3},{5,4},{5,2}} = 3
			int answer = 0;
			int[] distance = new int[n + 1];
			int max = 0;
			bool[,] dp = new bool[n + 1, n + 1];
			for (int i = 0; i < edge.GetLength(0); i++)
			{
				dp[edge[i, 0], edge[i, 1]] = dp[edge[i, 1], edge[i, 0]] = true;
			}
			Queue<int> q = new Queue<int>();
			distance[1] = 1;
			q.Enqueue(1);

			while (q.Count > 0)
			{
				int que = q.Dequeue();
				for (int i = 1; i < dp.GetLength(0); i++)
				{
					if (!dp[que, i]) continue;
					if (distance[i] == 0)
					{
						distance[i] = distance[que] + 1;
						q.Enqueue(i);

						if (max < distance[i])
						{
							answer = 0;
							max = distance[i];
						}
						if (max == distance[i]) answer++;

					}
				}
			}
			return answer;
		}

		/// <summary>
		/// 프로그래머스 동적계획법 3단계 N으로 표현
		/// </summary>
		/// <param name="N"></param>
		/// <param name="number"></param>
		/// <returns></returns>
		public static int ExpressedByN(int N, int number)
		{
			List<List<int>> dplist = new List<List<int>>();
			List<int> list = new List<int>();
			list.Add(N);
			dplist.Add(list);

			for (int i = 1; i < 8; i++)
			{
				List<int> tempList = new List<int>();
				tempList.Add((N * (int)Math.Pow(10, i)) + dplist[i - 1][0]);
				dplist.Add(tempList);
			}

			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					if (i + j + 1 >= 8) break;
					for (int icnt = 0; icnt < dplist[i].Count; icnt++)
					{
						for (int jcnt = 0; jcnt < dplist[j].Count; jcnt++)
						{
							if (dplist[i][icnt] < 0 || dplist[j][jcnt] < 0) continue;
							dplist[i + j + 1].Add(dplist[i][icnt] + dplist[j][jcnt]);
							dplist[i + j + 1].Add(dplist[i][icnt] - dplist[j][jcnt]);
							dplist[i + j + 1].Add(dplist[i][icnt] * dplist[j][jcnt]);
							if (dplist[j][jcnt] > 0) dplist[i + j + 1].Add(dplist[i][icnt] / dplist[j][jcnt]);
							if (dplist[i][icnt] > 0) dplist[i + j + 1].Add(dplist[j][jcnt] / dplist[i][icnt]);
						}
					}
					dplist[i + j + 1] = dplist[i + j + 1].Distinct().ToList();
				}

				if (dplist[i].Contains(number)) return i + 1;
			}
			return -1;
		}

		/// <summary>
		/// 프로그래머스 월간 코드 챌린지 시즌1 3단계 풍선터트리기
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		public static int Balloon(int[] a)
		{
			//[-16,27,65,-2,58,-92,-71,-68,-61,-33]
			//-16, -92, -71, -68, -61, -33
			if (a.Length == 1) return 1;

			int answer = 0;
			int length = a.Length;
			int[] minFront = new int[length];
			int[] minBack = new int[length];

			minFront[0] = a[0];
			minBack[length - 1] = a[length - 1];
			for (int i = 1; i < length; i++)
			{
				minFront[i] = Math.Min(minFront[i - 1], a[i]);
				minBack[length - 1 - i] = Math.Min(minBack[length - i], a[length - 1 - i]);
			}

			for (int i = 1; i < a.Length - 1; i++)
			{
				if (a[i] > minFront[i - 1] && a[i] > minBack[i + 1]) continue;
				answer++;
			}

			return answer + 2;
		}

		/// <summary>
		/// 프로그래머스 깊이/너비 우선 탐색(DFS/BFS) 3단계 네트워크
		/// </summary>
		/// <param name="n"></param>
		/// <param name="computers"></param>
		/// <returns></returns>
		public static int Network(int n, int[,] computers)
		{
			int answer = 200;
			int[] network = new int[n];
			int temp = 0;
			Queue<int> que = new Queue<int>();
			for (int i = 0; i < computers.GetLength(0); i++)
			{
				if (network[i] == 0) que.Enqueue(i);
				while (que.Count > 0)
				{
					temp = que.Dequeue();
					for (int j = 0; j < computers.GetLength(0); j++)
					{
						if (computers[temp, j] == 0) continue;
						if (network[j] == answer) continue;
						if (temp == j && network[temp] == 0) network[temp] = --answer;
						if (temp == j) continue;

						network[j] = answer;
						que.Enqueue(j);
					}
				}
			}
			
			return 200 - answer;
		}

		/// <summary>
		/// 프로그래머스 깊이/너비 우선 탐색(DFS/BFS) 3단계 여행경로
		/// </summary>
		/// <param name="tickets"></param>
		/// <returns></returns>
		public static string[] TravelPath(string[,] tickets)
        {		
			List<string> answerList = new List<string>();
			Dictionary<string, List<Tuple<string,int>>> dict = new Dictionary<string, List<Tuple<string, int>>>();
			for (int i = 0; i < tickets.GetLength(0); i++)
            {
				List<Tuple<string, int>> list = new List<Tuple<string, int>>();
				list.Add(Tuple.Create(tickets[i, 1], 0));
				if(!dict.ContainsKey(tickets[i,0])) dict.Add(tickets[i, 0],list);
				else
                {
					list = dict[tickets[i, 0]];
					list.Add(Tuple.Create(tickets[i, 1], 0));
					dict[tickets[i, 0]] = list;
				}
            }
			for (int i = 0; i < dict.Count; i++)
			{
				var sub = dict.ElementAt(i).Value.OrderBy(key => key.Item1);
				dict[dict.ElementAt(i).Key] = sub.ToList();
				//dict[dict.ElementAt(i).Key] = sub.ToList((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
			}
			
			Queue<string> queue = new Queue<string>();
			queue.Enqueue("ICN");
			while(queue.Count > 0)
            {
				string key = queue.Dequeue();
				answerList.Add(key);
				//Dictionary<string, int> value =  dict[key];
				List<Tuple<string, int>> value = dict[key];
				for (int i = 0; i < value.Count; i++)
                {
					if (value[i].Item2 == 0)
					{
						if (dict.ContainsKey(value[i].Item1) && dict[value[i].Item1].Exists(x => x.Item2 == 0))
						{
							queue.Enqueue(value[i].Item1);
							value[i] = Tuple.Create(value[i].Item1, 1);
							dict[key] = value;
							break;
						}
						if (answerList.Count == tickets.GetLength(0)) answerList.Add(value[i].Item1);
						continue;
					}
                }
            }
			string[] answer = answerList.ToArray();
			return answer;
        }

		/// <summary>
		/// 프로그래머스 월간 코드 챌린지 시즌1 2단계 삼각 달팽이
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static int[] TriangularSnail(int n)
		{
			//4 [1, 2, 9, 3, 10, 8, 4, 5, 6, 7]
			//5 [1, 2, 12, 3, 13, 11, 4, 14, 15, 10, 5, 6, 7, 8, 9]
			//6 [1, 2, 15, 3, 16, 14, 4, 17, 21, 13, 5, 18, 19, 20, 12, 6, 7, 8, 9, 10, 11]
			int[] answer = new int[(n*(n+1))/2] ;
			int[,] arr = new int[n, n];
			int idx = 1;
			int row = 0;
			int col = 0;
			char flag = 'D';
			for (int i = n; i > 0; i--)
            {
				switch (flag)
				{
					case 'D':
						for (int j = 0; j < i; j++)
						{
							arr[row + j, col] = idx++;
						}
						row += i - 1;
						col++;
						flag = 'R';
						break;
					case 'R':
						for (int j = 0; j < i; j++)
						{
							arr[row, col + j] = idx++;
						}
						row--;
						col += i - 2;
						flag = 'U';
						break;
					case 'U':
						for (int j = 0; j < i; j++)
						{
							arr[row--, col--] = idx++;
						}
						row += 2;
						col++;
						flag = 'D';
						break;
                }				
            }
			idx = 0;
			for(int i = 0; i < n; i ++)
            {
				for(int j = 0; j <= i; j++)
                {
					answer[idx++] = arr[i, j];
                }
            }
			return answer;
		}
	}
	public class Print
	{
		public int num;
		public int prior;
	}
	public class Prior
	{
		public int X;
		public int Y;
		public int Z;
	}
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; 

namespace System
{
	/// <summary>
	/// 冒泡排序算法
	/// <para>稳定排序</para>
	/// </summary>
	public static partial class _BubbleSort
	{
		/// <summary>
		/// 冒泡排序
		/// 请勿传null给本函数，否则将发生异常
		/// <para>稳定排序</para>
		/// <para>冒泡排序（降序）原理：</para>
		/// <para>每轮找到最小的数放到已排好的数列。</para>
		/// <para>从左到右以此比较两个相邻的数，若左小右大顺序则交换一下。</para>
		/// <para>这样，当一轮比较结束，最小的数就排在了最右边。</para>
		/// <para>下一轮比较前N-1个数即可。</para>
		/// <para>经过N-1轮比较，数列就是大->小排序的了。</para>
		/// <para>改进的冒泡排序：当某轮比较没有发生移动时，就可以确定排序完成了，从而减少了排序的轮数。</para>
		/// <para>稳定排序</para>
		/// <para>时间复杂度为O(n^2)</para>
		/// </summary>
		/// <typeparam name="T">实现了IComparable的类型<para>例如int</para></typeparam>
		/// <param name="arr">请勿传null给本参数，否则将发生异常</param>
		/// <param name="descending">true为降序排序，false为升序排序</param>
		public static void BubbleSort<T>(this IList<T> arr, bool descending = true)
			where T : IComparable
		{
			if (descending)
				arr.BubbleSortDescending();
			else
				arr.BubbleSortAscending();
		}
	}
	/// <summary>
	/// 直接插入排序算法
	/// <para>稳定排序</para>
	/// </summary>
	public static partial class _InsertionSort
	{
		/// <summary>
		/// 直接插入排序
		/// 请勿传null给本函数，否则将发生异常
		/// <para>稳定排序</para>
		/// <para>直接插入排序（降序）原理：</para>
		/// <para>将剩余数列的第一个加入已排好的数列。</para>
		/// <para>这是玩扑克牌的排序方法。</para>
		/// <para>一张一张地拿牌，拿到一张新牌时，就跟之前手里的牌从右到左地比较。</para>
		/// <para>若新牌大，则将此处的旧牌向右移动，原位置空了出来。</para>
		/// <para>当新牌不再大时，插入空位。</para>
		/// <para>当全部牌拿完，顺序就排好了。</para>
		/// <para>稳定排序</para>
		/// <para>时间复杂度为O(n2)</para>
		/// </summary>
		/// <typeparam name="T">实现了IComparable的类型<para>例如int</para></typeparam>
		/// <param name="arr">请勿传null给本参数，否则将发生异常</param>
		/// <param name="descending">true为降序排序，false为升序排序</param>
		public static void InsertionSort<T>(this IList<T> arr, bool descending = true)
			where T : IComparable
		{
			if (descending)
				arr.InsertionSortDescending();
			else
				arr.InsertionSortAscending();
		}
	}
	/// <summary>
	/// 归并排序算法
	/// <para>稳定排序</para>
	/// </summary>
	public static partial class _MergeSort
	{
		/// <summary>
		/// 归并排序
		/// 请勿传null给本函数，否则将发生异常
		/// <para>稳定排序</para>
		/// <para>归并排序（降序）原理：</para>
		/// <para>利用了递归进行排序的方法。先排好左右两部分，再合并。</para>
		/// <para>将数列等分为左右两部分，先分别对其排序，再将分别排好的两个数列归并为一个排好的序列。</para>
		/// <para>循环之，直到这部分只有1个数，那么这部分已经排好序了。</para>
		/// <para>归并过程，将排好的两部分列队，从第一个数开始比较，将较大的放到最终要排的数列。</para>
		/// <para>若最后剩下一些数，直接接到数列最后即可。</para>
		/// <para>稳定排序</para>
		/// <para>时间复杂度为O(nlogn)</para>
		/// </summary>
		/// <typeparam name="T">实现了IComparable的类型<para>例如int</para></typeparam>
		/// <param name="arr">请勿传null给本参数，否则将发生异常</param>
		/// <param name="descending">true为降序排序，false为升序排序</param>
		public static void MergeSort<T>(this IList<T> arr, bool descending = true)
			where T : IComparable
		{
			if (descending)
				arr.MergeSortDescending();
			else
				arr.MergeSortAscending();
		}
	}
	/// <summary>
	/// 快速排序算法
	/// <para>不稳定排序</para>
	/// </summary>
	public static partial class _QuickSort
	{
		/// <summary>
		/// 快速排序
		/// 请勿传null给本函数，否则将发生异常
		/// <para>不稳定排序</para>
		/// <para>快速排序（降序）原理：</para>
		/// <para>使用了递归的方法，为第一个数找到其应该在的位置，然后分别对其左右部分使用快速排序。</para>
		/// <para>网上说是对冒泡排序的改进，我看不出来是怎么改进的。</para>
		/// <para>为第一个数字找其应该在的位置的方法：与右边的比较，有大的就交换；然后与左边的比较，有小的就交换。</para>
		/// <para>那么最后所有大的都在其左边了，所有小的都在其右边了，这个数的位置就是一定是正确的。</para>
		/// <para>不稳定排序</para>
		/// <para>时间复杂度为O(nlogn)</para>
		/// </summary>
		/// <typeparam name="T">实现了IComparable的类型<para>例如int</para></typeparam>
		/// <param name="arr">请勿传null给本参数，否则将发生异常</param>
		/// <param name="descending">true为降序排序，false为升序排序</param>
		public static void QuickSort<T>(this IList<T> arr, bool descending = true)
			where T : IComparable
		{
			if (descending)
				arr.QuickSortDescending();
			else
				arr.QuickSortAscending();
		}
	}
	/// <summary>
	/// 选择排序算法
	/// <para>不稳定排序</para>
	/// </summary>
	public static partial class _SelectionSort
	{
		/// <summary>
		/// 选择排序
		/// 请勿传null给本函数，否则将发生异常
		/// <para>不稳定排序</para>
		/// <para>选择排序（降序）原理：</para>
		/// <para>是冒泡排序的改进，每一轮找到最大的数放到已排好的数列。</para>
		/// <para>首先认为第一个是最大的，然后依次比较，发现更大的时更新之，记录其索引，比较完之后，将第一个元素与记录索引的数交换依次即可。</para>
		/// <para>就是说，选择排序为了排好一个数，只需发生一次交换。</para>
		/// <para>稳定排序</para>
		/// <para>时间复杂度为O(n2)</para>
		/// </summary>
		/// <typeparam name="T">实现了IComparable的类型<para>例如int</para></typeparam>
		/// <param name="arr">请勿传null给本参数，否则将发生异常</param>
		/// <param name="descending">true为降序排序，false为升序排序</param>
		public static void SelectionSort<T>(this IList<T> arr, bool descending = true)
			where T : IComparable
		{
			if (descending)
				arr.SelectionSortDescending();
			else
				arr.SelectionSortAscending();
		}
	}
	/// <summary>
	/// 希尔排序算法
	/// <para>不稳定排序</para>
	/// </summary>
	public static partial class _ShellSort
	{
		/// <summary>
		/// 希尔排序
		/// 请勿传null给本函数，否则将发生异常
		/// <para>不稳定排序</para>
		/// <para>希尔排序（降序）原理：</para>
		/// <para>又称为缩小增量法，属于插入类的排序。</para>
		/// <para>将数列分割为若干子数列，对各个子数列中相同位置的数进行直接插入排序。</para>
		/// <para>逐渐缩小子数列的长度，直到子数列只有一个数。</para>
		/// <para>不稳定排序</para>
		/// <para>时间复杂度为O(n1.5)</para>
		/// </summary>
		/// <typeparam name="T">实现了IComparable的类型<para>例如int</para></typeparam>
		/// <param name="arr">请勿传null给本参数，否则将发生异常</param>
		/// <param name="descending">true为降序排序，false为升序排序</param>
		public static void ShellSort<T>(this IList<T> arr, bool descending = true)
			where T : IComparable
		{
			if (descending)
				arr.ShellSortDescending();
			else
				arr.ShellSortAscending();
		}
	}
	/// <summary>
	/// 堆排序算法
	/// <para>不稳定排序</para>
	/// </summary>
	public static partial class _HeapSort
	{
		/// <summary>
		/// 堆排序
		/// 请勿传null给本函数，否则将发生异常
		/// <para>不稳定排序</para>
		/// <para>堆排序（降序）原理：</para>
		/// <para>对冒泡排序的改进。</para>
		/// <para>冒泡排序每轮都要对剩余数列完整比较一遍，堆排序则通过树的形式保留了中间的比较结果，从而减少了比较次数。</para>
		/// <para>开始时先构造小根堆（从最后一个非叶结点开始）。</para>
		/// <para>然后循环，将根（最小数）与数列最后一个数字交换，就得到了最小数。对剩余的数列再次构造小根堆并得到当前最小数，直到堆只有一个数字。</para>
		/// <para>不稳定排序</para>
		/// <para>时间复杂度为O(nlogn)</para>
		/// </summary>
		/// <typeparam name="T">实现了IComparable的类型<para>例如int</para></typeparam>
		/// <param name="arr">请勿传null给本参数，否则将发生异常</param>
		/// <param name="descending">true为降序排序，false为升序排序</param>
		public static void HeapSort<T>(this IList<T> arr, bool descending = true)
			where T : IComparable
		{
			if (descending)
				arr.HeapSortDescending();
			else
				arr.HeapSortAscending();
		}
	}
}

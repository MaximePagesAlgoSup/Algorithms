using System.Xml.Linq;

namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        int l = xs.Length;
        if (l != ys.Length) return false;
        for (int i = 0; i < l; i++)
        {
            if (xs[i].Equals(ys[i])) continue;
            return false;
        }
        return true;


    }

    public static void Swap<T>(T[] xs, int a, int b)
    {
        T temp = xs[a];
        xs[a] = xs[b];
        xs[b] = temp;
    }

    public static T FirstElement<T>(T[] xs)
    {
        return xs[0];
    }

    public static T LastElement<T>(T[] xs)
    {
        return xs[xs.Length - 1];
    }

    public static T MiddleElement<T>(T[] xs)
    {
        return xs[xs.Length / 2];
    }

    public static void Reverse<T>(T[] xs)
    {
        if (xs.Length <= 1) return;
        int l = xs.Length-1;
        for (int i = 0; i <= l/2;i++)
        {
            Swap(xs, i, l - i);
        }
    }

    public static int CountElement<T>(T[] xs, T element)
    {
        int acc = 0;
        foreach(T curr in xs)
        {
            if (curr.Equals(element)) acc++;
        }
        return acc;
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        int l = xs.Length-1;
        if (l == -1) return "";
        string acc = "";
        for(int i = 0; i < l; i++)
        {
            acc += xs[i].ToString() + ",";
        }
        return acc + xs[l];
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        int acc = 0;
        foreach (T curr in xs)
        {
            if (predicate(curr)) acc++;
        }
        return acc;
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        T tmp = xs[0];
        foreach(T curr in xs)
        {
            if (comparer(curr, tmp) >= 0) tmp = curr;
        }
        return tmp;
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        T tmp = xs[0];
        foreach (T curr in xs)
        {
            if (comparer(curr, tmp) <= 0) tmp = curr;
        }
        return tmp;
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        int l = xs.Length - 1;
        for (int i = 0; i < l; i++)
        {
            for (int j = i + 1; j <= l; j++)
            {
                if (xs[i].Equals(xs[j])) return true;
            }
        }
        return false;
    }
}
///</remark>
using System;
public class PrimeGenerator
{
 private static bool[] f;
 private static int[] result;
 public static int[] GeneratePrimeNumbers(int maxValue)
 {
 if (maxValue < 2)
 return new int[0];
 else
 {
 InitializeArrayOfIntegers(maxValue);
 CrossOutMultiples();
 PutUncrossedIntegersIntoResult();
 return result;
 }
 }
 private static void InitializeArrayOfIntegers(int maxValue)
 {
 // объявления
 f = new bool[maxValue + 1];
 f[0] = f[1] = false; //не простые числа и не кратные
 for (int i = 2; i < f.Length; i++)
 f[i] = true;
 }
 private static void LoadPrimes()
 {
 int i;
 int j;
 // сколько оказалось простых чисел?
 int count = 0;
 for (i = 0; i < s; i++)
 {
 if (f[i])
 count++; // увеличить счетчик
 }
 primes = new int[count];
 // поместить простые числа в результирующий массив
 for (i = 0, j = 0; i < s; i++)
 {
 if (f[i]) // если простое
 primes[j++] = i;
 }
 }
 private static void Sieve()
 {
 int i;
 int j;
 for (i = 2; i < Math.Sqrt(s) + 1; i++)
 {
 if(f[i]) // если i не вычеркнуто, вычеркнуть его кратные.
 {
 for (j = 2 * i; j < s; j += i)
 f[j] = false; // кратное – не простое число
 }
 }
 }
 private static void InitializeSieve(int maxValue)
 {
 // объявления
 s = maxValue + 1; // размер массива
 f = new bool[s];
 int i;
 // инициализировать элементы массива значением true.
 for (i = 0; i < s; i++)
 f[i] = true;
 // исключить заведомо не простые числа
 f[0] = f[1] = false;
 }
}

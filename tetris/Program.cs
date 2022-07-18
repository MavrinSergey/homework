int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
 
// сортировка
int temp = nums[0];
for (int k = 0; k < nums.Length - 1; k++)
{
    for (int l = k + 1; l < nums.Length; l++)
    {
        if (nums[k] > nums[l])
        {
            temp = nums[k];
            nums[k] = nums[l];
            nums[l] = temp;
        }
    }
}

 
// вывод
Console.WriteLine("Вывод отсортированного массива");
for (int k = 0; k < nums.Length; k++)
{
    Console.Write($"{nums[k]} ");
}